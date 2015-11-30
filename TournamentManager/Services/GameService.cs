using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager.Services
{
    class GameService
    {
        public static GameService Instance { get; } = new GameService();

        private readonly DatabaseModelContainer _entities = TournamentManager.Instance.Entities;

        private GameService() { }

        public Game CreateGame(Player whitePlayer, Player blackPlayer, DateTime date, TimeControl time, string result, string movesStr)
        {
            var moves = ParseMoves(movesStr);

            var game = _entities.Games.Add(new Game
            {
                PlayerWhite = _entities.Players.Find(whitePlayer.Id),
                PlayerBlack = _entities.Players.Find(blackPlayer.Id),
                Date = date,
                TimeControl = time,
                Result = result,
                Moves = moves
            });

            _entities.SaveChanges();

            return game;
        }

        public List<Game> FindGamesWon(Player player)
        {
            var games = new List<Game>();

            if (player.GamesAsWhite != null)
            {
                games.AddRange(player.GamesAsWhite.Where(g => g.Result == "1:0"));
            }

            if (player.GamesAsBlack != null)
            {
                games.AddRange(player.GamesAsBlack.Where(g => g.Result == "0:1"));
            }
                
            return games;
        }

        public List<Game> FindGamesDrawn(Player player)
        {
            var games = new List<Game>();

            if (player.GamesAsWhite != null)
            {
                games.AddRange(player.GamesAsWhite.Where(g => g.Result == "1/2:1/2"));
            }

            if (player.GamesAsBlack != null)
            {
                games.AddRange(player.GamesAsBlack.Where(g => g.Result == "1/2:1/2"));
            }

            return games;
        }

        private static List<Move> ParseMoves(string str)
        {
            var moves = new List<Move>();
            var splitStr = str.Replace("\n", string.Empty).Split(null);
            for (var i = 0; i <= splitStr.Length - 1; i += 3)
            {
                var moveNumber = int.Parse(splitStr[i].Replace(".", string.Empty));

                for (var j = 1; j <= 2 && i + j < splitStr.Length; j++)
                {
                    var moveStr = splitStr[i + j].Replace("x", string.Empty);
                    moveStr = moveStr.Replace("+", string.Empty);
                    moveStr = moveStr.Replace("#", string.Empty);

                    if (moveStr.Length == 2)
                    {
                        moveStr = "p" + moveStr;
                    }

                    var piece = moveStr[0].ToString();
                    var field = moveStr.Substring(1, 2);

                    if (piece == "O")
                    {
                        piece = "K";
                        field = moveStr == "0-0" ? "sc" : "lc";
                    }

                    moves.Add(new Move
                    {
                        Color = j == 1 ? "w" : "b", 
                        Number = moveNumber,
                        Piece = piece,
                        Field = field
                    });
                }
            }

            return moves;
        } 
    }
}
