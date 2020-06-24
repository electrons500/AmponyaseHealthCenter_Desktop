namespace AmponyaseHealthCenter_Desktop
{
    partial class FrmGetFolderNumber
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
            this.txtfolderNumber = new System.Windows.Forms.TextBox();
            this.BtnProceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter folder number and  click proceed";
            // 
            // txtfolderNumber
            // 
            this.txtfolderNumber.Location = new System.Drawing.Point(68, 82);
            this.txtfolderNumber.Name = "txtfolderNumber";
            this.txtfolderNumber.Size = new System.Drawing.Size(319, 28);
            this.txtfolderNumber.TabIndex = 1;
            this.txtfolderNumber.Click += new System.EventHandler(this.txtfolderNumber_Click);
            // 
            // BtnProceed
            // 
            this.BtnProceed.Location = new System.Drawing.Point(125, 132);
            this.BtnProceed.Name = "BtnProceed";
            this.BtnProceed.Size = new System.Drawing.Size(198, 44);
            this.BtnProceed.TabIndex = 2;
            this.BtnProceed.Text = "Proceed";
            this.BtnProceed.UseVisualStyleBackColor = true;
            this.BtnProceed.Click += new System.EventHandler(this.BtnProceed_Click);
            // 
            // FrmGetFolderNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 207);
            this.Controls.Add(this.BtnProceed);
            this.Controls.Add(this.txtfolderNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGetFolderNumber";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmGetFolderNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfolderNumber;
        private System.Windows.Forms.Button BtnProceed;
    }
}