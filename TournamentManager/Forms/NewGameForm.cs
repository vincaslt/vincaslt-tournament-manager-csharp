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
            var result = radioResultWhite.Checked ? "1:0" : "1/2:1/2";
            result = radioResultBlack.Checked ? "0:1" : result;

            var game = GameService.Instance.CreateGame
                (
                    whitePlayer: (Player) comboWhite.SelectedItem,
                    blackPlayer: (Player) comboBlack.SelectedItem,
                    date: TournamentManager.Instance.ActiveTournament.Date,
                    time: (TimeControl) comboTimeControl.SelectedItem,
                    result: result,
                    movesStr: textBoxMoves.Text
                );

            Close();
        }

        private void NewGameForm_Load(object sender, EventArgs e)
        {
            var players = 
                PlayerService.Instance.FindPlayersByTournament(TournamentManager.Instance.ActiveTournament);

            players.ForEach(p =>
            {
                comboWhite.Items.Add(p);
                comboBlack.Items.Add(p);
            });

            TournamentManager.Instance.ActiveTournament.TimeControls.ToList()
                .ForEach(c => comboTimeControl.Items.Add(c));
        }
    }
}
