using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentManager.Services;

namespace TournamentManager.Forms
{
    public partial class WizardForm : Form
    {
        public WizardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tournament = (Tournament) comboBoxOpen.SelectedItem;

            if (comboBoxOpen.SelectedIndex == -1)
            {
                tournament = TournamentService.Instance.CreateTournament(textBoxName.Text, 
                    checkedListBoxAge.CheckedItems.Cast<AgeGroup>().ToList(),
                    checkedListBoxTime.CheckedItems.Cast<TimeControl>().ToList());
            }

            TournamentManager.Instance.ActiveTournament = tournament;
            new MainForm().Show();
            Hide();
        }

        private void WizardForm_Load(object sender, EventArgs e)
        {
            TournamentService.Instance.AllAgeGroups().ForEach(i => checkedListBoxAge.Items.Add(i));
            TournamentService.Instance.AllTimeControls().ForEach(i => checkedListBoxTime.Items.Add(i));
            TournamentService.Instance.AllTournaments().ForEach(i => comboBoxOpen.Items.Add(i));
        }

        private void comboBoxOpen_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxCreate.Enabled = false;
        }

        private void WizardForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
