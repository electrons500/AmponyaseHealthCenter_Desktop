using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AmponyaseHealthCenter_Desktop
{
    public partial class FrmManagePatients : Form
    {
        public FrmManagePatients()
        {
            InitializeComponent();
        }

        readonly MainCenter mainCenter = new MainCenter();
        int i;
        void DisplayData()
        {
            object model = mainCenter.LoadDGV("select NhisId As [Insurance #], p.PatientId As [Folder No],p.Surname,p.Othernames,p.Fullname As [Full Name],p.BirthDate As [Date of Birth],p.Age,p.Occupation,p.PatientAddress As [ Address],p.PatientContact As [Contact],p.Date As [Reg.Date] ,GenderName As [Sex],MaritalName As[Marital Status],RegionName As [Region],ReligionName As [Religion],InsuredStatusName As [Insured Status],u.Fullname As[Staff Name],p.patientphoto As[photo] from Patient p inner join Gender On p.GenderId = Gender.GenderId inner join MaritalStatus on p.MaritalId = MaritalStatus.MaritalId inner join Region on p.RegionId = Region.RegionId inner join Religion on p.ReligionId = Religion.ReligionId inner join InsuredStatus on p.InsuredStatusId = InsuredStatus.InsuredStatusId inner join Users u on p.Staffno = u.Staffno");
            dataGridView1.DataSource = model;
            CountData();
        }

        private void FrmManagePatients_Load(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Contact the developer", "User message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Contact the developer", "User message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void CountData()
        {
            lblcounter.Text = dataGridView1.RowCount.ToString();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                CheckFileExists = true,
                Multiselect = false,
                Filter = "Jpeg files(.jpg)|*jpg|PNG files(.png)|.*png",
                FileName = "Select patient photo"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                txtpath.Text = ofd.FileName;
                MessageBox.Show("Image successfully uploaded", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if(txtpath.Text == string.Empty)
            {
                UpdateWithoutImage();
               
            }
            else
            {
                
                UpdateWithImage();
               
            }
        }

        private void UpdateWithImage()
        {
            string sql = "Update Patient SET Surname ='" + txtSurname.Text + "',Othernames ='" + txtOthernames.Text + "',Fullname ='" + txtFullname.Text + "',BirthDate ='" + dtpDOB.Text + "',Age ='" + txtAge.Text + "',Occupation ='" + txtOccupation.Text + "',PatientAddress ='" + txtAddress.Text + "',PatientContact ='" + txtContact.Text + "',Date ='" + dtpRegDate.Text + "',GenderId = '" + cboGender.SelectedValue + "',MaritalId ='" + cboMarital.SelectedValue + "',RegionId ='" + cboRegion.SelectedValue + "',ReligionId ='" + cboReligion.SelectedValue + "',InsuredStatusId ='" + cboInsuredStatus.SelectedValue + "',patientphoto =@photo where PatientId ='" + txtFolderNumber.Text + "'";
            SqlConnection con = new SqlConnection(mainCenter.GetConn());
            
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("@photo", SqlDbType.VarBinary)).Value = File.ReadAllBytes(txtpath.Text);
                    i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Data successfully updated!", "Success Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("Data failed to be updated!", "Failed Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                con.Close();
            }

        }

        private void UpdateWithoutImage()
        {
            string sql = "Update Patient SET Surname ='" + txtSurname.Text + "',Othernames ='" + txtOthernames.Text + "',Fullname ='" + txtFullname.Text + "',BirthDate ='" + dtpDOB.Text + "',Age ='" + txtAge.Text + "',Occupation ='" + txtOccupation.Text + "',PatientAddress ='" + txtAddress.Text + "',PatientContact ='" + txtContact.Text + "',Date ='" + dtpRegDate.Text + "',GenderId = '" + cboGender.SelectedValue + "',MaritalId ='" + cboMarital.SelectedValue + "',RegionId ='" + cboRegion.SelectedValue + "',ReligionId ='" + cboReligion.SelectedValue + "',InsuredStatusId ='" + cboInsuredStatus.SelectedValue + "' where PatientId ='" + txtFolderNumber.Text + "' ";
            SqlConnection con = new SqlConnection(mainCenter.GetConn());

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                   
                    i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Data successfully updated!", "Success Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("Data failed to be updated!", "Failed Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                con.Close();
            }

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

        private void DeleteData()
        {
            string sql = "Delete from Patient where PatientId= '" + txtFolderNumber.Text +"'";

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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Are you sure you want to delete this information?", "Caution message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialog == DialogResult.Yes)
            {
                DeleteData();
            }
        }

        private void SearchData()
        {
           if(cboSearchType.Text =="Folder number")
            {
                object model = mainCenter.LoadDGV("select NhisId As [Insurance #], p.PatientId As [Folder No],p.Surname,p.Othernames,p.Fullname As [Full Name],p.BirthDate As [Date of Birth],p.Age,p.Occupation,p.PatientAddress As [ Address],p.PatientContact As [Contact],p.Date As [Reg.Date] ,GenderName As [Sex],MaritalName As[Marital Status],RegionName As [Region],ReligionName As [Religion],InsuredStatusName As [Insured Status],u.Fullname As[Staff Name],p.patientphoto As[photo] from Patient p inner join Gender On p.GenderId = Gender.GenderId inner join MaritalStatus on p.MaritalId = MaritalStatus.MaritalId inner join Region on p.RegionId = Region.RegionId inner join Religion on p.ReligionId = Religion.ReligionId inner join InsuredStatus on p.InsuredStatusId = InsuredStatus.InsuredStatusId inner join Users u on p.Staffno = u.Staffno where p.PatientId Like '%" + txtSearch.Text + "%' ");
                dataGridView1.DataSource = model;
            }else if(cboSearchType.Text == "Name")
            {
                object model = mainCenter.LoadDGV("select NhisId As [Insurance #], p.PatientId As [Folder No],p.Surname,p.Othernames,p.Fullname As [Full Name],p.BirthDate As [Date of Birth],p.Age,p.Occupation,p.PatientAddress As [ Address],p.PatientContact As [Contact],p.Date As [Reg.Date] ,GenderName As [Sex],MaritalName As[Marital Status],RegionName As [Region],ReligionName As [Religion],InsuredStatusName As [Insured Status],u.Fullname As[Staff Name],p.patientphoto As[photo] from Patient p inner join Gender On p.GenderId = Gender.GenderId inner join MaritalStatus on p.MaritalId = MaritalStatus.MaritalId inner join Region on p.RegionId = Region.RegionId inner join Religion on p.ReligionId = Religion.ReligionId inner join InsuredStatus on p.InsuredStatusId = InsuredStatus.InsuredStatusId inner join Users u on p.Staffno = u.Staffno where p.Fullname Like '%" + txtSearch.Text + "%' ");
                dataGridView1.DataSource = model;
            }else
            {
                object model = mainCenter.LoadDGV("select NhisId As [Insurance #], p.PatientId As [Folder No],p.Surname,p.Othernames,p.Fullname As [Full Name],p.BirthDate As [Date of Birth],p.Age,p.Occupation,p.PatientAddress As [ Address],p.PatientContact As [Contact],p.Date As [Reg.Date] ,GenderName As [Sex],MaritalName As[Marital Status],RegionName As [Region],ReligionName As [Religion],InsuredStatusName As [Insured Status],u.Fullname As[Staff Name],p.patientphoto As[photo] from Patient p inner join Gender On p.GenderId = Gender.GenderId inner join MaritalStatus on p.MaritalId = MaritalStatus.MaritalId inner join Region on p.RegionId = Region.RegionId inner join Religion on p.ReligionId = Religion.ReligionId inner join InsuredStatus on p.InsuredStatusId = InsuredStatus.InsuredStatusId inner join Users u on p.Staffno = u.Staffno ");
                dataGridView1.DataSource = model;
            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
