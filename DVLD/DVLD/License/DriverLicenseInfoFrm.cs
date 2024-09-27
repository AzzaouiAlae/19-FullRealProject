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
    public partial class DriverLicenseInfoFrm : Form
    {
        public DriverLicenseInfoFrm(int LicenseID, int iLicenseID = -1)
        {
            InitializeComponent();
            if(iLicenseID == -1)
                LicenseInfo.FindLicense(LicenseID);
            else            
                LicenseInfo.FindInternationalLicense(iLicenseID);            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
