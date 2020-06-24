using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AmponyaseHealthCenter_Desktop
{
    public partial class frmDiseaseReporting : Form
    {
        MainCenter mainCenter = new MainCenter();
        public frmDiseaseReporting()
        {
            InitializeComponent();
        }

        private void frmDiseaseReporting_Load(object sender, EventArgs e)
        {
            LoadDataToDataset();
        }

        private void LoadDataToDataset()
        {
            DiseaseDiagnosedCrystalReport report = new DiseaseDiagnosedCrystalReport();

            SqlConnection con = new SqlConnection(mainCenter.GetConn());
            string sql = "select d.patientId,p.Fullname,n.InsuranceNumber,d.DiseaseTreated from PatientDiagnosis d inner join Patient p on d.PatientId = p.PatientId inner join NHIS n on p.NhisId = n.NhisId  where d.DiseaseTreated LIKE '" + txtDiseaseName.Text + "' and d.Date between '" + DtpStart.Text + "' and '" + DtpEnd.Text + "'";
            con.Open();
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    AHCDataset Ds = new AHCDataset();
                    da.Fill(Ds, "DiseaseDiagnosed");

                    report.SetDataSource(Ds.Tables[0]);
                    crystalReportViewer1.ReportSource = report;
                    crystalReportViewer1.Refresh();

                }
            }

            con.Close();
        }
    }
}
