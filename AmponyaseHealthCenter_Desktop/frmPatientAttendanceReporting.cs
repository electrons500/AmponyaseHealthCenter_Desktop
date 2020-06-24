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
    public partial class frmPatientAttendanceReporting : Form
    {
        MainCenter mainCenter = new MainCenter();
        public frmPatientAttendanceReporting()
        {
            InitializeComponent();
        }

        private void frmPatientAttendanceReporting_Load(object sender, EventArgs e)
        {
            LoadDataToDataset();
        }

        private void LoadDataToDataset()
        {
            PatientsAttendanceCrystalReport report = new PatientsAttendanceCrystalReport();

            SqlConnection con = new SqlConnection(mainCenter.GetConn());
            string sql = "select a.PatientId,p.Fullname,n.InsuranceNumber,a.CurrentDate from AllPatientsAttendance a inner join Patient p on a.patientId = p.PatientId inner join NHIS n on p.NhisId = n.NhisId where a.patientId LIKE '" + txtfoldernumber.Text + "' and a.CurrentDate between '" + DtpStart.Text + "' and '" + DtpEnd.Text + "'";

            con.Open();
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    AllPatientsAttendanceDataSet Ds = new AllPatientsAttendanceDataSet();
                    da.Fill(Ds, "AllPatientsAttendance");
                    report.SetDataSource(Ds.Tables[0]);
                    crystalReportViewer1.ReportSource = report;
                    crystalReportViewer1.Refresh();

                }
            }

            con.Close();
        }
    }
}
