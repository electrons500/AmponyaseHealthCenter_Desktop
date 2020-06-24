using System;
using System.Windows.Forms;

namespace AmponyaseHealthCenter_Desktop
{
    public partial class FrmSearchNHIS : Form
    {
        readonly MainCenter mainCenter = new MainCenter();
        public FrmSearchNHIS()
        {
            InitializeComponent();
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (radiobxSurname.Checked)
                {
                    SearchData("SELECT * FROM  NHIS WHERE(Surname LIKE '%" + txtSearch.Text + "%')");
                }
                else if (radiobxInsuranceNumber.Checked)
                {
                    SearchData("SELECT * FROM  NHIS WHERE(InsuranceNumber LIKE '%" + txtSearch.Text + "%')");
                }
                else
                {
                    SearchData("SELECT * FROM  NHIS WHERE(Surname LIKE '% % %')");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Contact the developer", "User message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SearchData(String sql)
        {
            object model = mainCenter.LoadDGV(sql);
            dataGridView1.DataSource = model;
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

        private void FrmSearchNHIS_Load(object sender, EventArgs e)
        {
            DisplayData();
            dtpRegDate.Text = DateTime.Now.ToShortDateString();
            LoadIntoCombobx();
            
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
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
    }
}
