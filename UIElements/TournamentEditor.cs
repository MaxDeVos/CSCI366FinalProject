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

namespace CSCI366FinalProject.UIElements
{
    public partial class TournamentEditor : Form
    {
        private string tournament_name;
        private bool editing;
        private List<ComboBox> comboBoxes;
        private List<TextBox> textBoxes;

        public TournamentEditor()
        {
            InitializeComponent();
            editing = false;
        }
        public TournamentEditor(string name)
        {
            InitializeComponent();
            tournament_name = name;
            editing = true;
        }

        private void TournamentEditor_Load(object sender, EventArgs e)
        {
            comboBoxes = new List<ComboBox> { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, 
                comboBox6, comboBox7, comboBox8, comboBox9, comboBox10, comboBox11, comboBox12, 
                comboBox13, comboBox14, comboBox15 };
            textBoxes = new List<TextBox> { scoreTextBox1, scoreTextBox2, scoreTextBox3, scoreTextBox4,
             scoreTextBox5, scoreTextBox6, scoreTextBox7, scoreTextBox8, scoreTextBox9, scoreTextBox10,
             scoreTextBox11, scoreTextBox12, scoreTextBox13, scoreTextBox14};

            // Populate combo box's items
            var teamNames = teamTableAdapter1.GetDataByAlphabetical().ToList();
            for (int i = 0; i < 15; i++)
            {
                foreach (teamRow row in teamNames)
                {
                    comboBoxes[i].Items.Add(row.team_name);
                }
            }
            
            // Load values if editing
            if (editing)
            {
                tournamentNameTextBox.Text = tournament_name;
                var games = game_listTableAdapter1.GetDataByTournamentName(tournament_name).ToList();
                int i = 0;
                foreach (game_listRow row in games)
                {
                    comboBoxes[i].SelectedIndex = comboBoxes[i].Items.IndexOf(row.team1_name);
                    comboBoxes[i+1].SelectedIndex = comboBoxes[i+1].Items.IndexOf(row.team2_name);
                    textBoxes[i].Text = row.team1_score.ToString();
                    textBoxes[i+1].Text = row.team2_score.ToString();
                    i += 2;
                }
                int winner = tournamentTableAdapter1.GetDataByIDFromName(tournament_name).ToList()[0].winner_id;
                string winnerName = teamTableAdapter1.GetDataByTeamID(winner).ToList()[0].team_name;
                comboBox15.SelectedIndex = comboBox15.Items.IndexOf(winnerName);
            }
        }

        private void saveAndExitButton_Click(object sender, EventArgs e)
        {
            string newTournamentName;
            int newWinner;
            int[] newScores = new int[14];
            int newTournamentId;
            int[] newTeams = new int[14];
            int[] originalGameIDs = new int[7];
            if (editing)
            {
                newTournamentName = tournamentNameTextBox.Text;
                newWinner = teamTableAdapter1.GetDataByIDFromName(comboBox15.SelectedItem.ToString()).ToList()[0].team_id;
                for (int i = 0; i < 14; i += 2)
                {
                    newScores[i] = Convert.ToInt32(textBoxes[i].Text);
                    newScores[i + 1] = Convert.ToInt32(textBoxes[i + 1].Text);
                    newTeams[i] = teamTableAdapter1.GetDataByIDFromName(comboBoxes[i].SelectedItem.ToString()).ToList()[0].team_id;
                    newTeams[i + 1] = teamTableAdapter1.GetDataByIDFromName(comboBoxes[i + 1].SelectedItem.ToString()).ToList()[0].team_id;
                    originalGameIDs[i / 2] = game_listTableAdapter1.GetDataByTournamentName(tournament_name)[i / 2].game_id;
                }
                tournamentTableAdapter1.UpdateQuery(newTournamentName, newWinner, tournament_name);
                for (int i = 0; i < 14; i += 2)
                {
                    gameTableAdapter1.UpdateQuery(newScores[i], newScores[i + 1], newTeams[i], newTeams[i + 1], originalGameIDs[i/2]);
                }
                this.Close();
            }
            else //adding
            {
                newTournamentName = tournamentNameTextBox.Text;
                newWinner = teamTableAdapter1.GetDataByIDFromName(comboBox15.SelectedItem.ToString()).ToList()[0].team_id;
                for (int i = 0; i < 14; i += 2)
                {
                    newScores[i] = Convert.ToInt32(textBoxes[i].Text);
                    newScores[i + 1] = Convert.ToInt32(textBoxes[i + 1].Text);
                    newTeams[i] = teamTableAdapter1.GetDataByIDFromName(comboBoxes[i].SelectedItem.ToString()).ToList()[0].team_id;
                    newTeams[i+1] = teamTableAdapter1.GetDataByIDFromName(comboBoxes[i + 1].SelectedItem.ToString()).ToList()[0].team_id;
                }
                tournamentTableAdapter1.Insert(newTournamentName, newWinner);
                newTournamentId = tournamentTableAdapter1.GetDataByIDFromName(tournamentNameTextBox.Text).ToList()[0].tournament_id;
                for (int i = 0; i < 14; i += 2)
                {
                    gameTableAdapter1.Insert(newScores[i], newScores[i + 1], newTournamentId, ((i / 2) + 1),
                        newTeams[i], newTeams[i + 1]);
                }
                this.Close();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
