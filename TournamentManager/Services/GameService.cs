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

        private readonly DatabaseModelContainer _entities = new DatabaseModelContainer();

        private GameService() { }

        public Game CreateGame(Player whitePlayer, Player blackPlayer, DateTime date, TimeControl time)
        {
            var game = _entities.Games.Add(new Game
            {
                PlayerWhite = whitePlayer,
                PlayerBlack = blackPlayer,
                Date = date,
                TimeControl = time
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

        public List<Move> ParseMoves(string str, Game game)
        {
            var moves = new List<Move>();
            var splitStr = str.Split(null);
            for (var i = 0; i <= splitStr.Length - 3; i += 3)
            {
                var moveNumber = int.Parse(splitStr[0].TrimEnd('.'));

                for (var j = 0; j < 2; j++)
                {
                    var moveStr = splitStr[i + 1].Replace("x", "");

                    if (moveStr.Length == 4)
                    {
                        moveStr = "p" + moveStr;
                    }
                    
                    moves.Add(new Move
                    {
                        Color = j == 1 ? "w" : "b", 
                        Number = moveNumber,
                        Game = game,
                        Piece = moveStr[0].ToString(),
                        From = moveStr.Substring(1, 2),
                        To = moveStr.Substring(3, 2)
                    });
                }
            }

            return moves;
        } 
    }
}
