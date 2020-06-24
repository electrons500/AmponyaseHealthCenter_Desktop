using System;
using System.Windows.Forms;

namespace AmponyaseHealthCenter_Desktop
{
    public partial class FrmGetFolderNumber : Form
    {
       
        public FrmGetFolderNumber()
        {
            InitializeComponent();
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            FrmDiagnosis diagnosis = new FrmDiagnosis();
            diagnosis.lblPatientId.Text = txtfolderNumber.Text;
            txtfolderNumber.Clear();
            diagnosis.ShowDialog();
           
        }

        private void txtfolderNumber_Click(object sender, EventArgs e)
        {
            txtfolderNumber.Clear();
        }

        private void FrmGetFolderNumber_Load(object sender, EventArgs e)
        {
            txtfolderNumber.Text = "Enter patient folder number";
        }
    }
}
