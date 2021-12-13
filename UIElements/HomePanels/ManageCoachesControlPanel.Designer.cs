
namespace CSCI366FinalProject.UIElements.HomePanels
{
    partial class ManageCoachesControlPanel
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DropDownPlayerTeam = new System.Windows.Forms.ComboBox();
            this.TextBoxPlayerCountry = new System.Windows.Forms.TextBox();
            this.TextBoxState = new System.Windows.Forms.TextBox();
            this.TextBoxStreetAddress = new System.Windows.Forms.TextBox();
            this.TextBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.ButtonSaveChanges = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxCity = new System.Windows.Forms.TextBox();
            this.modifyCreateLabel = new System.Windows.Forms.Label();
            this.deletePlayer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PlayerDataGridView = new System.Windows.Forms.DataGridView();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalAssignmentDatabaseDataSet = new CSCI366FinalProject.FinalAssignmentDatabaseDataSet();
            this.DropDownCountry = new System.Windows.Forms.ComboBox();
            this.LabelCountry = new System.Windows.Forms.Label();
            this.LabelTeam = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.DropDownTeam = new System.Windows.Forms.ComboBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.coachTableAdapter1 = new CSCI366FinalProject.FinalAssignmentDatabaseDataSetTableAdapters.coachTableAdapter();
            this.teamTableAdapter1 = new CSCI366FinalProject.FinalAssignmentDatabaseDataSetTableAdapters.teamTableAdapter();
            this.location1TableAdapter1 = new CSCI366FinalProject.FinalAssignmentDatabaseDataSetTableAdapters.location1TableAdapter();
            this.locationTableAdapter1 = new CSCI366FinalProject.FinalAssignmentDatabaseDataSetTableAdapters.locationTableAdapter();
            this.queriesTableAdapter1 = new CSCI366FinalProject.FinalAssignmentDatabaseDataSetTableAdapters.QueriesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAssignmentDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "State/Prov";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "City";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Street Addr.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone #";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Team";
            // 
            // DropDownPlayerTeam
            // 
            this.DropDownPlayerTeam.FormattingEnabled = true;
            this.DropDownPlayerTeam.Location = new System.Drawing.Point(16, 234);
            this.DropDownPlayerTeam.Name = "DropDownPlayerTeam";
            this.DropDownPlayerTeam.Size = new System.Drawing.Size(255, 21);
            this.DropDownPlayerTeam.TabIndex = 11;
            // 
            // TextBoxPlayerCountry
            // 
            this.TextBoxPlayerCountry.Location = new System.Drawing.Point(104, 389);
            this.TextBoxPlayerCountry.Name = "TextBoxPlayerCountry";
            this.TextBoxPlayerCountry.Size = new System.Drawing.Size(167, 20);
            this.TextBoxPlayerCountry.TabIndex = 10;
            // 
            // TextBoxState
            // 
            this.TextBoxState.Location = new System.Drawing.Point(104, 363);
            this.TextBoxState.Name = "TextBoxState";
            this.TextBoxState.Size = new System.Drawing.Size(167, 20);
            this.TextBoxState.TabIndex = 9;
            // 
            // TextBoxStreetAddress
            // 
            this.TextBoxStreetAddress.Location = new System.Drawing.Point(104, 311);
            this.TextBoxStreetAddress.Name = "TextBoxStreetAddress";
            this.TextBoxStreetAddress.Size = new System.Drawing.Size(167, 20);
            this.TextBoxStreetAddress.TabIndex = 7;
            // 
            // TextBoxPhoneNum
            // 
            this.TextBoxPhoneNum.Location = new System.Drawing.Point(104, 111);
            this.TextBoxPhoneNum.Name = "TextBoxPhoneNum";
            this.TextBoxPhoneNum.Size = new System.Drawing.Size(167, 20);
            this.TextBoxPhoneNum.TabIndex = 4;
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(104, 85);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(167, 20);
            this.TextBoxLastName.TabIndex = 3;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(104, 59);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(167, 20);
            this.TextBoxFirstName.TabIndex = 2;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TextBoxEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DropDownPlayerTeam);
            this.panel1.Controls.Add(this.TextBoxPlayerCountry);
            this.panel1.Controls.Add(this.TextBoxState);
            this.panel1.Controls.Add(this.TextBoxCity);
            this.panel1.Controls.Add(this.TextBoxStreetAddress);
            this.panel1.Controls.Add(this.TextBoxPhoneNum);
            this.panel1.Controls.Add(this.TextBoxLastName);
            this.panel1.Controls.Add(this.TextBoxFirstName);
            this.panel1.Controls.Add(this.modifyCreateLabel);
            this.panel1.Controls.Add(this.ButtonSaveChanges);
            this.panel1.Location = new System.Drawing.Point(762, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 510);
            this.panel1.TabIndex = 8;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(104, 139);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(167, 20);
            this.TextBoxEmail.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "E-mail";
            // 
            // TextBoxCity
            // 
            this.TextBoxCity.Location = new System.Drawing.Point(104, 337);
            this.TextBoxCity.Name = "TextBoxCity";
            this.TextBoxCity.Size = new System.Drawing.Size(167, 20);
            this.TextBoxCity.TabIndex = 8;
            // 
            // modifyCreateLabel
            // 
            this.modifyCreateLabel.AutoSize = true;
            this.modifyCreateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyCreateLabel.Location = new System.Drawing.Point(36, 11);
            this.modifyCreateLabel.Name = "modifyCreateLabel";
            this.modifyCreateLabel.Size = new System.Drawing.Size(212, 25);
            this.modifyCreateLabel.TabIndex = 1;
            this.modifyCreateLabel.Text = "Modify Coach Data";
            // 
            // deletePlayer
            // 
            this.deletePlayer.Location = new System.Drawing.Point(766, 20);
            this.deletePlayer.Name = "deletePlayer";
            this.deletePlayer.Size = new System.Drawing.Size(126, 49);
            this.deletePlayer.TabIndex = 9;
            this.deletePlayer.Text = "Delete Selected Coach";
            this.deletePlayer.UseVisualStyleBackColor = true;
            this.deletePlayer.Click += new System.EventHandler(this.deletePlayer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(908, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "Create New Coach";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PlayerDataGridView
            // 
            this.PlayerDataGridView.AllowUserToAddRows = false;
            this.PlayerDataGridView.AllowUserToDeleteRows = false;
            this.PlayerDataGridView.AutoGenerateColumns = false;
            this.PlayerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.team_id,
            this.location_id});
            this.PlayerDataGridView.DataSource = this.coachBindingSource;
            this.PlayerDataGridView.Location = new System.Drawing.Point(31, 75);
            this.PlayerDataGridView.MultiSelect = false;
            this.PlayerDataGridView.Name = "PlayerDataGridView";
            this.PlayerDataGridView.ReadOnly = true;
            this.PlayerDataGridView.Size = new System.Drawing.Size(644, 510);
            this.PlayerDataGridView.TabIndex = 11;
            this.PlayerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerDataGridView_CellClick_1);
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // team_id
            // 
            this.team_id.DataPropertyName = "team_name";
            this.team_id.HeaderText = "Team Name";
            this.team_id.Name = "team_id";
            this.team_id.ReadOnly = true;
            this.team_id.Width = 150;
            // 
            // location_id
            // 
            this.location_id.DataPropertyName = "country";
            this.location_id.HeaderText = "Country";
            this.location_id.Name = "location_id";
            this.location_id.ReadOnly = true;
            this.location_id.Width = 150;
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataMember = "coach";
            this.coachBindingSource.DataSource = this.finalAssignmentDatabaseDataSet;
            // 
            // finalAssignmentDatabaseDataSet
            // 
            this.finalAssignmentDatabaseDataSet.DataSetName = "FinalAssignmentDatabaseDataSet";
            this.finalAssignmentDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DropDownCountry
            // 
            this.DropDownCountry.FormattingEnabled = true;
            this.DropDownCountry.Location = new System.Drawing.Point(532, 49);
            this.DropDownCountry.Name = "DropDownCountry";
            this.DropDownCountry.Size = new System.Drawing.Size(195, 21);
            this.DropDownCountry.TabIndex = 12;
            this.DropDownCountry.SelectedIndexChanged += new System.EventHandler(this.DropDownCountry_SelectedIndexChanged_1);
            // 
            // LabelCountry
            // 
            this.LabelCountry.AutoSize = true;
            this.LabelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCountry.Location = new System.Drawing.Point(529, 29);
            this.LabelCountry.Name = "LabelCountry";
            this.LabelCountry.Size = new System.Drawing.Size(60, 16);
            this.LabelCountry.TabIndex = 17;
            this.LabelCountry.Text = "Country";
            // 
            // LabelTeam
            // 
            this.LabelTeam.AutoSize = true;
            this.LabelTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTeam.Location = new System.Drawing.Point(328, 29);
            this.LabelTeam.Name = "LabelTeam";
            this.LabelTeam.Size = new System.Drawing.Size(48, 16);
            this.LabelTeam.TabIndex = 16;
            this.LabelTeam.Text = "Team";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(31, 30);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(49, 16);
            this.LabelName.TabIndex = 15;
            this.LabelName.Text = "Name";
            // 
            // DropDownTeam
            // 
            this.DropDownTeam.FormattingEnabled = true;
            this.DropDownTeam.Location = new System.Drawing.Point(331, 48);
            this.DropDownTeam.Name = "DropDownTeam";
            this.DropDownTeam.Size = new System.Drawing.Size(195, 21);
            this.DropDownTeam.TabIndex = 14;
            this.DropDownTeam.SelectedIndexChanged += new System.EventHandler(this.DropDownTeam_SelectedIndexChanged_1);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(31, 49);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(294, 20);
            this.TextBoxSearch.TabIndex = 13;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // coachTableAdapter1
            // 
            this.coachTableAdapter1.ClearBeforeFill = true;
            // 
            // teamTableAdapter1
            // 
            this.teamTableAdapter1.ClearBeforeFill = true;
            // 
            // location1TableAdapter1
            // 
            this.location1TableAdapter1.ClearBeforeFill = true;
            // 
            // locationTableAdapter1
            // 
            this.locationTableAdapter1.ClearBeforeFill = true;
            // 
            // ManageCoachesControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelCountry);
            this.Controls.Add(this.LabelTeam);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.DropDownTeam);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.DropDownCountry);
            this.Controls.Add(this.PlayerDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deletePlayer);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCoachesControlPanel";
            this.Size = new System.Drawing.Size(1063, 604);
            this.Load += new System.EventHandler(this.ManageCoachesControlPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAssignmentDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DropDownPlayerTeam;
        private System.Windows.Forms.TextBox TextBoxPlayerCountry;
        private System.Windows.Forms.TextBox TextBoxState;
        private System.Windows.Forms.TextBox TextBoxStreetAddress;
        private System.Windows.Forms.TextBox TextBoxPhoneNum;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Button ButtonSaveChanges;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxCity;
        private System.Windows.Forms.Label modifyCreateLabel;
        private System.Windows.Forms.Button deletePlayer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView PlayerDataGridView;
        private System.Windows.Forms.ComboBox DropDownCountry;
        private System.Windows.Forms.Label LabelCountry;
        private System.Windows.Forms.Label LabelTeam;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.ComboBox DropDownTeam;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private FinalAssignmentDatabaseDataSetTableAdapters.coachTableAdapter coachTableAdapter1;
        private System.Windows.Forms.BindingSource coachBindingSource;
        private FinalAssignmentDatabaseDataSet finalAssignmentDatabaseDataSet;
        private FinalAssignmentDatabaseDataSetTableAdapters.teamTableAdapter teamTableAdapter1;
        private FinalAssignmentDatabaseDataSetTableAdapters.location1TableAdapter location1TableAdapter1;
        private FinalAssignmentDatabaseDataSetTableAdapters.locationTableAdapter locationTableAdapter1;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label label1;
        private FinalAssignmentDatabaseDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_id;
    }
}
