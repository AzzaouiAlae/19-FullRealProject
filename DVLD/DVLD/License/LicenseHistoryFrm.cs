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

namespace DVLD.Forms.License
{
    public partial class LicenseHistoryFrm : Form
    {
        public LicenseHistoryFrm(int LDLAppID, int LicenseID = -1, int PersonID = -1)
        {
            InitializeComponent();

            if (PersonID != -1)            
                FillLicenseHistoryForm(PersonID);            
            else
                FillLicenseHistoryForm(LDLAppID, LicenseID);            
        }
        public LicenseHistoryFrm(string NationalNo)
        {
            InitializeComponent();

            FillLicenseHistoryForm(NationalNo);
        }
        public void FillLicenseHistoryForm(int LDLAppID, int LicenseID)
        {
            int PersonID = -1;
            if (LicenseID != -1)
                PersonID = clsLicense.GetPersonID(LicenseID);
            else
                PersonID = clsLocalLicenseApp.GetPersonID(LDLAppID);
            if(PersonID == -1) 
            {
                MessageBox.Show(clsLocalLicenseApp.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            personFillter1.txt_Find.Text = PersonID.ToString();
            personInfo.FindPerson(PersonID);
            driverLicenses.FillData(PersonID);
        }
        public void FillLicenseHistoryForm(int PersonID)
        {
            if (PersonID == -1)
            {
                MessageBox.Show(clsLocalLicenseApp.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            personFillter1.txt_Find.Text = PersonID.ToString();
            personInfo.FindPerson(PersonID);
            driverLicenses.FillData(PersonID);
        }
        public void FillLicenseHistoryForm(string NationalNo)
        {
            clsPerson p = clsPerson.FindPerson(NationalNo);
            FillLicenseHistoryForm(p.PersonID);
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
