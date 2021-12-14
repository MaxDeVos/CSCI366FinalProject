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
    public partial class ManagePlayersControlPanel : UserControl
    {

        bool creatingPlayer = false;
        private int selectedPlayerID = -1;
        playersUIDataTable localTable = new playersUIDataTable();
        public ManagePlayersControlPanel()
        {
            InitializeComponent();
            DropDownTeam.Items.Add("Any Team");
            DropDownTeam.SelectedIndex = 0;
            DropDownCountry.Items.Add("Any Country");
            DropDownCountry.SelectedIndex = 0;
            PopulateMenus();
        }

        private void ManagePlayersControlPanel_Load(object sender, EventArgs e)
        {
            
            PlayerDataGridView.DataSource = localTable;
            playersUITableAdapter.FillPlayersForUI(localTable);
            PlayerDataGridView.Update();
            PlayerDataGridView.Show();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FillByFilteredSearch();
        }

        private void FillByFilteredSearch()
        {
            string playername_search = ifNullOrMatchReturnEmpty(TextBoxSearch.Text, "");
            string countryname_search = ifNullOrMatchReturnEmpty(DropDownCountry.Text, "Any Country");
            string teamname_search = ifNullOrMatchReturnEmpty(DropDownTeam.Text, "Any Team");
            playersUITableAdapter.FillByFilteredSearch(localTable, teamname_search, countryname_search, playername_search);
        }

        private playersUIDataTable GetFilledFilteredSearch()
        {
            string playername_search = ifNullOrMatchReturnEmpty(TextBoxSearch.Text, "");
            string countryname_search = ifNullOrMatchReturnEmpty(DropDownCountry.Text, "Any Country");
            string teamname_search = ifNullOrMatchReturnEmpty(DropDownTeam.Text, "Any Team");
            playersUITableAdapter.FillByFilteredSearch(localTable, teamname_search, countryname_search, playername_search);
            return localTable;
        }

        private string ifNullOrMatchReturnEmpty(string str, string match)
        {
            if(str == null || match.Equals(str))
            {
                return "";
            }
            return str.ToLower();
        }

        private void DropDownTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillByFilteredSearch();
        }

        private void DropDownCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillByFilteredSearch();
        }

        private void PopulateMenus()
        {
            location1DataTable tempTable = new location1DataTable();
            finalAssignmentDatabaseDataSet.EnforceConstraints = false;
            location1TableAdapter1.FillUniqueCountries(tempTable);
            var countries = DatabaseUtils.queryTo2DList(tempTable.ToArray());

            foreach (List<object> row in countries)
            {
                DropDownCountry.Items.Add(row[0]);
            }

            PopulateTeamMenu(DropDownTeam);
            DropDownPlayerTeam.Items.Add("");
            PopulateTeamMenu(DropDownPlayerTeam);
        }

        private void PopulateTeamMenu(ComboBox dropDown)
        {
            var teams = teamTableAdapter1.GetDataByAlphabetical().ToList();
            foreach (teamRow row in teams)
            {
                Console.WriteLine(row.team_name);
                dropDown.Items.Add(row.team_name);
            }
        }

        private void PlayerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            creatingPlayer = false;
            modifyCreateLabel.Text = "Modify Player Data";
            if (e.RowIndex >= 0)
            {
                playersUIRow row = (playersUIRow) ((DataRowView) PlayerDataGridView.Rows[e.RowIndex].DataBoundItem).Row;
                PopulatePlayerDataMenu(row.player_id);
                selectedPlayerID = row.player_id;
            }
        }

        private void PopulatePlayerDataMenu(int player_id)
        {
            playerRow playerRow = (playerRow) playerTableAdapter1.GetDataByPlayerID(player_id).Rows[0];
            try { TextBoxFirstName.Text = playerRow.first_name; }
            catch { TextBoxFirstName.Text = ""; }

            try { TextBoxLastName.Text = playerRow.last_name; }
            catch { TextBoxLastName.Text = ""; }

            try { TextBoxPhoneNum.Text = playerRow.phone; }
            catch { TextBoxPhoneNum.Text = ""; }

            try { TextBoxJerseyNum.Text = playerRow.jersey_num.ToString(); }
            catch { TextBoxJerseyNum.Text = ""; }


            teamRow teamRow = (teamRow) teamTableAdapter1.GetDataByTeamID(playerRow.team_id).Rows[0];
            try { DropDownPlayerTeam.Text = teamRow.team_name; }
            catch { DropDownPlayerTeam.Text = ""; }
            

            locationRow locationRow = (locationRow)locationTableAdapter.GetDataByLocationID(playerRow.home_location_id).Rows[0];

            try { TextBoxStreetAddress.Text = locationRow.street_address; }
            catch { TextBoxStreetAddress.Text = ""; }

            try { TextBoxCity.Text = locationRow.city; }
            catch { TextBoxCity.Text = ""; }

            try { TextBoxState.Text = locationRow.state_prov; }
            catch { TextBoxState.Text = ""; }

            try { TextBoxPlayerCountry.Text = locationRow.country; }
            catch { TextBoxPlayerCountry.Text = ""; }

        }

        private void ButtonSaveChanges_Click(object sender, EventArgs e)
        {

            try
            {

                teamRow teamRow = (teamRow)teamTableAdapter1.GetDataByTeamName(DropDownPlayerTeam.Text).Rows[0];

                if (creatingPlayer)
                {
                    int locationID = (int)queriesTableAdapter1.GetLargestLocationID() + 1;
                    int playerID = (int)queriesTableAdapter1.GetLargestPlayerID() + 1;
                    locationTableAdapter.InsertQuery(locationID, TextBoxStreetAddress.Text, TextBoxCity.Text,
                        TextBoxState.Text, TextBoxPlayerCountry.Text);
                    playerTableAdapter1.InsertPlayer(playerID, TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxPhoneNum.Text,
                        Int32.Parse(TextBoxJerseyNum.Text), locationID, teamRow.team_id);
                    EmptyModifyPlayerBox();
                }
                else
                {

                    playerTableAdapter1.UpdateQuery(TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxPhoneNum.Text,
                        Int32.Parse(TextBoxJerseyNum.Text), teamRow.team_id, selectedPlayerID);
                }
                PlayerDataGridView.DataSource = GetFilledFilteredSearch();
                PlayerDataGridView.Update();
                PlayerDataGridView.Refresh();

            }
            catch
            {
                MessageBox.Show("Invalid Entry");
            }

        }

        private void EmptyModifyPlayerBox()
        {
            TextBoxFirstName.Text = "";
            TextBoxLastName.Text = "";
            TextBoxPhoneNum.Text = "";
            TextBoxJerseyNum.Text = "";
            DropDownPlayerTeam.Text = "";
            TextBoxStreetAddress.Text = "";
            TextBoxCity.Text = "";
            TextBoxState.Text = "";
            TextBoxPlayerCountry.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            creatingPlayer = true;
            EmptyModifyPlayerBox();
            modifyCreateLabel.Text = "Creating New Player";
        }

        private void deletePlayer_Click(object sender, EventArgs e)
        {
            playerTableAdapter1.DeletePlayer(selectedPlayerID);
            PlayerDataGridView.DataSource = GetFilledFilteredSearch();
            PlayerDataGridView.Update();
            PlayerDataGridView.Refresh();
        }
    }
}
