using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCI366FinalProject.UIElements.HomePanels;

namespace CSCI366FinalProject
{
    public partial class HomeWindow : Form
    {
        List<Button> side_buttons = new List<Button>();
        public HomeWindow()
        {
            InitializeComponent();
            side_buttons.Add(ButtonManageCoaches);
            side_buttons.Add(ButtonManagePlayers);
            side_buttons.Add(ButtonManageTeams);
            side_buttons.Add(ButtonManageTournaments);
            side_buttons.Add(ButtonSeeAnalytics);
            MainPanel.Controls.Add(new ManageTeamsControlPanel());
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void ButtonManageTeams_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ManageTeamsControlPanel());
        }

        private void ButtonManagePlayers_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ManagePlayersControlPanel());

        }

        private void ButtonManageCoaches_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ManageCoachesControlPanel());
        }

        private void ButtonManageTournaments_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ManageTournamentsControlPanel());
        }

        private void ButtonSeeAnalytics_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ViewAnalyticsControlPanel());
        }
    }
}
