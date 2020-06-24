using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace AmponyaseHealthCenter_Desktop
{

    public partial class BackupScreen : Form
    {
        int count,i;

        MainCenter mainCenter = new MainCenter();
        public BackupScreen()
        {
            InitializeComponent();
        }

        private void BackupScreen_Load(object sender, EventArgs e)
        {
            label2.Hide();
            label1.Text = " ";
            progressBar1.Hide();
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Increment(1);
                count = Convert.ToInt32(progressBar1.Value);
                label2.Text = progressBar1.Value + "%";

                switch (count)
                {
                    case 1:
                        label1.Text = "Please backup process is about to begin.Don't open any other program till completion";
                        break;
                    case 5:
                        label1.Text = "Please backup process is about to begin.Don't open any other program till completion";
                        break;
                    case 10:
                        label1.Text = "System is about to backup data. ";
                        label2.Show();
                        break;
                    case 15:
                        label1.Text = "System data is backing up.";
                        break;
                    case 30:
                        CheckExistingBackup();
                        break;

                    case 90:
                        label1.Text = " ";
                        pictureBox2.Hide();
                        MessageBox.Show(@"System has sucessfully backup database !.Copy backup file at the directory(C:\AmponyaseHCMS\backup) into a pen drive or a storage drive", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;

                }

            }
            catch (Exception ex)
            {

                ErrorMessage(ex.Message);
            }
           
        }

        private void CheckExistingBackup()
        {
            string backupPath = @"C:\AmponyaseHCMS\backup";
            string filePath = @"C:\AmponyaseHCMS\backup\AHCDB.bak";

            if (!Directory.Exists(backupPath))
            {
                Directory.CreateDirectory(backupPath);
                //create backup file
                BackupData(filePath);
            }
            else
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    //create backup file
                    BackupData(filePath);
                }
                else
                {
                    //create backup file
                    BackupData(filePath);
                }
            }
        }

        private void BackupData(string filepath)
        {
            try
            {
                string sql = "BACKUP DATABASE [AHCDB] TO  DISK = N'" + filepath + "' WITH NOFORMAT, NOINIT,  NAME = N'AHCDB-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, NO_COMPRESSION,  STATS = 10";
                SqlConnection con = new SqlConnection(mainCenter.GetConn());
                bool useMaster = UseMasterDB("Use master");
                if (!useMaster)
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        i = cmd.ExecuteNonQuery();
                    }
                    if (i > 0)
                    {
                        label1.Text = "Data backup will finish soon.";
                    }
                    con.Close();

                }
                else
                {
                    MessageBox.Show("master DB activation failed.Contact developer");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                ErrorMessage(ex.Message);
            }
        }

        private bool UseMasterDB( string sql)
        {
            SqlConnection con = new SqlConnection(mainCenter.GetConn());
            con.Close();
            if (con.State == ConnectionState.Closed)
            {
               
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    i = cmd.ExecuteNonQuery();
                    con.Close();
                   
                }
               
            }

            if (i > 0)
            {

                return true;

            }
            else
            {

                return false;
            }
        }

        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }


    }
}
