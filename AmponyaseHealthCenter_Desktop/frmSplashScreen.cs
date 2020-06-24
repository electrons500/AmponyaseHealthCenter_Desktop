using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmponyaseHealthCenter_Desktop
{
    public partial class frmSplashScreen : Form
    {
        int num = 0;
        public frmSplashScreen()
        {
            InitializeComponent();
        }


        DBConnection Connection = new DBConnection();

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            progressBar1.Hide();
        }
       

        private void TestConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Connection.GetConn());
                FrmLogin frmLogin = new FrmLogin();
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    this.Hide();

                    frmLogin.ShowDialog();

                }
                conn.Close();
            }
            catch (Exception ex)
            {

                DialogResult dialog = MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialog == DialogResult.OK)
                {
                    Application.Exit();
                }

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            num = progressBar1.Value;

            if (num == 70)
            {
                TestConnection();
            }
        }
    }
}
