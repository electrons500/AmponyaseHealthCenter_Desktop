using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace AmponyaseHealthCenter_Desktop
{
    public partial class RestoreScreen : Form
    {
        int count, i;
        MainCenter mainCenter = new MainCenter();
        public RestoreScreen()
        {
            InitializeComponent();
        }

        private void RestoreScreen_Load(object sender, EventArgs e)
        {
           
            label1.Text = " ";
            
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
                        label1.Text = "Please Restore process is about to begin.Don't open any other program till completion";
                        break;

                    case 10:
                        label1.Text = "Checking backup file";
                        label2.Show();
                        break;
                    case 15:
                        CheckExistingFile();
                        break;
                    case 20:
                        label1.Text = "System is about to restore Please no disturbance !";
                        break;
                    case 30:
                        RestoreData();
                        break;

                    case 90:
                        MessageBox.Show("System has sucessfully restore database !", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        break;

                }
            }
            catch (Exception ex)
            {

                ErrorMessage(ex.Message);
            }


        }
        

        private void CheckExistingFile()
        {
            
            string filePath = @"C:\AmponyaseHCMS\backup\AHCDB.bak";
            if (File.Exists(filePath))
            {

               label1.Text = "Backup file exist";

            }
            else
            {
                timer1.Enabled = false;
                timer1.Stop();
                ErrorMessage(@"Backup file doesnot exist.Please ensure that a copy of the backup file is in C:\AmponyaseHCMS\backup");

            }

        }

        private void RestoreData()
        {
            try
            {
                string filePath = @"C:\AmponyaseHCMS\backup\AHCDB.bak";
                string sql = @"RESTORE DATABASE [AHCDB] FROM  DISK = N'" + filePath + "' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 5";
                SqlConnection con = new SqlConnection(mainCenter.GetConn());
                // bool useMaster = UseMasterDB("Use master");

                con.Open();

                using (SqlCommand cmd = new SqlCommand("ALTER DATABASE [AHCDB] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE", con))
                {
                    cmd.ExecuteNonQuery();
                }
                using (SqlCommand cmd = new SqlCommand("Use master", con))
                {
                    cmd.ExecuteNonQuery();
                }
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        label1.Text = "System is restoring database !";
                    }
                }

                con.Close();

            }
            catch (Exception ex)
            {

                ErrorMessage(ex.Message);
            }
        }
        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, "System Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Contact the developer", "User message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }



    }
}
