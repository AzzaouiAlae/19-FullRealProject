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

namespace DVLD.Forms
{
    public partial class ScheduleTestFrm : Form
    {
        public ScheduleTestFrm(byte TestTypeID, int LDLAppID)
        {
            InitializeComponent();
            visionTest.FillForm(TestTypeID, LDLAppID);
            RetakeTest(TestTypeID, LDLAppID);
            this.TestTypeID = TestTypeID;
            this.LDLAppID = LDLAppID;
        }

        byte TestTypeID;

        int LDLAppID;
        public ScheduleTestFrm(int TestAppointmentID, byte TestTypeID, int LDLAppID)
        {
            InitializeComponent();
            visionTest.FillForm(TestAppointmentID, TestTypeID, LDLAppID);
            RetakeTest(TestTypeID, LDLAppID, TestAppointmentID);
        }

        public event Action<clsTestAppointment> onSave;
        protected virtual void Save(clsTestAppointment TestAppointment)
        {
            Action<clsTestAppointment> Handler = onSave;

            if (Handler != null)
                Handler(TestAppointment);
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void visionTest_onSave(clsTestAppointment TestApp)
        {
            if(isRetakeTest)            
                retakeTestInfo.UpdateRetakeTestAppID(TestApp.LocalLicenseAppID);                
            
            Save(TestApp);
        }

        bool isRetakeTest = false;
        void RetakeTest(byte TestTypeID, int LDLAppID, int TestAppointmentID = -1)
        {
            if(clsTest.isFaildCurrentTest(LDLAppID, TestTypeID))
            {
                retakeTestInfo.Enabled = true;
                isRetakeTest = true;
                retakeTestInfo.FillForm(TestTypeID, TestAppointmentID, LDLAppID);    
                visionTest.isRetakeTest = true;
            }
        }
    }
}
