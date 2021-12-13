using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CSCI366FinalProject.FinalAssignmentDatabaseDataSet;

namespace CSCI366FinalProject.UIElements.HomePanels
{
    public partial class ManageTournamentsControlPanel : UserControl
    {
        private List<Label> teamLabels;

        public ManageTournamentsControlPanel()
        {
            InitializeComponent();
            teamLabels = new List<Label> { teamLabel1, teamLabel2, teamLabel3, teamLabel4,
            teamLabel5, teamLabel6, teamLabel7, teamLabel8, teamLabel9, teamLabel10, teamLabel11,
            teamLabel12, teamLabel13, teamLabel14};
        }

        private void ManageTournamentsControlPanel_Load(object sender, EventArgs e)
        {
            PopulateTournamentList();
        }

        private void tournamentEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                int tournament_id = tournamentTableAdapter1.GetDataByIDFromName(tournamentDropBox.SelectedItem).ToArray()[0].tournament_id;
                TournamentEditor editor = new TournamentEditor(tournament_id);
                editor.ShowDialog();
            }
            catch(System.ArgumentNullException)
            {
                MessageBox.Show("Please select a tournament to edit.");
            }
        }

        private void PopulateTournamentList()
        {
            var tournamentNames = tournamentTableAdapter1.GetDataByName().ToList();
            foreach (tournamentRow row in tournamentNames)
            {
                tournamentDropBox.Items.Add(row.tournament_name);
            }
        }

        private void tournamentDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tournament = tournamentTableAdapter1.GetDataByIDFromName(tournamentDropBox.SelectedItem).ToArray();
            //Console.WriteLine(tournament[0].tournament_id);
            var gameList = game_listTableAdapter1.GetDataByTournamentName(tournament[0].tournament_name).ToArray();
            int i = 0;
            foreach (game_listRow game in gameList)
            {
                teamLabels[i].Text = game.team1_name + " - " + game.team1_score;
                teamLabels[i+1].Text = game.team2_name + " - " + game.team2_score;
                i +=2;
            }
            teamLabel15.Text = tournament_winnerTableAdapter1.GetDataByName(tournament[0].tournament_name).ToArray()[0].team_name;
        }

    }
}
