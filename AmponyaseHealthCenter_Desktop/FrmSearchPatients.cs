using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AmponyaseHealthCenter_Desktop
{
    public partial class FrmSearchPatients : Form
    {
        public FrmSearchPatients()
        {
            InitializeComponent();
        }

        readonly MainCenter mainCenter = new MainCenter();
   
        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

        }

        
        void DisplayData()
        {
            object model = mainCenter.LoadDGV("select NhisId As [Insurance #], p.PatientId As [Folder No],p.Surname,p.Othernames,p.Fullname As [Full Name],p.BirthDate As [Date of Birth],p.Age,p.Occupation,p.PatientAddress As [ Address],p.PatientContact As [Contact],p.Date As [Reg.Date] ,GenderName As [Sex],MaritalName As[Marital Status],RegionName As [Region],ReligionName As [Religion],InsuredStatusName As [Insured Status],u.Fullname As[Staff Name],p.patientphoto As[photo] from Patient p inner join Gender On p.GenderId = Gender.GenderId inner join MaritalStatus on p.MaritalId = MaritalStatus.MaritalId inner join Region on p.RegionId = Region.RegionId inner join Religion on p.ReligionId = Religion.ReligionId inner join InsuredStatus on p.InsuredStatusId = InsuredStatus.InsuredStatusId inner join Users u on p.Staffno = u.Staffno");
            dataGridView1.DataSource = model;
            CountData();
        }

        private void FrmSearchPatients_Load(object sender, EventArgs e)
        {
            Gender();
            MaritalStatus();
            Regions();
            Religion();
            InsuredStatus();
            cboGender.Text = "Select gender";
            cboMarital.Text = " Select marital status";
            cboRegion.Text = "Select region";
            cboReligion.Text = "Select religion";
            DisplayData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtNhisId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtFolderNumber.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtOthernames.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtFullname.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dtpDOB.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtAge.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtOccupation.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtAddress.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtContact.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                dtpRegDate.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                cboGender.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                cboMarital.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                cboRegion.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                cboReligion.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                cboInsuredStatus.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                lblStaffname.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                var data = (byte[])(dataGridView1.CurrentRow.Cells[17].Value);
                var stream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(stream);
            }
            catch (InvalidCastException)
            {
                txtNhisId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtFolderNumber.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtOthernames.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtFullname.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dtpDOB.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtAge.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtOccupation.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtAddress.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtContact.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                dtpRegDate.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                cboGender.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                cboMarital.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                cboRegion.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                cboReligion.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                cboInsuredStatus.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                lblStaffname.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                pictureBox1.Image = Properties.Resources.photo3;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CountData()
        {
            lblcounter.Text = dataGridView1.RowCount.ToString();
        }

        private void Gender()
        {
            SqlConnection con = new SqlConnection(mainCenter.GetConn());
            con.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from Gender", con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboGender.DataSource = dt;
                cboGender.DisplayMember = "GenderName";
                cboGender.ValueMember = "GenderId";
            }

            con.Close();
        }
        private void MaritalStatus()
        {
            SqlConnection con = new SqlConnection(mainCenter.GetConn());
            con.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from MaritalStatus", con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboMarital.DataSource = dt;
                cboMarital.DisplayMember = "MaritalName";
                cboMarital.ValueMember = "MaritalId";
            }

            con.Close();
        }

        private void Regions()
        {
            SqlConnection con = new SqlConnection(mainCenter.GetConn());

            con.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from Region", con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboRegion.DataSource = dt;
                cboRegion.DisplayMember = "RegionName";
                cboRegion.ValueMember = "RegionId";

            }

            con.Close();
        }

        private void Religion()
        {
            SqlConnection con = new SqlConnection(mainCenter.GetConn());

            con.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from Religion", con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboReligion.DataSource = dt;
                cboReligion.DisplayMember = "ReligionName";
                cboReligion.ValueMember = "ReligionId";

            }

            con.Close();
        }

        private void InsuredStatus()
        {
            SqlConnection con = new SqlConnection(mainCenter.GetConn());
            con.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from InsuredStatus", con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboInsuredStatus.DataSource = dt;
                cboInsuredStatus.DisplayMember = "InsuredStatusName";
                cboInsuredStatus.ValueMember = "InsuredStatusId";

            }
            con.Close();
        }

        private void SearchData()
        {
            if (cboSearchType.Text == "Folder number")
            {
                object model = mainCenter.LoadDGV("select NhisId As [Insurance #], p.PatientId As [Folder No],p.Surname,p.Othernames,p.Fullname As [Full Name],p.BirthDate As [Date of Birth],p.Age,p.Occupation,p.PatientAddress As [ Address],p.PatientContact As [Contact],p.Date As [Reg.Date] ,GenderName As [Sex],MaritalName As[Marital Status],RegionName As [Region],ReligionName As [Religion],InsuredStatusName As [Insured Status],u.Fullname As[Staff Name],p.patientphoto As[photo] from Patient p inner join Gender On p.GenderId = Gender.GenderId inner join MaritalStatus on p.MaritalId = MaritalStatus.MaritalId inner join Region on p.RegionId = Region.RegionId inner join Religion on p.ReligionId = Religion.ReligionId inner join InsuredStatus on p.InsuredStatusId = InsuredStatus.InsuredStatusId inner join Users u on p.Staffno = u.Staffno where p.PatientId Like '%" + txtSearch.Text + "%' ");
                dataGridView1.DataSource = model;
            }
            else if (cboSearchType.Text == "Name")
            {
                object model = mainCenter.LoadDGV("select NhisId As [Insurance #], p.PatientId As [Folder No],p.Surname,p.Othernames,p.Fullname As [Full Name],p.BirthDate As [Date of Birth],p.Age,p.Occupation,p.PatientAddress As [ Address],p.PatientContact As [Contact],p.Date As [Reg.Date] ,GenderName As [Sex],MaritalName As[Marital Status],RegionName As [Region],ReligionName As [Religion],InsuredStatusName As [Insured Status],u.Fullname As[Staff Name],p.patientphoto As[photo] from Patient p inner join Gender On p.GenderId = Gender.GenderId inner join MaritalStatus on p.MaritalId = MaritalStatus.MaritalId inner join Region on p.RegionId = Region.RegionId inner join Religion on p.ReligionId = Religion.ReligionId inner join InsuredStatus on p.InsuredStatusId = InsuredStatus.InsuredStatusId inner join Users u on p.Staffno = u.Staffno where p.Fullname Like '%" + txtSearch.Text + "%' ");
                dataGridView1.DataSource = model;
            }
            else
            {
                object model = mainCenter.LoadDGV("select NhisId As [Insurance #], p.PatientId As [Folder No],p.Surname,p.Othernames,p.Fullname As [Full Name],p.BirthDate As [Date of Birth],p.Age,p.Occupation,p.PatientAddress As [ Address],p.PatientContact As [Contact],p.Date As [Reg.Date] ,GenderName As [Sex],MaritalName As[Marital Status],RegionName As [Region],ReligionName As [Religion],InsuredStatusName As [Insured Status],u.Fullname As[Staff Name],p.patientphoto As[photo] from Patient p inner join Gender On p.GenderId = Gender.GenderId inner join MaritalStatus on p.MaritalId = MaritalStatus.MaritalId inner join Region on p.RegionId = Region.RegionId inner join Religion on p.ReligionId = Religion.ReligionId inner join InsuredStatus on p.InsuredStatusId = InsuredStatus.InsuredStatusId inner join Users u on p.Staffno = u.Staffno ");
                dataGridView1.DataSource = model;
            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}
