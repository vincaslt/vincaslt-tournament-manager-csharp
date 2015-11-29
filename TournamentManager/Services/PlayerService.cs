using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager.Services
{
    class PlayerService
    {
        public static PlayerService Instance { get; } = new PlayerService();

        private  readonly DatabaseModelContainer _entities = new DatabaseModelContainer();

        private PlayerService() { }

        public Player CreatePlayer(int fideNumber, string name, string surname, DateTime birthDate, double? rating = null)
        {
            var player = _entities.Players.Add(new Player
            {
                Id = fideNumber,
                BirthDate = new DateTime(birthDate.Year, birthDate.Month, birthDate.Day),
                Name = name,
                Surname = surname,
                Rating = rating
            });

            _entities.Tournaments.First(
                t => t.Id.Equals(TournamentManager.Instance.ActiveTournament.Id)).Players.Add(player);

            _entities.SaveChanges();
            return player;
        }

        public AgeGroup FindPlayerGroup(Player player)
        {
            return _entities.AgeGroups
                .Where(g => player.BirthDate >= g.BirthDate)
                .OrderByDescending(x => x.BirthDate)
                .First();
        }
    }
}
