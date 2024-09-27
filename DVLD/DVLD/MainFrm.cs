using DVLD.Forms;
using DVLD.Forms.License;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class MainForm : Form
    {

        public MainForm(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }
        static public int UserID {  get; private set; }
        private void btn_ManagePeople_Click(object sender, EventArgs e)
        {
            ManagePeopleFrm M_People = new ManagePeopleFrm();
            M_People.MdiParent = this;
            M_People.Show();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ManageUsersFrm ManageUsers = new ManageUsersFrm();
            ManageUsers.MdiParent = this;
            ManageUsers.Show();
        }
        private void currentUserInfo_Click(object sender, EventArgs e)
        {
            UserInfoFrm frm = new UserInfoFrm(UserID);
            frm.MdiParent = this;
            frm.Show();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordFrm frm = new ChangePasswordFrm(UserID);
            frm.MdiParent = this;
            frm.Show();
        }
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ManageApp_Click(object sender, EventArgs e)
        {
            ManageApplicationFrm frm = new ManageApplicationFrm();
            frm.MdiParent = this;
            frm.Show();
        }
        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetainLicenseFrm Frm = new DetainLicenseFrm();
            Frm.MdiParent = this;
            Frm.Show();
        }
        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDrivingLicenseFrm Frm = new NewDrivingLicenseFrm(UserID);
            Frm.MdiParent = this;
            Frm.Show();
        }
        private void localDrivingLisenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseAppFrm Frm = new LocalDrivingLicenseAppFrm();
            Frm.MdiParent = this;
            Frm.Show();
        }
        private void lostDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepLostLicenseFrm Frm = new RepLostLicenseFrm();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInternationalLicenseFrm Frm = new NewInternationalLicenseFrm();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLicenseAppFrm Frm = new RenewLicenseAppFrm();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ManageDriversFrm Frm = new ManageDriversFrm();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypesFrm Frm = new ManageTestTypesFrm();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void internationalLisenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInternationalLicenseFrm Frm = new ManageInternationalLicenseFrm();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void releaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainLicenseFrm Frm = new ReleaseDetainLicenseFrm();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDetainedLicensesFrm Frm = new ListDetainedLicensesFrm();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainLicenseFrm Frm = new ReleaseDetainLicenseFrm();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseAppFrm Frm = new LocalDrivingLicenseAppFrm();
            Frm.MdiParent = this;
            Frm.Show();
        }
    }
}
