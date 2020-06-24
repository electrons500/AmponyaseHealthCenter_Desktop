using System;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;

namespace AmponyaseHealthCenter_Desktop
{
    public partial class FrmPatients : Form
    {
        DBConnection dB = new DBConnection();
       
        public FrmPatients()
        {
            InitializeComponent();
        }

        int i;

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                CheckFileExists = true,
                Multiselect = false,
                Filter ="Jpeg files(.jpg)|*jpg|PNG files(.png)|.*png",
                FileName ="Select patient photo"              
            };

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                txtpath.Text = ofd.FileName;
                MessageBox.Show("Image successfully uploaded", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
           
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
           dialog = MessageBox.Show("Caution Folder number cannot be changed after it has been saved! Do you want to proceed?", "Warning information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if(dialog == DialogResult.Yes)
            {
                if (txtpath.Text != string.Empty)
                {
                    SaveWithImages();
                }
                else
                {
                    SaveWithoutImage();
                }
            }
           
        }

        private void Gender()
        {
            SqlConnection con = new SqlConnection(dB.GetConn());
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
            SqlConnection con = new SqlConnection(dB.GetConn());
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
            SqlConnection con = new SqlConnection(dB.GetConn());

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
            SqlConnection con = new SqlConnection(dB.GetConn());

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
            SqlConnection con = new SqlConnection(dB.GetConn());
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

        private void FrmPatients_Load(object sender, EventArgs e)
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
            cboInsuredStatus.Text = "Select insured status";

            txtStaffno.Text = StaffNumberRetrival.GetStaffNumber().ToString();

        }

        private void txtOthernames_TextChanged(object sender, EventArgs e)
        {
            txtFullname.Text = txtSurname.Text + " " + txtOthernames.Text;
        }
        private void SaveWithImages()
        {
            try
            {
                SqlConnection con = new SqlConnection(dB.GetConn());
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    string sql = "insert into Patient(PatientId,Surname,Othernames,Fullname,BirthDate,Age,Occupation,PatientAddress,PatientContact,Date,GenderId,MaritalId,RegionId,ReligionId,InsuredStatusId,NhisId,Staffno,patientphoto)Values('" + txtFolderNumber.Text + "','" + txtSurname.Text + "','" + txtOthernames.Text + "','" + txtFullname.Text + "','" + dtpDOB.Text + "','" + txtAge.Text + "','" + txtOccupation.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "','" + DateTime.Now.ToShortDateString() + "','" + cboGender.SelectedValue + "','" + cboMarital.SelectedValue + "','" + cboRegion.SelectedValue + "','" + cboReligion.SelectedValue + "','" + cboInsuredStatus.SelectedValue + "','" + txtNhisId.Text + "','" + txtStaffno.Text + "',@patientphoto)";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@patientphoto", SqlDbType.VarBinary)).Value = File.ReadAllBytes(txtpath.Text);
                        i = cmd.ExecuteNonQuery();
                    }
                    if (i > 0)
                    {
                        MessageBox.Show("Data successfully saved!", "Success Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Data failed to be saved!", "Failed Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    con.Close();

                    PatientAttendance();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Contact the developer", "User message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SaveWithoutImage()
        {
            try
            {
                SqlConnection con = new SqlConnection(dB.GetConn());
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    string sql = "insert into Patient(PatientId,Surname,Othernames,Fullname,BirthDate,Age,Occupation,PatientAddress,PatientContact,Date,GenderId,MaritalId,RegionId,ReligionId,InsuredStatusId,NhisId,Staffno)Values('" + txtFolderNumber.Text + "','" + txtSurname.Text + "','" + txtOthernames.Text + "','" + txtFullname.Text + "','" + dtpDOB.Text + "','" + txtAge.Text + "','" + txtOccupation.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "','" + DateTime.Now.ToShortDateString() + "','" + cboGender.SelectedValue + "','" + cboMarital.SelectedValue + "','" + cboRegion.SelectedValue + "','" + cboReligion.SelectedValue + "','" + cboInsuredStatus.SelectedValue + "','" + txtNhisId.Text + "','" + txtStaffno.Text + "')";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                       
                        i = cmd.ExecuteNonQuery();
                    }
                    if (i > 0)
                    {
                        MessageBox.Show("Data successfully saved!", "Success Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Data failed to be saved!", "Failed Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    con.Close();

                    PatientAttendance();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Contact the developer", "User message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void PatientAttendance()
        {
            try
            {
                SqlConnection con = new SqlConnection(dB.GetConn());
               
                    con.Open();
                    string sql = "insert into PatientAttendance(PatientId,FirstDate,NumberOfTimes)Values('" + txtFolderNumber.Text +"','" + DateTime.Now.ToShortDateString() +"','0')";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {

                        i = cmd.ExecuteNonQuery();
                    }
                    
                    con.Close();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Contact the developer", "User message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }



    }
}
