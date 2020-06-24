using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AmponyaseHealthCenter_Desktop
{
    public partial class FrmLogin : Form
    {
        MainCenter mainCenter = new MainCenter();
        string GetUserStaffNumber;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUsersRegistration usersRegistration = new FrmUsersRegistration();
            usersRegistration.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateControls())
                {
                    bool result = mainCenter.UserLogin(txtUsername.Text.Trim(), txtpassword.Text.Trim());
                    if (result)
                    {
                        DialogResult dialog = MessageBox.Show("You have successfully login !", "User information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialog == DialogResult.OK)
                        {
                            this.Visible = false;
                            // it returns Staff number of the user trying login.
                            GetUserStaffNumber = mainCenter.GetUserStaffNumber(txtUsername.Text.Trim(), txtpassword.Text.Trim());
                            ClearControls();
                            ShowDashboard();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Login Failed !", "User information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Contact the developer", "User message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void ShowDashboard()
        {
            MDI_Dashboard dashboard = new MDI_Dashboard();
            dashboard.lblStaffnumber.Text = GetUserStaffNumber;
            dashboard.ShowDialog();

        }

        private void ClearControls()
        {
            txtUsername.Clear();
            txtpassword.Clear();
        }

        private bool ValidateControls()
        {
            if(txtUsername.Text == String.Empty)
            {
                MessageBox.Show("Username field required", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Select();
                return false;
            }
            else if( txtpassword.Text == String.Empty)
            {
                MessageBox.Show("Password field required", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Select();
                return false;
            }
            else
            {
                return true;
            }

           
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Exit the application?", "User information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
    }
}
