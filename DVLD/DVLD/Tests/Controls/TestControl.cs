using DVLD.Properties;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Controls.License
{
    public partial class TestControl : UserControl
    {
        public TestControl()
        {
            InitializeComponent();
        }

        clsTestAppointment TestApp;
        void _SetTestAppType()
        {
            if (TestTypeID == 2)
            {
                picBox.Image = Resources.exam2;
                lbl_Title.Text = "Written Test Appointments";
                gb.Text = "Written Test";
            }
            else if (TestTypeID == 3)
            {
                picBox.Image = Resources.StreetTest;
                lbl_Title.Text = "Street Test Appointments";
                gb.Text = "Street Test";
            }
        }
        public void FillForm(int TestTypeID, int LDLAppID)
        {
            this.TestTypeID = TestTypeID;
            this.LDLAppID = LDLAppID;
            _SetTestAppType();
            lbl_DLAppID.Text = LDLAppID.ToString();
            lbl_LicenseClassName.Text = clsLocalLicenseApp.GetClassName(LDLAppID);
            lbl_Name.Text = clsLocalLicenseApp.GetPersonName(LDLAppID);
            lbl_Trail.Text = clsTest.CountFailTest(LDLAppID, TestTypeID).ToString();
            dtp_DateOfTest.MinDate = DateTime.Now;
            lbl_Fees.Text = clsTestTypes.GetTestTypeFees(TestTypeID).ToString();
        }
        public void FillForm(int TestAppointmentID, int TestTypeID, int LDLAppID)
        {
            this.TestTypeID = TestTypeID;
            this.LDLAppID = LDLAppID;
            _SetTestAppType();           
            TestApp = clsTestAppointment.FindTestApp(TestAppointmentID);
            if (TestApp != null)
            {
                lbl_DLAppID.Text = LDLAppID.ToString();
                lbl_LicenseClassName.Text = clsLocalLicenseApp.GetClassName(LDLAppID);
                lbl_Name.Text = clsLocalLicenseApp.GetPersonName(LDLAppID);
                lbl_Trail.Text = clsTest.CountFailTest(LDLAppID, TestTypeID).ToString();
                dtp_DateOfTest.Value = TestApp.AppointmentDate;

                if(TestApp.AppointmentDate > DateTime.Now)
                    dtp_DateOfTest.MinDate = DateTime.Now;
                else
                    dtp_DateOfTest.MinDate = TestApp.AppointmentDate;

                lbl_DateOfTest.Text = TestApp.AppointmentDate.ToString("dd MMM yyyy");
                lbl_Fees.Text = TestApp.TestTypeFees.ToString("0.00");
            }
        }
        public void TakeTest(int TestAppointmentID, int TestTypeID, int LDLAppID)
        {
            btn_Save.Visible = false;
            dtp_DateOfTest.Visible = false;
            lbl_DateOfTest.Visible = true;
            FillForm(TestAppointmentID, TestTypeID, LDLAppID);               
        }

        int TestTypeID = -1;

        int LDLAppID = -1;

        public bool isRetakeTest = false;

        public event Action<clsTestAppointment> onSave;
        protected virtual void Save(clsTestAppointment TestAppointment)
        {
            Action<clsTestAppointment> Handler = onSave;
            if (Handler != null)
                Handler(TestAppointment);
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            int RetakeTestApp = 0;
            if (TestApp == null)
            {
                if (isRetakeTest)
                {
                    clsLocalLicenseApp App = clsLocalLicenseApp.NewReTakeTestLocalApp(LDLAppID, MainForm.UserID);
                    if (App == null)
                    {
                        MessageBox.Show(clsApplications.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    RetakeTestApp = App.LocalLicenseID;
                }
                TestApp = clsTestAppointment.NewTestApp(TestTypeID, LDLAppID, MainForm.UserID, dtp_DateOfTest.Value, RetakeTestApp);
            }
            else
            {
                TestApp.AppointmentDate = dtp_DateOfTest.Value;
                if(TestApp.SaveTestApp())
                {
                    Save(TestApp);
                    MessageBox.Show("Test Appointment Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (TestApp != null)
            {
                Save(TestApp);
                MessageBox.Show("Test Appointment Saved Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(clsTestAppointment.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
