using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentManager.Services;

namespace TournamentManager.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewPlayerForm().Show();
        }

        private void newResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewGameForm().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            listViewTable.Items.Clear();
            var tournament = 
                TournamentService.Instance.FindTournamentById(TournamentManager.Instance.ActiveTournament.Id);
            if (tournament.Players == null) return;

            foreach (var player in tournament.Players)
            {
                var entry = new ListViewItem(player.Name);
                entry.SubItems.Add(player.Surname);
                entry.SubItems.Add(player.Rating.ToString());
                entry.SubItems.Add((
                    GameService.Instance.FindGamesWon(player).Count + 
                    GameService.Instance.FindGamesDrawn(player).Count * 0.5
                ).ToString(CultureInfo.CurrentCulture));
                entry.SubItems.Add((player.GamesAsWhite?.Count + player.GamesAsBlack?.Count).ToString());
                entry.SubItems.Add(PlayerService.Instance.FindPlayerGroup(player).Name);
                entry.Tag = player;
                listViewTable.Items.Add(entry);
            }
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void listViewTable_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                PlayerService.Instance.DeleteTournamentPlayer(
                    (Player)listViewTable.SelectedItems[0].Tag, TournamentManager.Instance.ActiveTournament); 
                RefreshTable();
            }
        }
    }
}
