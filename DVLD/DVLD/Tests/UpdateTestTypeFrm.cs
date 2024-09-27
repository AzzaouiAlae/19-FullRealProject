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
    public partial class UpdateTestTypeFrm : Form
    {
        public UpdateTestTypeFrm(int TestTypeID)
        {
            InitializeComponent();
            FillForm(TestTypeID);
        }

        clsTestTypes TestType;

        void FillForm(int TestTypeID)
        {
            TestType = clsTestTypes.FindTestTypes(TestTypeID);

            if (TestType == null)
            {
                MessageBox.Show(clsTestTypes.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbl_ID.Text = TestTypeID.ToString();
            txt_Title.Text = TestType.TestTypeTitle;
            txt_Description.Text = TestType.TestTypeDescription;
            txt_Fees.Text = TestType.TestTypeFees.ToString("0.00");
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(txt_Fees.Text, out decimal Fee))            
                TestType.TestTypeFees = Fee;            
            else
            {
                MessageBox.Show("Enter the Test Types fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TestType.TestTypeDescription = txt_Description.Text;
            TestType.TestTypeTitle = txt_Title.Text;
            if(TestType.Update())
                MessageBox.Show("Test type updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(clsTestTypes.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
