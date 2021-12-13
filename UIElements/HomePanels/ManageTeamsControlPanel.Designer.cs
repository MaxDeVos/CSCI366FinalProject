
namespace CSCI366FinalProject.UIElements.HomePanels
{
    partial class ManageTeamsControlPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxPlayerCountry = new System.Windows.Forms.TextBox();
            this.TextBoxState = new System.Windows.Forms.TextBox();
            this.TextBoxCity = new System.Windows.Forms.TextBox();
            this.TextBoxStreetAddress = new System.Windows.Forms.TextBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.modifyCreateLabel = new System.Windows.Forms.Label();
            this.ButtonSaveChanges = new System.Windows.Forms.Button();
            this.deletePlayer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LabelCountry = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.DropDownCountry = new System.Windows.Forms.ComboBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.PlayerDataGridView = new System.Windows.Forms.DataGridView();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalAssignmentDatabaseDataSet = new CSCI366FinalProject.FinalAssignmentDatabaseDataSet();
            this.teamTableAdapter1 = new CSCI366FinalProject.FinalAssignmentDatabaseDataSetTableAdapters.teamTableAdapter();
            this.locationTableAdapter1 = new CSCI366FinalProject.FinalAssignmentDatabaseDataSetTableAdapters.locationTableAdapter();
            this.location1TableAdapter1 = new CSCI366FinalProject.FinalAssignmentDatabaseDataSetTableAdapters.location1TableAdapter();
            this.finalAssignmentDatabaseDataSet1 = new CSCI366FinalProject.FinalAssignmentDatabaseDataSet();
            this.queriesTableAdapter1 = new CSCI366FinalProject.FinalAssignmentDatabaseDataSetTableAdapters.QueriesTableAdapter();
            this.teamnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAssignmentDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAssignmentDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TextBoxPlayerCountry);
            this.panel1.Controls.Add(this.TextBoxState);
            this.panel1.Controls.Add(this.TextBoxCity);
            this.panel1.Controls.Add(this.TextBoxStreetAddress);
            this.panel1.Controls.Add(this.TextBoxFirstName);
            this.panel1.Controls.Add(this.modifyCreateLabel);
            this.panel1.Controls.Add(this.ButtonSaveChanges);
            this.panel1.Location = new System.Drawing.Point(754, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 510);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Team Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "State/Prov";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "City";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Street Addr.";
            // 
            // TextBoxPlayerCountry
            // 
            this.TextBoxPlayerCountry.Location = new System.Drawing.Point(104, 163);
            this.TextBoxPlayerCountry.Name = "TextBoxPlayerCountry";
            this.TextBoxPlayerCountry.Size = new System.Drawing.Size(167, 20);
            this.TextBoxPlayerCountry.TabIndex = 10;
            // 
            // TextBoxState
            // 
            this.TextBoxState.Location = new System.Drawing.Point(104, 137);
            this.TextBoxState.Name = "TextBoxState";
            this.TextBoxState.Size = new System.Drawing.Size(167, 20);
            this.TextBoxState.TabIndex = 9;
            // 
            // TextBoxCity
            // 
            this.TextBoxCity.Location = new System.Drawing.Point(104, 111);
            this.TextBoxCity.Name = "TextBoxCity";
            this.TextBoxCity.Size = new System.Drawing.Size(167, 20);
            this.TextBoxCity.TabIndex = 8;
            // 
            // TextBoxStreetAddress
            // 
            this.TextBoxStreetAddress.Location = new System.Drawing.Point(104, 85);
            this.TextBoxStreetAddress.Name = "TextBoxStreetAddress";
            this.TextBoxStreetAddress.Size = new System.Drawing.Size(167, 20);
            this.TextBoxStreetAddress.TabIndex = 7;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(104, 59);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(167, 20);
            this.TextBoxFirstName.TabIndex = 2;
            // 
            // modifyCreateLabel
            // 
            this.modifyCreateLabel.AutoSize = true;
            this.modifyCreateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyCreateLabel.Location = new System.Drawing.Point(36, 11);
            this.modifyCreateLabel.Name = "modifyCreateLabel";
            this.modifyCreateLabel.Size = new System.Drawing.Size(203, 25);
            this.modifyCreateLabel.TabIndex = 1;
            this.modifyCreateLabel.Text = "Modify Team Data";
            // 
            // ButtonSaveChanges
            // 
            this.ButtonSaveChanges.Location = new System.Drawing.Point(3, 456);
            this.ButtonSaveChanges.Name = "ButtonSaveChanges";
            this.ButtonSaveChanges.Size = new System.Drawing.Size(277, 49);
            this.ButtonSaveChanges.TabIndex = 0;
            this.ButtonSaveChanges.Text = "Save Changes";
            this.ButtonSaveChanges.UseVisualStyleBackColor = true;
            this.ButtonSaveChanges.Click += new System.EventHandler(this.ButtonSaveChanges_Click_1);
            // 
            // deletePlayer
            // 
            this.deletePlayer.Location = new System.Drawing.Point(758, 17);
            this.deletePlayer.Name = "deletePlayer";
            this.deletePlayer.Size = new System.Drawing.Size(126, 49);
            this.deletePlayer.TabIndex = 16;
            this.deletePlayer.Text = "Delete Selected Team";
            this.deletePlayer.UseVisualStyleBackColor = true;
            this.deletePlayer.Click += new System.EventHandler(this.deletePlayer_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(909, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "Create New Team";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // LabelCountry
            // 
            this.LabelCountry.AutoSize = true;
            this.LabelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCountry.Location = new System.Drawing.Point(460, 33);
            this.LabelCountry.Name = "LabelCountry";
            this.LabelCountry.Size = new System.Drawing.Size(60, 16);
            this.LabelCountry.TabIndex = 14;
            this.LabelCountry.Text = "Country";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(23, 33);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(49, 16);
            this.LabelName.TabIndex = 13;
            this.LabelName.Text = "Name";
            // 
            // DropDownCountry
            // 
            this.DropDownCountry.FormattingEnabled = true;
            this.DropDownCountry.Location = new System.Drawing.Point(463, 52);
            this.DropDownCountry.Name = "DropDownCountry";
            this.DropDownCountry.Size = new System.Drawing.Size(256, 21);
            this.DropDownCountry.TabIndex = 12;
            this.DropDownCountry.SelectedIndexChanged += new System.EventHandler(this.DropDownCountry_SelectedIndexChanged_1);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(23, 52);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(325, 20);
            this.TextBoxSearch.TabIndex = 11;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged_1);
            // 
            // PlayerDataGridView
            // 
            this.PlayerDataGridView.AllowUserToAddRows = false;
            this.PlayerDataGridView.AutoGenerateColumns = false;
            this.PlayerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamnameDataGridViewTextBoxColumn,
            this.Country});
            this.PlayerDataGridView.DataSource = this.teamBindingSource;
            this.PlayerDataGridView.Location = new System.Drawing.Point(23, 79);
            this.PlayerDataGridView.MultiSelect = false;
            this.PlayerDataGridView.Name = "PlayerDataGridView";
            this.PlayerDataGridView.Size = new System.Drawing.Size(696, 510);
            this.PlayerDataGridView.TabIndex = 9;
            this.PlayerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerDataGridView_CellClick_1);
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "team";
            this.teamBindingSource.DataSource = this.finalAssignmentDatabaseDataSet;
            // 
            // finalAssignmentDatabaseDataSet
            // 
            this.finalAssignmentDatabaseDataSet.DataSetName = "FinalAssignmentDatabaseDataSet";
            this.finalAssignmentDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamTableAdapter1
            // 
            this.teamTableAdapter1.ClearBeforeFill = true;
            // 
            // locationTableAdapter1
            // 
            this.locationTableAdapter1.ClearBeforeFill = true;
            // 
            // location1TableAdapter1
            // 
            this.location1TableAdapter1.ClearBeforeFill = true;
            // 
            // finalAssignmentDatabaseDataSet1
            // 
            this.finalAssignmentDatabaseDataSet1.DataSetName = "FinalAssignmentDatabaseDataSet";
            this.finalAssignmentDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamnameDataGridViewTextBoxColumn
            // 
            this.teamnameDataGridViewTextBoxColumn.DataPropertyName = "team_name";
            this.teamnameDataGridViewTextBoxColumn.HeaderText = "Team Name";
            this.teamnameDataGridViewTextBoxColumn.Name = "teamnameDataGridViewTextBoxColumn";
            this.teamnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.Width = 200;
            // 
            // ManageTeamsControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deletePlayer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LabelCountry);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.DropDownCountry);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.PlayerDataGridView);
            this.Name = "ManageTeamsControlPanel";
            this.Size = new System.Drawing.Size(1063, 604);
            this.Load += new System.EventHandler(this.ManageTeamsControlPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAssignmentDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAssignmentDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBoxPlayerCountry;
        private System.Windows.Forms.TextBox TextBoxState;
        private System.Windows.Forms.TextBox TextBoxCity;
        private System.Windows.Forms.TextBox TextBoxStreetAddress;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Label modifyCreateLabel;
        private System.Windows.Forms.Button ButtonSaveChanges;
        private System.Windows.Forms.Button deletePlayer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabelCountry;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.ComboBox DropDownCountry;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.DataGridView PlayerDataGridView;
        private FinalAssignmentDatabaseDataSetTableAdapters.teamTableAdapter teamTableAdapter1;
        private FinalAssignmentDatabaseDataSetTableAdapters.locationTableAdapter locationTableAdapter1;
        private FinalAssignmentDatabaseDataSetTableAdapters.location1TableAdapter location1TableAdapter1;
        private FinalAssignmentDatabaseDataSet finalAssignmentDatabaseDataSet;
        private FinalAssignmentDatabaseDataSet finalAssignmentDatabaseDataSet1;
        private FinalAssignmentDatabaseDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
    }
}
