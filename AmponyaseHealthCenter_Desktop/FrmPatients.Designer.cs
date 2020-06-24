namespace AmponyaseHealthCenter_Desktop
{
    partial class FrmPatients
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtStaffno = new System.Windows.Forms.TextBox();
            this.lblStaffno = new System.Windows.Forms.Label();
            this.txtNhisId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cboInsuredStatus = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboReligion = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboMarital = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOthernames = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolderNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add new patient information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpath);
            this.groupBox1.Controls.Add(this.BtnUpload);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(661, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 302);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient photo";
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(6, 200);
            this.txtpath.Name = "txtpath";
            this.txtpath.ReadOnly = true;
            this.txtpath.Size = new System.Drawing.Size(188, 24);
            this.txtpath.TabIndex = 69;
            // 
            // BtnUpload
            // 
            this.BtnUpload.ForeColor = System.Drawing.Color.Black;
            this.BtnUpload.Location = new System.Drawing.Point(45, 240);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(108, 38);
            this.BtnUpload.TabIndex = 68;
            this.BtnUpload.Text = "Upload photo";
            this.BtnUpload.UseVisualStyleBackColor = true;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AmponyaseHealthCenter_Desktop.Properties.Resources.photo3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFullname);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.cboRegion);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtStaffno);
            this.groupBox2.Controls.Add(this.lblStaffno);
            this.groupBox2.Controls.Add(this.txtNhisId);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cboInsuredStatus);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cboReligion);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cboMarital);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cboGender);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtContact);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtOccupation);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtAge);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpDOB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtOthernames);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSurname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFolderNumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(17, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 324);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient information";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(130, 119);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(216, 24);
            this.txtFullname.TabIndex = 100;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(18, 122);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 17);
            this.label18.TabIndex = 99;
            this.label18.Text = "Full Name:";
            // 
            // cboRegion
            // 
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(463, 88);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(148, 25);
            this.cboRegion.TabIndex = 98;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(371, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 17);
            this.label17.TabIndex = 97;
            this.label17.Text = "Region:";
            // 
            // txtStaffno
            // 
            this.txtStaffno.Location = new System.Drawing.Point(463, 223);
            this.txtStaffno.Name = "txtStaffno";
            this.txtStaffno.Size = new System.Drawing.Size(148, 24);
            this.txtStaffno.TabIndex = 95;
            this.txtStaffno.Visible = false;
            // 
            // lblStaffno
            // 
            this.lblStaffno.AutoSize = true;
            this.lblStaffno.ForeColor = System.Drawing.Color.Black;
            this.lblStaffno.Location = new System.Drawing.Point(371, 230);
            this.lblStaffno.Name = "lblStaffno";
            this.lblStaffno.Size = new System.Drawing.Size(74, 17);
            this.lblStaffno.TabIndex = 94;
            this.lblStaffno.Text = "Staff Name:";
            this.lblStaffno.Visible = false;
            // 
            // txtNhisId
            // 
            this.txtNhisId.Location = new System.Drawing.Point(463, 265);
            this.txtNhisId.Name = "txtNhisId";
            this.txtNhisId.ReadOnly = true;
            this.txtNhisId.Size = new System.Drawing.Size(148, 24);
            this.txtNhisId.TabIndex = 93;
            this.txtNhisId.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(371, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 17);
            this.label15.TabIndex = 92;
            this.label15.Text = "Nhis Id:";
            this.label15.Visible = false;
            // 
            // cboInsuredStatus
            // 
            this.cboInsuredStatus.FormattingEnabled = true;
            this.cboInsuredStatus.Location = new System.Drawing.Point(374, 180);
            this.cboInsuredStatus.Name = "cboInsuredStatus";
            this.cboInsuredStatus.Size = new System.Drawing.Size(237, 25);
            this.cboInsuredStatus.TabIndex = 91;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(390, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 18);
            this.label14.TabIndex = 90;
            this.label14.Text = "Is patient having NHIS Card?";
            // 
            // cboReligion
            // 
            this.cboReligion.FormattingEnabled = true;
            this.cboReligion.Location = new System.Drawing.Point(463, 118);
            this.cboReligion.Name = "cboReligion";
            this.cboReligion.Size = new System.Drawing.Size(148, 25);
            this.cboReligion.TabIndex = 89;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(371, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 88;
            this.label13.Text = "Religion:";
            // 
            // cboMarital
            // 
            this.cboMarital.FormattingEnabled = true;
            this.cboMarital.Location = new System.Drawing.Point(463, 59);
            this.cboMarital.Name = "cboMarital";
            this.cboMarital.Size = new System.Drawing.Size(148, 25);
            this.cboMarital.TabIndex = 87;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(371, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 86;
            this.label12.Text = "Marital Status:";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(463, 28);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(148, 25);
            this.cboGender.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(371, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 84;
            this.label11.Text = "Gender:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(130, 283);
            this.txtContact.Mask = "(999) 000-0000";
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(184, 24);
            this.txtContact.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(18, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 81;
            this.label9.Text = "Contact:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(130, 250);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 24);
            this.txtAddress.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 79;
            this.label8.Text = "Address:";
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(130, 220);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(216, 24);
            this.txtOccupation.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(18, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 77;
            this.label7.Text = "Occupation:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(130, 188);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(216, 24);
            this.txtAge.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "Age:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(130, 154);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(141, 24);
            this.dtpDOB.TabIndex = 74;
            this.dtpDOB.Value = new System.DateTime(2020, 4, 20, 14, 36, 5, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Date of Birth:";
            // 
            // txtOthernames
            // 
            this.txtOthernames.Location = new System.Drawing.Point(130, 90);
            this.txtOthernames.Name = "txtOthernames";
            this.txtOthernames.ReadOnly = true;
            this.txtOthernames.Size = new System.Drawing.Size(216, 24);
            this.txtOthernames.TabIndex = 72;
            this.txtOthernames.TextChanged += new System.EventHandler(this.txtOthernames_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Other names:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(130, 60);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(216, 24);
            this.txtSurname.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Surname:";
            // 
            // txtFolderNumber
            // 
            this.txtFolderNumber.Location = new System.Drawing.Point(130, 30);
            this.txtFolderNumber.Name = "txtFolderNumber";
            this.txtFolderNumber.Size = new System.Drawing.Size(216, 24);
            this.txtFolderNumber.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Folder Number:";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(302, 419);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(277, 40);
            this.BtnSave.TabIndex = 69;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 481);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Information";
            this.Load += new System.EventHandler(this.FrmPatients_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStaffno;
        public System.Windows.Forms.TextBox txtNhisId;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox cboInsuredStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboReligion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboMarital;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.MaskedTextBox txtContact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtOthernames;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolderNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtStaffno;
    }
}