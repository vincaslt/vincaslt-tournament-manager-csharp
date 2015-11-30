using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentManager.Services;

namespace TournamentManager.Forms
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            /*var game = GameService.Instance.CreateGame
                (
                );*/
        }

        private void NewGameForm_Load(object sender, EventArgs e)
        {
            var players = 
                PlayerService.Instance.FindPlayersByTournament(TournamentManager.Instance.ActiveTournament);
            players.ForEach(p => comboWhite.Items.Add(p));
        }
    }
}
