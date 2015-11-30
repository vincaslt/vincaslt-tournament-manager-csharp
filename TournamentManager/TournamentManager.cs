using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager
{
    class TournamentManager
    {
        public static TournamentManager Instance { get; } = new TournamentManager();

        private TournamentManager() { }

        public Tournament ActiveTournament { get; set; }
        public readonly DatabaseModelContainer Entities = new DatabaseModelContainer();

    }
}
