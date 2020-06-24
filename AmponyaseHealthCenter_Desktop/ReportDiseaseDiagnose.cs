using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AmponyaseHealthCenter_Desktop
{
    public partial class ReportDiseaseDiagnose : Form
    {
        MainCenter mainCenter = new MainCenter();

        int records = 0;
        public ReportDiseaseDiagnose()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mainCenter.GetConn());
            if (txtDiseaseName.Text == string.Empty)
            {
                txtDiseaseName.Text = "%";
               
                string sql = "select d.patientId,p.Fullname,n.InsuranceNumber,d.DiseaseTreated from PatientDiagnosis d inner join Patient p on d.PatientId = p.PatientId inner join NHIS n on p.NhisId = n.NhisId  where d.DiseaseTreated LIKE '" + txtDiseaseName.Text + "' and d.Date between '" + DtpStart.Text + "' and '" + DtpEnd.Text + "'";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        AHCDataset Ds = new AHCDataset();
                        da.Fill(Ds, "DiseaseDiagnosed");
                        dataGridView1.DataSource = Ds.Tables[0];
                        records = dataGridView1.RowCount - 1;

                    }
                }

                con.Close();

                MessageBox.Show( records +" records found", "User information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                string sql = "select d.patientId,p.Fullname,n.InsuranceNumber,d.DiseaseTreated from PatientDiagnosis d inner join Patient p on d.PatientId = p.PatientId inner join NHIS n on p.NhisId = n.NhisId  where d.DiseaseTreated LIKE '" + txtDiseaseName.Text + "' and d.Date between '" + DtpStart.Text + "' and '" + DtpEnd.Text + "'";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        AHCDataset Ds = new AHCDataset();
                        da.Fill(Ds, "DiseaseDiagnosed");
                        dataGridView1.DataSource = Ds.Tables[0];
                        records = dataGridView1.RowCount - 1;

                    }
                }


                con.Close();

                MessageBox.Show(records + " records found", "User information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            frmDiseaseReporting reporting = new frmDiseaseReporting();
            reporting.txtDiseaseName.Text = txtDiseaseName.Text;
            reporting.DtpStart.Text = DtpStart.Text;
            reporting.DtpEnd.Text = DtpEnd.Text;

            reporting.ShowDialog();
        }
    }
}
