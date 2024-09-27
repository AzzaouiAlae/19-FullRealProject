using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Forms.Tests
{
    public partial class TakeTestFrm : Form
    {
        public TakeTestFrm(int testAppID, int testTypeID, int lDLAppID)
        {
            InitializeComponent();
            visionTestControl1.TakeTest(testAppID, testTypeID, lDLAppID);
            TestAppID = testAppID;
            TestTypeID = testTypeID;
            LDLAppID = lDLAppID;
        }

        int TestAppID;

        int TestTypeID;

        int LDLAppID;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public event Action<clsTest> onTestSaved;
        protected virtual void TestSaved(clsTest Test)
        {
            Action<clsTest> Handler = onTestSaved;
            if (Handler != null)
                Handler(Test);
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you to save this Test?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;

            clsTest test = clsTest.SaveTestResult(TestAppID, rb_Pass.Checked, txt_Note.Text, MainForm.UserID);
            if (test != null)
            {
                MessageBox.Show("Test are saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TestSaved(test);
            }
            else
                MessageBox.Show("Test are saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
