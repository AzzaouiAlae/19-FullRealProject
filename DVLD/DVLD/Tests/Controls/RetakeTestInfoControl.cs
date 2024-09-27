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

namespace DVLD.Controls.License
{
    public partial class RetakeTestInfoControl : UserControl
    {
        public RetakeTestInfoControl()
        {
            InitializeComponent();
        }
        public void FillForm(int TestTypeID, int TestAppointmentID, int LDLAppID)
        {
            if(TestAppointmentID == -1)
            {
                //7 = Retake Test
                decimal AppFee = clsApplicationTypes.GetApplicationFees(7);
                lbl_RAppFees.Text = AppFee.ToString("0.00");
                lbl_TotalFees.Text = (AppFee + clsTestTypes.GetTestTypeFees(TestTypeID)).ToString("0.00");
            }
            else
            {
                clsTestAppointment TestApp = clsTestAppointment.FindTestApp(TestAppointmentID);
                
                if(TestApp.LocalLicenseAppID != LDLAppID)
                {
                    clsLocalLicenseApp llApp = clsLocalLicenseApp.Find(TestApp.LocalLicenseAppID);
                    lbl_RAppFees.Text = llApp.ApplicationFees.ToString("0.00");
                    lbl_TotalFees.Text = (TestApp.TestTypeFees + llApp.ApplicationFees).ToString("0.00");
                    lbl_RTestAppID.Text = TestApp.LocalLicenseAppID.ToString();
                }
            }
        }
        public void UpdateRetakeTestAppID(int RetakeTestAppID)
        {
            lbl_RTestAppID.Text = RetakeTestAppID.ToString();
        }
    }
}
