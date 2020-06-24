using System;
using System.Windows.Forms;

namespace AmponyaseHealthCenter_Desktop
{
    public partial class FrmManageNHIS : Form
    {
        public FrmManageNHIS()
        {
            InitializeComponent();
        }

        readonly MainCenter mainCenter = new MainCenter();
        private void FrmManageNHIS_Load(object sender, EventArgs e)
        {
            DisplayData();
            dtpRegDate.Text = DateTime.Now.ToShortDateString();
            LoadIntoCombobx();
            lblNhis.Visible = false;

           
        }
        void DisplayData()
        {
            object model = mainCenter.LoadDGV("select NhisId As [S/No], InsuranceNumber As [Insurance No.],InsuranceSchemeNumber  As [Scheme No.],IssuedDate As [Issued Date],ExpiryDate As [Expiry Date],Surname,Othernames  As [Other Names],Fullname  As [Full Name],BirthDate  As [Date Of Birth],Contact,InsuredStatusName  As [Insured status],date  As [Reg. date] from NHIS inner join InsuredStatus On NHIS.InsuredStatusId = InsuredStatus.InsuredStatusId");
            dataGridView1.DataSource = model;
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

        void DeleteData()
        {
            try
            {
                if (ValidateData())
                {
                    string sql = "Delete from NHIS where NhisId='" + lblNhis.Text +"'";

                    bool result = mainCenter.DeleteQuery(sql);
                    if (result)
                    {
                        MessageBox.Show("Data successfully deleted!", "Success Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("Data failed to  delete!", "Failed Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Contact the developer", "User message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNhis.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtInsuranceNumber.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSchemeNumber.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtpIssuedDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dtpExpiryDate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSurname.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtOthernames.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtfullname.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dtpDOB.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtContact.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cboInsuredStatus.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            dtpRegDate.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        void UpdateData()
        {
            try
            {
                if (ValidateData())
                {
                    string sql = "Update NHIS SET InsuranceNumber ='" + txtInsuranceNumber.Text + "',InsuranceSchemeNumber ='" + txtSchemeNumber.Text + "',IssuedDate ='" + dtpIssuedDate.Text + "',ExpiryDate ='" + dtpExpiryDate.Text + "',Surname ='" + txtSurname.Text + "',Othernames = '" + txtOthernames.Text + "',Fullname= '" + txtfullname.Text + "',BirthDate= '" + dtpDOB.Text + "',Contact= '" + txtContact.Text + "',InsuredStatusId ='" + cboInsuredStatus.SelectedValue + "',date = '" + dtpRegDate.Text + "' where NhisId='" + lblNhis.Text + "'";
                    bool result = mainCenter.UpdateQuery(sql);
                    if (result)
                    {
                        MessageBox.Show("Data successfully updated!", "Success Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("Data failed to be updated!", "Failed Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Contact the developer", "User message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Are you sure you want to update this information?", "Caution message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialog == DialogResult.Yes)
            {
                UpdateData();
            }


           
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
           dialog = MessageBox.Show("Are you sure you want to delete this information?", "Caution message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if(dialog == DialogResult.Yes)
            {
                DeleteData();
            }
        }

        private bool ValidateData()
        {
            try
            {
                if (txtInsuranceNumber.Text == string.Empty)
                {
                    MessageBox.Show("Insurance Number is required", "Error information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInsuranceNumber.Select();
                }
                else if (txtSchemeNumber.Text == string.Empty)
                {
                    MessageBox.Show("Insurance scheme Number is required", "Error information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSchemeNumber.Select();
                }
                else if (txtSurname.Text == string.Empty)
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmPatients frmPatients = new FrmPatients();
            frmPatients.txtSurname.Text = this.txtSurname.Text;
            frmPatients.txtOthernames.Text = this.txtOthernames.Text;
            frmPatients.txtFullname.Text = this.txtfullname.Text;
            frmPatients.dtpDOB.Text = this.dtpDOB.Text;
            frmPatients.txtContact.Text = this.txtContact.Text;
            frmPatients.cboInsuredStatus.Text = this.cboInsuredStatus.Text;
            frmPatients.txtNhisId.Text = this.lblNhis.Text;

            frmPatients.ShowDialog();
           
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (radiobxSurname.Checked)
            {
                SearchData("SELECT * FROM  NHIS WHERE(Surname LIKE '%" + txtSearch.Text + "%')");
            }else if (radiobxInsuranceNumber.Checked)
            {
                SearchData("SELECT * FROM  NHIS WHERE(InsuranceNumber LIKE '%" + txtSearch.Text + "%')");
            }
            else
            {
                SearchData("SELECT * FROM  NHIS WHERE(Surname LIKE '% % %')");
            }

        }

        private void SearchData(String sql)
        {
            object model = mainCenter.LoadDGV(sql);
            dataGridView1.DataSource = model;
        }
    }
}
