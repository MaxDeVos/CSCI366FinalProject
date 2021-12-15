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
    public partial class ManageTeamsControlPanel : UserControl { 
         bool creatingPlayer = false;
        private int selectedPlayerID = -1;
        teamDataTable localTable = new teamDataTable();

        public ManageTeamsControlPanel()
        {
            InitializeComponent();
            DropDownCountry.Items.Add("Any Country");
            DropDownCountry.SelectedIndex = 0;
            PopulateMenus();
        }

        private void FillByFilteredSearch()
        {
            string playername_search = ifNullOrMatchReturnEmpty(TextBoxSearch.Text, "");
            string countryname_search = ifNullOrMatchReturnEmpty(DropDownCountry.Text, "Any Country");
            teamTableAdapter1.FillByFilterSearch(localTable, playername_search, countryname_search);
        }

        private teamDataTable GetFilledFilteredSearch()
        {
            string playername_search = ifNullOrMatchReturnEmpty(TextBoxSearch.Text, "");
            string countryname_search = ifNullOrMatchReturnEmpty(DropDownCountry.Text, "Any Country");
            teamTableAdapter1.FillByFilterSearch(localTable, playername_search, countryname_search);
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
        private void PopulateMenus()
        {
            location1DataTable tempTable = new location1DataTable();
            finalAssignmentDatabaseDataSet1.EnforceConstraints = false;
            location1TableAdapter1.FillUniqueCountries(tempTable);
            var countries = DatabaseUtils.queryTo2DList(tempTable.ToArray());

            foreach (List<object> row in countries)
            {
                DropDownCountry.Items.Add(row[0]);
            }
        }

        private void PopulatePlayerDataMenu(int player_id)
        {
            teamRow playerRow = (teamRow) teamTableAdapter1.GetDataByTeamID(player_id).Rows[0];
            try { TextBoxFirstName.Text = playerRow.team_name; }
            catch { TextBoxFirstName.Text = ""; }
            

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
            TextBoxStreetAddress.Text = "";
            TextBoxCity.Text = "";
            TextBoxState.Text = "";
            TextBoxPlayerCountry.Text = "";
        }

        private void ManageTeamsControlPanel_Load(object sender, EventArgs e)
        {

            PlayerDataGridView.DataSource = localTable;
            teamTableAdapter1.FillByTeamUI(localTable);
            PlayerDataGridView.Update();
            PlayerDataGridView.Show();
        }

        private void TextBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            FillByFilteredSearch();
        }

        private void DropDownCountry_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FillByFilteredSearch();
        }

        private void deletePlayer_Click_1(object sender, EventArgs e)
        {
            teamTableAdapter1.DeleteTeam(selectedPlayerID);
            PlayerDataGridView.DataSource = GetFilledFilteredSearch();
            PlayerDataGridView.Update();
            PlayerDataGridView.Refresh();
            EmptyModifyPlayerBox();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            creatingPlayer = true;
            EmptyModifyPlayerBox();
            modifyCreateLabel.Text = "Creating New Player";
        }

        private void ButtonSaveChanges_Click_1(object sender, EventArgs e)
        {

            if (creatingPlayer)
            {
                int locationID = (int)queriesTableAdapter1.GetLargestLocationID() + 1;
                int teamID = (int)queriesTableAdapter1.GetHighestTeamID() + 1;
                locationTableAdapter1.InsertQuery(locationID, TextBoxStreetAddress.Text, TextBoxCity.Text,
                    TextBoxState.Text, TextBoxPlayerCountry.Text);
                teamTableAdapter1.InsertTeam(teamID, TextBoxFirstName.Text, locationID);
                EmptyModifyPlayerBox();
            }
            else
            {
                teamTableAdapter1.UpdateQuery(TextBoxFirstName.Text, selectedPlayerID);

            }
            PlayerDataGridView.DataSource = GetFilledFilteredSearch();
            PlayerDataGridView.Update();
            PlayerDataGridView.Refresh();
        }

        private void PlayerDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
        creatingPlayer = false;
        modifyCreateLabel.Text = "Modify Player Data";
        if (e.RowIndex >= 0)
        {
            teamRow row = (teamRow)((DataRowView)PlayerDataGridView.Rows[e.RowIndex].DataBoundItem).Row;
            PopulatePlayerDataMenu(row.team_id);
            selectedPlayerID = row.team_id;
        }
        }
    }
}
