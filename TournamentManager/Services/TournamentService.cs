using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentManager.Services
{
    class TournamentService
    {
        public static TournamentService Instance { get; } = new TournamentService();

        private readonly DatabaseModelContainer _entities = TournamentManager.Instance.Entities;

        private TournamentService() { }

        public Tournament CreateTournament(string name, List<AgeGroup> groups, 
            List<TimeControl> timeControls)
        {
            var tournament = _entities.Tournaments.Add(new Tournament
            {
                Name = name,
                TimeControls = timeControls,
                AgeGroups = groups,
                Date = DateTime.Today
            });
            _entities.SaveChanges();

            return tournament;
        }

        public List<Tournament> AllTournaments()
        {
            return _entities.Tournaments.ToList();
        }

        public List<AgeGroup> AllAgeGroups()
        {
            return _entities.AgeGroups.ToList();
        }

        public List<TimeControl> AllTimeControls()
        {
            return _entities.TimeControls.ToList();
        }

        public Tournament FindTournamentById(int id)
        {
            return _entities.Tournaments.First(t => t.Id == id);
        }
    }
}
