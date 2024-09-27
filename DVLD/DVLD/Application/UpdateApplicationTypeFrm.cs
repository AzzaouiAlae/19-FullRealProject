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
    public partial class UpdateApplicationTypeFrm : Form
    {
        public UpdateApplicationTypeFrm(int AppTypeID)
        {
            InitializeComponent();
            FillForm(AppTypeID);
        }
        void FillForm(int AppTypeID)
        {
            AppType = clsApplicationTypes.ApplicationTypesFind(AppTypeID);
            if(AppType == null)
            {
                MessageBox.Show(clsApplicationTypes.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbl_ID.Text = AppTypeID.ToString();
            txt_Title.Text = AppType.ApplicationTypeTitle;
            txt_Fees.Text = AppType.ApplicationFees.ToString("0.00");
        }

        clsApplicationTypes AppType;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {            
            if(decimal.TryParse(txt_Fees.Text, out decimal Fee))
                AppType.ApplicationFees = Fee;
            else
            {
                MessageBox.Show("Enter the application fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppType.ApplicationTypeTitle = txt_Title.Text;

            if(AppType.Update())
                MessageBox.Show("Application type updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(clsApplicationTypes.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
