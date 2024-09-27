using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Forms.License
{
    public partial class LocalDrivingLicenseApplicationInfoFrm : Form
    {
        public LocalDrivingLicenseApplicationInfoFrm(int ID)
        {
            InitializeComponent();
            licenseAppInfo1.FindLocalLicense(ID);
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void licenseAppInfo1_OnFormFill(int AppID)
        {
            appBasicInfo.FillAppForm(AppID);
        }
    }
}
