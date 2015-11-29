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
using TournamentManager.utils;

namespace TournamentManager
{
    public partial class NewPlayerForm : Form
    {
        public NewPlayerForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            PlayerService.Instance.CreatePlayer(
                fideNumber: int.Parse(textBoxNumber.Text),
                name: textBoxName.Text,
                surname: textBoxSurname.Text,
                birthDate: calendarBirthDate.SelectionStart,
                rating: textBoxRating.Text.GetValueOrNull<double>()
            );
            Close();
        }
    }
}
