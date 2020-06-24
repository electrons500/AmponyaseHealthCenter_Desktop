using System;
using System.Windows.Forms;

namespace AmponyaseHealthCenter_Desktop
{
    public partial class FrmNHIS : Form
    {
        public FrmNHIS()
        {
            InitializeComponent();
        }

       
        readonly MainCenter mainCenter = new MainCenter();

        private void FrmNHIS_Load(object sender, EventArgs e)
        {

            try
            {
                dtpRegDate.Text = DateTime.Now.ToShortDateString();
                cboInsuredStatus.Text = "Select insured status";
                LoadIntoCombobx();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Contact the developer", "User message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           
                if (ValidateData())
                {
                    InsertData();
                }

           

        }

      
        void LoadIntoCombobx()
        {
            string sql = "Select * from InsuredStatus";
            object model = mainCenter.FillCombos(sql);
            cboInsuredStatus.DataSource = model;
            cboInsuredStatus.DisplayMember = "InsuredStatusName";
            cboInsuredStatus.ValueMember = "InsuredStatusId";
        }

        private void txtOthernames_TextChanged(object sender, EventArgs e)
        {
            txtfullname.Text = txtSurname.Text.ToUpper() + " " + txtOthernames.Text;
        }

        void InsertData()
        {
            try
            {
                string sql = "insert into NHIS(InsuranceNumber,InsuranceSchemeNumber,IssuedDate,ExpiryDate,Surname,Othernames,Fullname,BirthDate,Contact,InsuredStatusId,date)Values('" + txtInsuranceNumber.Text + "','" + txtSchemeNumber.Text + "','" + dtpIssuedDate.Text + "','" + dtpExpiryDate.Text + "','" + txtSurname.Text + "','" + txtOthernames.Text + "','" + txtfullname.Text + "','" + dtpDOB.Text + "','" + txtContact.Text + "','" + cboInsuredStatus.SelectedValue + "','" + DateTime.Now.ToShortDateString() + "')";
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Contact the developer", "User message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearControls();

            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool ValidateData()
        {
            try
            {
              
                if (txtSurname.Text == string.Empty)
                {
                    MessageBox.Show("Surname is required", "Error information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurname.Select();
                }
                else if (txtOthernames.Text == string.Empty)
                {
                    MessageBox.Show("other names is required", "Error information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOthernames.Select();
                }
                else if (txtContact.Text == string.Empty)
                {
                    MessageBox.Show("contact is required", "Error information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContact.Select();
                }
                else if (cboInsuredStatus.Text == string.Empty)
                {
                    MessageBox.Show("Insured status is required", "Error information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboInsuredStatus.Select();
                }
                else
                {
                    return true;
                }

                return false;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

        }

        private void ClearControls()
        {
            txtInsuranceNumber.Clear();
            txtSchemeNumber.Clear();
            dtpIssuedDate.ResetText();
            dtpExpiryDate.ResetText();
            txtSurname.Clear();
            txtOthernames.Clear();
            txtfullname.Clear();
            dtpDOB.ResetText();
            txtContact.Clear();
            cboInsuredStatus.Text = "Select insured status";
            dtpRegDate.ResetText();
        }
    }
}
