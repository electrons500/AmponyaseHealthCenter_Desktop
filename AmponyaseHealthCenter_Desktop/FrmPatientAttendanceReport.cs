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
    public partial class FrmPatientAttendanceReport : Form
    {
        MainCenter mainCenter = new MainCenter();

        int records = 0;
        public FrmPatientAttendanceReport()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mainCenter.GetConn());
            if (txtFolderNumber.Text == string.Empty)
            {
                txtFolderNumber.Text = "%";

                string sql = "select a.PatientId,p.Fullname,n.InsuranceNumber,a.CurrentDate from AllPatientsAttendance a inner join Patient p on a.patientId = p.PatientId inner join NHIS n on p.NhisId = n.NhisId where a.patientId LIKE '"+ txtFolderNumber.Text +"' and a.CurrentDate between '" + DtpStart.Text +"' and '"+ DtpEnd.Text +"'";
              
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        AllPatientsAttendanceDataSet Ds = new AllPatientsAttendanceDataSet();
                        da.Fill(Ds, "AllPatientsAttendance");
                        dataGridView1.DataSource = Ds.Tables[0];
                        records = dataGridView1.RowCount;

                    }
                }

                con.Close();

                MessageBox.Show(records + " records found", "User information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                string sql = "select a.PatientId,p.Fullname,n.InsuranceNumber,a.CurrentDate from AllPatientsAttendance a inner join Patient p on a.patientId = p.PatientId inner join NHIS n on p.NhisId = n.NhisId where a.patientId LIKE '" + txtFolderNumber.Text + "' and a.CurrentDate between '" + DtpStart.Text + "' and '" + DtpEnd.Text + "'";

                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        AllPatientsAttendanceDataSet Ds = new AllPatientsAttendanceDataSet();
                        da.Fill(Ds, "AllPatientsAttendance");
                        dataGridView1.DataSource = Ds.Tables[0];
                        records = dataGridView1.RowCount;

                    }
                }


                con.Close();

                MessageBox.Show(records + " records found", "User information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            frmPatientAttendanceReporting reporting = new frmPatientAttendanceReporting();
            reporting.txtfoldernumber.Text = txtFolderNumber.Text;
            reporting.DtpStart.Text = DtpStart.Text;
            reporting.DtpEnd.Text = DtpEnd.Text;

            reporting.ShowDialog();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
