using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI366FinalProject.UIElements.HomePanels
{
    public partial class ManageTournamentsControlPanel : UserControl
    {
        public ManageTournamentsControlPanel()
        {
            InitializeComponent();
        }

        private void tournamentViewButton_Click(object sender, EventArgs e)
        {
            tournamentNameLabel.Text = TournamentNameTextBox.Text;
        }

        private void tournamentEditButton_Click(object sender, EventArgs e)
        {
            TournamentEditor editor = new TournamentEditor();
            editor.ShowDialog();
        }
    }
}
