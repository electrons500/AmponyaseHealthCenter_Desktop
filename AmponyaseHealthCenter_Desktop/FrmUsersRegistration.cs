using System;
using System.Windows.Forms;

namespace AmponyaseHealthCenter_Desktop
{
    public partial class FrmUsersRegistration : Form
    {

        MainCenter mainCenter = new MainCenter();

        public FrmUsersRegistration()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
               if(txtpassword.Text == Retypetxtpassword.Text)
                {
                    string sql = "Insert into Users(Staffno,surname,Othername,Fullname,Birthdate,Address,telephone,username,password,RoleId) Values('" + txtStaffNumber.Text + "','" + txtSurname.Text.ToUpper() + "','" + txtOthernames.Text + "','" + txtFullname.Text + "','" + dtpDOB.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "','" + txtUsername.Text.Trim() + "','" + DataCipher.Encrypt(txtpassword.Text.Trim()) + "','" + cboRole.SelectedValue + "')";
                    bool result = mainCenter.InsertQuery(sql);
                    if (result)
                    {
                        MessageBox.Show("Data successfully saved!", "Success Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();
                    }
                    else
                    {
                        MessageBox.Show("Data failed to be saved!", "Failed Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Passwords donot match!", "Failed Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

               throw;
            }
        }

        private void ClearControls()
        {
            txtStaffNumber.Clear();
            txtSurname.Clear();
            txtOthernames.Clear();
            txtFullname.Clear();
            dtpDOB.Text = DateTime.Now.ToShortDateString();
            txtAddress.Clear();
            txtContact.Clear();
            txtUsername.Clear();
            txtpassword.Clear();
            cboRole.Text = " ";

        }

        private void FillRoleCombobx()
        {
            string sql = "select * from Roles";
            object dt =  mainCenter.FillCombos(sql);
            cboRole.DataSource = dt;
            cboRole.DisplayMember = "RoleName";
            cboRole.ValueMember = "RoleId";

        }

        private void FrmUsersRegistration_Load(object sender, EventArgs e)
        {
            FillRoleCombobx();
            cboRole.Text = "Select a role";
            dtpDOB.Text = DateTime.Now.ToShortDateString();
        }

        private void txtOthernames_TextChanged(object sender, EventArgs e)
        {
            txtFullname.Text = txtSurname.Text.ToUpper() + " " + txtOthernames.Text;
        }
    }
}
