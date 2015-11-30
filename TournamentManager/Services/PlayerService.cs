using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using TournamentManager.utils;

namespace TournamentManager.Services
{
    class PlayerService
    {
        public static PlayerService Instance { get; } = new PlayerService();

        private  readonly DatabaseModelContainer _entities = TournamentManager.Instance.Entities;

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

        /*
            Finds players that play in certain tournament using DataTable and DataAdapter
        */
        public List<Player> FindPlayersByTournament(Tournament tournament)
        {
            //return _entities.Players.Where(p => p.Tournaments.Contains(tournament)).ToList();

            var players = new List<Player>();

            const string connectionString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database;Integrated Security=True";

            var table = new DataTable("TournamentPlayers");
            using (var conn = new SqlConnection(connectionString))
            {
                var command = "SELECT * FROM Players, TournamentPlayer " +
                              $"WHERE TournamentPlayer.Tournaments_Id = {tournament.Id}" +
                              "AND Players.Id = TournamentPlayer.Players_Id";

                

                using (var cmd = new SqlCommand(command, conn))
                {
                    var adapter = new SqlDataAdapter(cmd);

                    conn.Open();
                    adapter.Fill(table);
                    conn.Close();
                }
            }

            foreach (DataRow row in table.Rows)
            {
                players.Add(new Player
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Name = row["Name"].ToString(),
                    Surname = row["Surname"].ToString(),
                    BirthDate = DateTime.Parse(row["BirthDate"].ToString()),
                    Rating = row["Rating"].ToString().GetValueOrNull<double>()
                });
            }

            return players;
        }

        public void DeleteTournamentPlayer(Player player, Tournament tournament)
        {
            var t = _entities.Tournaments.Find(tournament.Id);
            t.Players.Remove(_entities.Players.First(p => p.Id == player.Id));
            _entities.SaveChanges();
        }
    }
}
