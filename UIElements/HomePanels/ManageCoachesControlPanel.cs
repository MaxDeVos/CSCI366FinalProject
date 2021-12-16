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
    public partial class ManageCoachesControlPanel : UserControl
    {
        bool creatingCoach = false;
        private int selectedPlayerID = -1;
        coachDataTable localTable = new coachDataTable();
        public ManageCoachesControlPanel()
        {
            InitializeComponent();
            DropDownTeam.Items.Add("Any Team");
            DropDownTeam.SelectedIndex = 0;
            DropDownCountry.Items.Add("Any Country");
            DropDownCountry.SelectedIndex = 0;
            PopulateMenus();

        }

        private void ManageCoachesControlPanel_Load(object sender, EventArgs e)
        {
            PlayerDataGridView.DataSource = localTable;
            coachTableAdapter1.FillCoachForUI(localTable);
            PlayerDataGridView.Update();
            PlayerDataGridView.Show();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FillByFilteredSearch();
        }

        private void FillByFilteredSearch()
        {
            string coachname_search = ifNullOrMatchReturnEmpty(TextBoxSearch.Text, "");
            string countryname_search = ifNullOrMatchReturnEmpty(DropDownCountry.Text, "Any Country");
            string teamname_search = ifNullOrMatchReturnEmpty(DropDownTeam.Text, "Any Team");
            coachTableAdapter1.FillByFilteredSearch(localTable, teamname_search, countryname_search, coachname_search);
        }
        private string ifNullOrMatchReturnEmpty(string str, string match)
        {
            if (str == null || match.Equals(str))
            {
                return "";
            }
            return str.ToLower();
        }
        private coachDataTable GetFilledFilteredSearch()
        {
            string playername_search = ifNullOrMatchReturnEmpty(TextBoxSearch.Text, "");
            string countryname_search = ifNullOrMatchReturnEmpty(DropDownCountry.Text, "Any Country");
            string teamname_search = ifNullOrMatchReturnEmpty(DropDownTeam.Text, "Any Team");
            coachTableAdapter1.FillByFilteredSearch(localTable, teamname_search, countryname_search, playername_search);
            return localTable;
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
                dropDown.Items.Add(row.team_name);
            }
        }
        private void PopulatePlayerDataMenu(int player_id)
        {
            coachRow playerRow = (coachRow)coachTableAdapter1.GetDataByCoachID(player_id).Rows[0];
            try { TextBoxFirstName.Text = playerRow.first_name; }
            catch { TextBoxFirstName.Text = ""; }

            try { TextBoxLastName.Text = playerRow.last_name; }
            catch { TextBoxLastName.Text = ""; }

            try { TextBoxPhoneNum.Text = playerRow.phone; }
            catch { TextBoxPhoneNum.Text = ""; }

            try { TextBoxEmail.Text = playerRow.email; }
            catch { TextBoxEmail.Text = ""; }

            teamRow teamRow = (teamRow)teamTableAdapter1.GetDataByTeamID(playerRow.team_id).Rows[0];
            try { DropDownPlayerTeam.Text = teamRow.team_name; }
            catch { DropDownPlayerTeam.Text = ""; }


            locationRow locationRow = (locationRow)locationTableAdapter1.GetDataByLocationID(playerRow.location_id).Rows[0];

            try { TextBoxStreetAddress.Text = locationRow.street_address; }
            catch { TextBoxStreetAddress.Text = ""; }

            try { TextBoxCity.Text = locationRow.city; }
            catch { TextBoxCity.Text = ""; }

            try { TextBoxState.Text = locationRow.state_prov; }
            catch { TextBoxState.Text = ""; }

            try { TextBoxPlayerCountry.Text = locationRow.country; }
            catch { TextBoxPlayerCountry.Text = ""; }

        }

        private void EmptyModifyPlayerBox()
        {
            TextBoxFirstName.Text = "";
            TextBoxLastName.Text = "";
            TextBoxPhoneNum.Text = "";
            TextBoxEmail.Text = "";
            DropDownPlayerTeam.Text = "";
            TextBoxStreetAddress.Text = "";
            TextBoxCity.Text = "";
            TextBoxState.Text = "";
            TextBoxPlayerCountry.Text = "";
        }

        private void ButtonSaveChanges_Click_1(object sender, EventArgs e)
        {

            teamRow teamRow = (teamRow)teamTableAdapter1.GetDataByTeamName(DropDownPlayerTeam.Text).Rows[0];

            if (creatingCoach)
            {
                int locationID = (int)queriesTableAdapter1.GetLargestLocationID() + 1;
                int playerID = (int)queriesTableAdapter1.GetLargestCoachID() + 1;
                locationTableAdapter1.InsertQuery(locationID, TextBoxStreetAddress.Text, TextBoxCity.Text,
                    TextBoxState.Text, TextBoxPlayerCountry.Text);
                coachTableAdapter1.InsertCoach(playerID, TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxPhoneNum.Text, TextBoxEmail.Text, locationID, teamRow.team_id);
                EmptyModifyPlayerBox();
            }
            else
            {
                coachRow row = (coachRow)coachTableAdapter1.GetDataByCoachID(selectedPlayerID).Rows[0];
                locationTableAdapter1.UpdateLocation(TextBoxStreetAddress.Text, TextBoxCity.Text,
                    TextBoxState.Text, TextBoxPlayerCountry.Text, row.location_id);
                coachTableAdapter1.UpdateQuery(TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxPhoneNum.Text,
                    TextBoxEmail.Text, teamRow.team_id, selectedPlayerID);

            }
            PlayerDataGridView.DataSource = GetFilledFilteredSearch();
            PlayerDataGridView.Update();
            PlayerDataGridView.Refresh();
        }

        private void PlayerDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            creatingCoach = false;
            modifyCreateLabel.Text = "Modify Coach Data";
            Console.WriteLine("Cell Content Clicked");
            if (e.RowIndex >= 0)
            {
                coachRow row = (coachRow)((DataRowView)PlayerDataGridView.Rows[e.RowIndex].DataBoundItem).Row;
                PopulatePlayerDataMenu(row.coach_id);
                selectedPlayerID = row.coach_id;
            }
        }

        private void DropDownTeam_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Console.WriteLine("Team Index Changed");
            FillByFilteredSearch();
        }

        private void DropDownCountry_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FillByFilteredSearch();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            creatingCoach = true;
            EmptyModifyPlayerBox();
            modifyCreateLabel.Text = "Creating New Coach";
        }

        private void deletePlayer_Click(object sender, EventArgs e)
        {
            coachTableAdapter1.DeleteCoach(selectedPlayerID);
            PlayerDataGridView.DataSource = GetFilledFilteredSearch();
            PlayerDataGridView.Update();
            PlayerDataGridView.Refresh();
        }
    }
}
