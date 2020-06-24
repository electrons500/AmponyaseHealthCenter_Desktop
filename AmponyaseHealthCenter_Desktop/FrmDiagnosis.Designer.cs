namespace AmponyaseHealthCenter_Desktop
{
    partial class FrmDiagnosis
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txthistory = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtExamfindings = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtInvestigation = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtdiagnosis = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLastAttendance = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Diagnosis  and  Prescription";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 126);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 393);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.txthistory);
            this.tabPage1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "History";
            // 
            // txthistory
            // 
            this.txthistory.Location = new System.Drawing.Point(8, 7);
            this.txthistory.Multiline = true;
            this.txthistory.Name = "txthistory";
            this.txthistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txthistory.Size = new System.Drawing.Size(797, 326);
            this.txthistory.TabIndex = 1;
            this.txthistory.Text = "Type here";
            this.txthistory.Click += new System.EventHandler(this.txthistory_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.txtExamfindings);
            this.tabPage2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Exams Findings";
            // 
            // txtExamfindings
            // 
            this.txtExamfindings.Location = new System.Drawing.Point(8, 7);
            this.txtExamfindings.Multiline = true;
            this.txtExamfindings.Name = "txtExamfindings";
            this.txtExamfindings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExamfindings.Size = new System.Drawing.Size(797, 326);
            this.txtExamfindings.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage3.Controls.Add(this.txtInvestigation);
            this.tabPage3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 48);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(813, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Investigation";
            // 
            // txtInvestigation
            // 
            this.txtInvestigation.Location = new System.Drawing.Point(8, 7);
            this.txtInvestigation.Multiline = true;
            this.txtInvestigation.Name = "txtInvestigation";
            this.txtInvestigation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInvestigation.Size = new System.Drawing.Size(797, 326);
            this.txtInvestigation.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage4.Controls.Add(this.txtdiagnosis);
            this.tabPage4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 48);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(813, 341);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Diagnosis";
            // 
            // txtdiagnosis
            // 
            this.txtdiagnosis.Location = new System.Drawing.Point(8, 7);
            this.txtdiagnosis.Multiline = true;
            this.txtdiagnosis.Name = "txtdiagnosis";
            this.txtdiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdiagnosis.Size = new System.Drawing.Size(797, 326);
            this.txtdiagnosis.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage5.Controls.Add(this.txtTreatment);
            this.tabPage5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage5.Location = new System.Drawing.Point(4, 48);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(813, 341);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Treatment";
            // 
            // txtTreatment
            // 
            this.txtTreatment.Location = new System.Drawing.Point(8, 7);
            this.txtTreatment.Multiline = true;
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTreatment.Size = new System.Drawing.Size(797, 326);
            this.txtTreatment.TabIndex = 1;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(649, 67);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(140, 39);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient\'s folder number:";
            // 
            // lblPatientId
            // 
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientId.ForeColor = System.Drawing.Color.Red;
            this.lblPatientId.Location = new System.Drawing.Point(191, 80);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(48, 20);
            this.lblPatientId.TabIndex = 5;
            this.lblPatientId.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Diagnosis Date:";
            // 
            // lblLastAttendance
            // 
            this.lblLastAttendance.AutoSize = true;
            this.lblLastAttendance.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastAttendance.ForeColor = System.Drawing.Color.Red;
            this.lblLastAttendance.Location = new System.Drawing.Point(444, 80);
            this.lblLastAttendance.Name = "lblLastAttendance";
            this.lblLastAttendance.Size = new System.Drawing.Size(48, 20);
            this.lblLastAttendance.TabIndex = 7;
            this.lblLastAttendance.Text = "label4";
            // 
            // FrmDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 519);
            this.Controls.Add(this.lblLastAttendance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPatientId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDiagnosis";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients Diagnosis";
            this.Load += new System.EventHandler(this.FrmDiagnosis_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txthistory;
        private System.Windows.Forms.TextBox txtExamfindings;
        private System.Windows.Forms.TextBox txtInvestigation;
        private System.Windows.Forms.TextBox txtdiagnosis;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblLastAttendance;
    }
}