using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager.Services
{
    class GameService
    {
        public static GameService Instance { get; } = new GameService();

        private readonly DatabaseModelContainer _entities = new DatabaseModelContainer();

        private GameService() { }

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
    }
}
