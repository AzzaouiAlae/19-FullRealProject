using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Controls;
using DVLD.Forms.Tests;
using DVLD.Properties;
using DVLD_Business;

namespace DVLD.Forms.License
{
    public partial class TestAppointmentsFrm : Form
    {
        public TestAppointmentsFrm(int LDLAppID, byte TestTypeID)
        {
            InitializeComponent();
            LoadForm(LDLAppID, TestTypeID);
        }
        void LoadForm(int LDLAppID, byte TestTypeID)
        {
            this.LDLAppID = LDLAppID;
            this.TestTypeID = TestTypeID;
            if (TestTypeID == 2)
            {
                pictureBox1.Image = Resources.exam2;
                lbl_Title.Text = "Written Test Appointments";
            }
            else if (TestTypeID == 3)
            {
                pictureBox1.Image = Resources.StreetTest;
                lbl_Title.Text = "Street Test Appointments";
            }
            licenseAppInfo.FindLocalLicense(LDLAppID);
            _Refresh();
        }

        int LDLAppID;

        byte TestTypeID;

        DataTable dt;

        DataView dv;
        void _Refresh()
        {
            dt = clsTest.FindListAppointment(LDLAppID, TestTypeID);
            dgv_LocalLicense.DataSource = null;
            dgv_LocalLicense.DataSource = dt;
            if(dt != null)
                dv = dt.DefaultView;
            else
                dv = new DataView();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        void ShowScheduleTestFrm()
        {
            ScheduleTestFrm Frm = new ScheduleTestFrm(TestTypeID, LDLAppID);
            Frm.MdiParent = MdiParent;
            Frm.Show();
            Frm.onSave += Frm_onSave;
        }
        private void btn_ScheduleTest_Click(object sender, EventArgs e)
        {
            if(_HasAppointment())           
                return;

            ShowScheduleTestFrm();
        }
        private void Frm_onSave(clsTestAppointment obj)
        {
            _Refresh();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_LocalLicense.CurrentRow != null)
            {
                if(int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out int TestAppointmentID))
                {                    
                    ScheduleTestFrm Frm = new ScheduleTestFrm(TestAppointmentID, TestTypeID, LDLAppID);
                    Frm.MdiParent = MdiParent;
                    Frm.Show();
                    Frm.onSave += Frm_onSave;
                }                
            }
        }
        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_LocalLicense.CurrentRow != null)
            {
                if (int.TryParse(dgv_LocalLicense.CurrentRow.Cells[0].Value.ToString(), out int ID))
                {
                    TakeTestFrm frm = new TakeTestFrm(ID, TestTypeID, LDLAppID);
                    frm.MdiParent = MdiParent;
                    frm.Show();
                    frm.onTestSaved += Frm_onTestSaved;
                }
            }
        }
        private void Frm_onTestSaved(clsTest Test)
        {
            _Refresh();
            int failTest = clsTest.CountFailTest(LDLAppID, TestTypeID);
            if (failTest >= 3)
            {
                clsLocalLicenseApp.CancelApp(LDLAppID);                
            }
        }
        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Refresh();
        }
        private void licenseAppInfo_OnFormFill(int AppID)
        {
            appBasicInfo.FillAppForm(AppID);
        }
        bool _HasAppointment()
        {
            if(clsTestAppointment.HasUnLockedAppointment(TestTypeID, LDLAppID))
            {
                MessageBox.Show("You Have an Appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (clsTest.isPassCurrentTest(LDLAppID, TestTypeID))
            {
                MessageBox.Show("You Pass the Current Test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (clsTest.CountFailTest(LDLAppID, TestTypeID) >= 3)
            {
                MessageBox.Show("You Fail 3 times in this test you need to make new application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgv_LocalLicense.CurrentRow != null)
            {
                if ((bool)dgv_LocalLicense.CurrentRow.Cells[3].Value)
                {
                    editToolStripMenuItem.Enabled = false;
                    takeTestToolStripMenuItem.Enabled = false;
                }
                else
                {
                    editToolStripMenuItem.Enabled = true;
                    takeTestToolStripMenuItem.Enabled = true;
                }
            }
        }
    }
}
