using System;
using System.Windows.Forms;

namespace AmponyaseHealthCenter_Desktop
{
    public partial class MDI_Dashboard : Form
    {

       
        public MDI_Dashboard()
        {
            InitializeComponent();
           
        }

        private void NewNHISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNHIS frmNHIS = new FrmNHIS();
            frmNHIS.ShowDialog();
            frmNHIS.MdiParent = this;

        }

        private void EditNHISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageNHIS frmManageNHIS = new FrmManageNHIS();
            frmManageNHIS.ShowDialog();
            frmManageNHIS.MdiParent = this;
           
        }

        private void EditPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagePatients frmManagePatients = new FrmManagePatients();
           
            frmManagePatients.ShowDialog();
            frmManagePatients.MdiParent = this;

        }

        private void DiagnosisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGetFolderNumber getFolderNumber = new FrmGetFolderNumber();
           
            getFolderNumber.ShowDialog();
            getFolderNumber.MdiParent = this;
        }

        private void SearchNHISToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            FrmSearchNHIS nHIS = new FrmSearchNHIS();
            
            nHIS.ShowDialog();
            nHIS.MdiParent = this;
        }

        private void SearchPatientsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSearchPatients searchPatients = new FrmSearchPatients();
           
            searchPatients.ShowDialog();
            searchPatients.MdiParent = this;
        }

        private void MDI_Dashboard_Load(object sender, EventArgs e)
        {
           int Num = Convert.ToInt32(lblStaffnumber.Text);
            StaffNumberRetrival.SetStaffNumber(Num);
        }

        private void backupDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackupScreen backup = new BackupScreen();
            DialogResult dialog = MessageBox.Show("Do you want system to backup your saved data?", "User message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                backup.ShowDialog();
            }
        }

        private void restoreDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreScreen restore = new RestoreScreen();
            DialogResult dialog = MessageBox.Show("Do you want system to restore your old data?", "User message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                restore.ShowDialog();
            }
        }

        private void LogOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();

            DialogResult dialog = MessageBox.Show("Do you want Logout?", "User message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                this.Visible = false;
                frmLogin.Visible = true;
               
            }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportOnDiseasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDiseaseDiagnose reportDisease = new ReportDiseaseDiagnose();
            reportDisease.ShowDialog();
        }

        private void reportOnPatientsAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPatientAttendanceReport patientAttendanceReport = new FrmPatientAttendanceReport();
            patientAttendanceReport.ShowDialog();
        }
    }
}
