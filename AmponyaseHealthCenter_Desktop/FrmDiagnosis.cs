using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace AmponyaseHealthCenter_Desktop
{
    public partial class FrmDiagnosis : Form
    {
        readonly MainCenter mainCenter = new MainCenter();
      
        public FrmDiagnosis()
        {
            InitializeComponent();
        }


        private void txthistory_Click(object sender, EventArgs e)
        {
            txthistory.Clear();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                InputBoxShow();

               
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Contact the developer", "User message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void FrmDiagnosis_Load(object sender, EventArgs e)
        {
            CheckPatientLastAttendance();
        }

        private void PatientAttendance()
        {
            try
            {
                string sql = "Update PatientAttendance set LastDate = '" + DateTime.Now.ToShortDateString() + "',NumberOfTimes = NumberOfTimes + 1 where PatientId= '"+ lblPatientId.Text +"'";
                bool result = mainCenter.UpdateQuery(sql);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "System Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Contact the developer", "User message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Clear()
        {
            txthistory.Clear();
            txtExamfindings.Clear();
            txtInvestigation.Clear();
            txtdiagnosis.Clear();
            txtTreatment.Clear();

        }

        private void InputBoxShow()
        {
            // InputBox function is only found in VB so to call the function we need to add 
            // a class library file by adding it in references and after that apply this code

            string message, title, defaultvalue, InputSuspectedDisease;
            message = "What disease to you suspect or think the patient have?";
            title = "Enter suspected disease";
            defaultvalue = " 1";
            InputSuspectedDisease = Interaction.InputBox(message, title, defaultvalue, 100, 100);

            //save code

            string sql = "insert into PatientDiagnosis(History,ExamFindings,Investigation,Diagnosis,Treatment,Date,PatientId,DiseaseTreated)Values('" + txthistory.Text + "','" + txtExamfindings.Text + "','" + txtInvestigation.Text + "','" + txtdiagnosis.Text + "','" + txtTreatment.Text + "','" + DateTime.Now.ToShortDateString() + "','" + lblPatientId.Text + "','" + InputSuspectedDisease + "')";
            bool result = mainCenter.InsertQuery(sql);
            if (result)
            {
                MessageBox.Show("Data successfully saved!", "Success Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PatientAttendance();
                Clear();
            }
            else
            {
                MessageBox.Show("Data failed to be saved!", "Failed Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


        private void CheckPatientLastAttendance()
        {
            SqlConnection con = new SqlConnection(mainCenter.GetConn());
            SqlDataReader dr;
            string sql = "select LastDate from PatientAttendance where PatientId= '"+ lblPatientId.Text + "'";
            con.Open();
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblLastAttendance.Text = dr["LastDate"].ToString();
                }
            }

            dr.Close();
            con.Close();
        }

    }
}
