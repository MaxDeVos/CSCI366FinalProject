
using CSCI366FinalProject.UIElements;

namespace CSCI366FinalProject
{
    partial class HomeWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finalAssignmentDatabaseDataSet = new CSCI366FinalProject.FinalAssignmentDatabaseDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonManageTeams = new CSCI366FinalProject.UIElements.SideButton();
            this.ButtonManagePlayers = new CSCI366FinalProject.UIElements.SideButton();
            this.ButtonManageTournaments = new CSCI366FinalProject.UIElements.SideButton();
            this.ButtonManageCoaches = new CSCI366FinalProject.UIElements.SideButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAssignmentDatabaseDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.finalAssignmentDatabaseDataSet;
            this.bindingSource1.Position = 0;
            // 
            // finalAssignmentDatabaseDataSet
            // 
            this.finalAssignmentDatabaseDataSet.DataSetName = "FinalAssignmentDatabaseDataSet";
            this.finalAssignmentDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonManageTeams, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonManagePlayers, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonManageCoaches, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonManageTournaments, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1063, 36);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ButtonManageTeams
            // 
            this.ButtonManageTeams.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonManageTeams.Location = new System.Drawing.Point(3, 3);
            this.ButtonManageTeams.Name = "ButtonManageTeams";
            this.ButtonManageTeams.Size = new System.Drawing.Size(259, 30);
            this.ButtonManageTeams.TabIndex = 0;
            this.ButtonManageTeams.Text = "Manage Teams";
            this.ButtonManageTeams.UseVisualStyleBackColor = true;
            this.ButtonManageTeams.Click += new System.EventHandler(this.ButtonManageTeams_Click);
            // 
            // ButtonManagePlayers
            // 
            this.ButtonManagePlayers.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonManagePlayers.Location = new System.Drawing.Point(268, 3);
            this.ButtonManagePlayers.Name = "ButtonManagePlayers";
            this.ButtonManagePlayers.Size = new System.Drawing.Size(259, 30);
            this.ButtonManagePlayers.TabIndex = 1;
            this.ButtonManagePlayers.Text = "Manage Players";
            this.ButtonManagePlayers.UseVisualStyleBackColor = true;
            this.ButtonManagePlayers.Click += new System.EventHandler(this.ButtonManagePlayers_Click);
            // 
            // ButtonManageTournaments
            // 
            this.ButtonManageTournaments.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonManageTournaments.Location = new System.Drawing.Point(798, 3);
            this.ButtonManageTournaments.Name = "ButtonManageTournaments";
            this.ButtonManageTournaments.Size = new System.Drawing.Size(257, 30);
            this.ButtonManageTournaments.TabIndex = 3;
            this.ButtonManageTournaments.Text = "Manage Tournaments";
            this.ButtonManageTournaments.UseVisualStyleBackColor = true;
            this.ButtonManageTournaments.Click += new System.EventHandler(this.ButtonManageTournaments_Click);
            // 
            // ButtonManageCoaches
            // 
            this.ButtonManageCoaches.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonManageCoaches.Location = new System.Drawing.Point(533, 3);
            this.ButtonManageCoaches.Name = "ButtonManageCoaches";
            this.ButtonManageCoaches.Size = new System.Drawing.Size(259, 30);
            this.ButtonManageCoaches.TabIndex = 2;
            this.ButtonManageCoaches.Text = "Manage Coaches";
            this.ButtonManageCoaches.UseVisualStyleBackColor = true;
            this.ButtonManageCoaches.Click += new System.EventHandler(this.ButtonManageCoaches_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(12, 54);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1063, 604);
            this.MainPanel.TabIndex = 6;
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 670);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HomeWindow";
            this.Text = "Name of Software (TBD)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalAssignmentDatabaseDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private FinalAssignmentDatabaseDataSet finalAssignmentDatabaseDataSet;
        private SideButton ButtonManageTeams;
        private SideButton ButtonManagePlayers;
        private SideButton ButtonManageCoaches;
        private SideButton ButtonManageTournaments;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel MainPanel;
    }
}

