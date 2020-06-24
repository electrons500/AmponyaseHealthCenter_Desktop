namespace AmponyaseHealthCenter_Desktop
{
    partial class MDI_Dashboard
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SearchDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchNHISToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPatientsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewNHISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNHISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiagnosisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportOnDiseasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportOnPatientsAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStaffnumber = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.White;
            this.MenuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchDatabaseToolStripMenuItem,
            this.NewNHISToolStripMenuItem,
            this.EditNHISToolStripMenuItem,
            this.EditPatientsToolStripMenuItem,
            this.DiagnosisToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.LogOutToolStripMenuItem1});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1212, 78);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // SearchDatabaseToolStripMenuItem
            // 
            this.SearchDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchNHISToolStripMenuItem1,
            this.SearchPatientsToolStripMenuItem1});
            this.SearchDatabaseToolStripMenuItem.Image = global::AmponyaseHealthCenter_Desktop.Properties.Resources.search;
            this.SearchDatabaseToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SearchDatabaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SearchDatabaseToolStripMenuItem.Name = "SearchDatabaseToolStripMenuItem";
            this.SearchDatabaseToolStripMenuItem.Size = new System.Drawing.Size(64, 74);
            this.SearchDatabaseToolStripMenuItem.Text = "Search ";
            this.SearchDatabaseToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SearchNHISToolStripMenuItem1
            // 
            this.SearchNHISToolStripMenuItem1.Name = "SearchNHISToolStripMenuItem1";
            this.SearchNHISToolStripMenuItem1.Size = new System.Drawing.Size(264, 22);
            this.SearchNHISToolStripMenuItem1.Text = "Search NHIS Card Information";
            this.SearchNHISToolStripMenuItem1.Click += new System.EventHandler(this.SearchNHISToolStripMenuItem1_Click);
            // 
            // SearchPatientsToolStripMenuItem1
            // 
            this.SearchPatientsToolStripMenuItem1.Name = "SearchPatientsToolStripMenuItem1";
            this.SearchPatientsToolStripMenuItem1.Size = new System.Drawing.Size(264, 22);
            this.SearchPatientsToolStripMenuItem1.Text = "Search Patient Information";
            this.SearchPatientsToolStripMenuItem1.Click += new System.EventHandler(this.SearchPatientsToolStripMenuItem1_Click);
            // 
            // NewNHISToolStripMenuItem
            // 
            this.NewNHISToolStripMenuItem.Image = global::AmponyaseHealthCenter_Desktop.Properties.Resources.expenses;
            this.NewNHISToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NewNHISToolStripMenuItem.Name = "NewNHISToolStripMenuItem";
            this.NewNHISToolStripMenuItem.Size = new System.Drawing.Size(188, 74);
            this.NewNHISToolStripMenuItem.Text = "New Health Insurance Card";
            this.NewNHISToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewNHISToolStripMenuItem.Click += new System.EventHandler(this.NewNHISToolStripMenuItem_Click);
            // 
            // EditNHISToolStripMenuItem
            // 
            this.EditNHISToolStripMenuItem.Image = global::AmponyaseHealthCenter_Desktop.Properties.Resources.icons_debitcard;
            this.EditNHISToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditNHISToolStripMenuItem.Name = "EditNHISToolStripMenuItem";
            this.EditNHISToolStripMenuItem.Size = new System.Drawing.Size(186, 74);
            this.EditNHISToolStripMenuItem.Text = "Edit  Health Insurance Card";
            this.EditNHISToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditNHISToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditNHISToolStripMenuItem.Click += new System.EventHandler(this.EditNHISToolStripMenuItem_Click);
            // 
            // EditPatientsToolStripMenuItem
            // 
            this.EditPatientsToolStripMenuItem.Image = global::AmponyaseHealthCenter_Desktop.Properties.Resources.images;
            this.EditPatientsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditPatientsToolStripMenuItem.Name = "EditPatientsToolStripMenuItem";
            this.EditPatientsToolStripMenuItem.Size = new System.Drawing.Size(165, 74);
            this.EditPatientsToolStripMenuItem.Text = "Edit Patient information";
            this.EditPatientsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EditPatientsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditPatientsToolStripMenuItem.Click += new System.EventHandler(this.EditPatientsToolStripMenuItem_Click);
            // 
            // DiagnosisToolStripMenuItem
            // 
            this.DiagnosisToolStripMenuItem.Image = global::AmponyaseHealthCenter_Desktop.Properties.Resources.prescri;
            this.DiagnosisToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DiagnosisToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DiagnosisToolStripMenuItem.Name = "DiagnosisToolStripMenuItem";
            this.DiagnosisToolStripMenuItem.Size = new System.Drawing.Size(235, 74);
            this.DiagnosisToolStripMenuItem.Text = "Patient Diagnosis and Prescriptions";
            this.DiagnosisToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DiagnosisToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DiagnosisToolStripMenuItem.Click += new System.EventHandler(this.DiagnosisToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDataToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.SettingsToolStripMenuItem.Image = global::AmponyaseHealthCenter_Desktop.Properties.Resources.Setting_icon;
            this.SettingsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(69, 74);
            this.SettingsToolStripMenuItem.Text = "Settings";
            this.SettingsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // backupDataToolStripMenuItem
            // 
            this.backupDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDataToolStripMenuItem1,
            this.restoreDataToolStripMenuItem});
            this.backupDataToolStripMenuItem.Name = "backupDataToolStripMenuItem";
            this.backupDataToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.backupDataToolStripMenuItem.Text = "Data";
            // 
            // backupDataToolStripMenuItem1
            // 
            this.backupDataToolStripMenuItem1.Name = "backupDataToolStripMenuItem1";
            this.backupDataToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.backupDataToolStripMenuItem1.Text = "Backup Data";
            this.backupDataToolStripMenuItem1.Click += new System.EventHandler(this.backupDataToolStripMenuItem1_Click);
            // 
            // restoreDataToolStripMenuItem
            // 
            this.restoreDataToolStripMenuItem.Name = "restoreDataToolStripMenuItem";
            this.restoreDataToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.restoreDataToolStripMenuItem.Text = "Restore Data";
            this.restoreDataToolStripMenuItem.Click += new System.EventHandler(this.restoreDataToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.changePasswordToolStripMenuItem.Text = "Change password";
            // 
            // LogOutToolStripMenuItem1
            // 
            this.LogOutToolStripMenuItem1.Image = global::AmponyaseHealthCenter_Desktop.Properties.Resources.logout;
            this.LogOutToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LogOutToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LogOutToolStripMenuItem1.Name = "LogOutToolStripMenuItem1";
            this.LogOutToolStripMenuItem1.Size = new System.Drawing.Size(70, 74);
            this.LogOutToolStripMenuItem1.Text = "Log Out";
            this.LogOutToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LogOutToolStripMenuItem1.Click += new System.EventHandler(this.LogOutToolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportOnDiseasesToolStripMenuItem,
            this.reportOnPatientsAttendanceToolStripMenuItem});
            this.reportsToolStripMenuItem.Image = global::AmponyaseHealthCenter_Desktop.Properties.Resources.rpt4;
            this.reportsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reportsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(67, 74);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // reportOnDiseasesToolStripMenuItem
            // 
            this.reportOnDiseasesToolStripMenuItem.Name = "reportOnDiseasesToolStripMenuItem";
            this.reportOnDiseasesToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.reportOnDiseasesToolStripMenuItem.Text = "Report on Diseases";
            this.reportOnDiseasesToolStripMenuItem.Click += new System.EventHandler(this.reportOnDiseasesToolStripMenuItem_Click);
            // 
            // reportOnPatientsAttendanceToolStripMenuItem
            // 
            this.reportOnPatientsAttendanceToolStripMenuItem.Name = "reportOnPatientsAttendanceToolStripMenuItem";
            this.reportOnPatientsAttendanceToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.reportOnPatientsAttendanceToolStripMenuItem.Text = "Report on patients attendance";
            this.reportOnPatientsAttendanceToolStripMenuItem.Click += new System.EventHandler(this.reportOnPatientsAttendanceToolStripMenuItem_Click);
            // 
            // lblStaffnumber
            // 
            this.lblStaffnumber.AutoSize = true;
            this.lblStaffnumber.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffnumber.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStaffnumber.Location = new System.Drawing.Point(12, 577);
            this.lblStaffnumber.Name = "lblStaffnumber";
            this.lblStaffnumber.Size = new System.Drawing.Size(87, 18);
            this.lblStaffnumber.TabIndex = 3;
            this.lblStaffnumber.Text = "Staff number";
            this.lblStaffnumber.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1212, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MDI_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1212, 627);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblStaffnumber);
            this.Controls.Add(this.MenuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDI_Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Dashboard_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem NewNHISToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditNHISToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditPatientsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DiagnosisToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SearchDatabaseToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SearchNHISToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem SearchPatientsToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.Label lblStaffnumber;
        private System.Windows.Forms.ToolStripMenuItem backupDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restoreDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportOnDiseasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportOnPatientsAttendanceToolStripMenuItem;
    }
}



