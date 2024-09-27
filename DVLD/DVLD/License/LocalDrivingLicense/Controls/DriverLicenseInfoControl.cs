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
using System.IO;

namespace DVLD.Controls
{
    public partial class DriverLicenseInfoControl : UserControl
    {
        public DriverLicenseInfoControl()
        {
            InitializeComponent();
        }
        public void FindLicense(int LicenseID)
        {
            clsLicense l = clsLicense.Find(LicenseID);
            if(l == null)
            {
                MessageBox.Show(clsLicense.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbl_Class.Text = l.ClassName;            
            lbl_LicenseID.Text = l.LicenseID.ToString();
            if(l.Driver != null)
            {
                lbl_Name.Text = l.Driver.FullName();
                lbl_NarionalNo.Text = l.Driver.NationalNo;
                lbl_Gendor.Text = l.Driver.Gendor ? "Female" : "Male";
                lbl_DateOfBirth.Text = l.Driver.DateOfBirth.ToString("dd MMM yyyy");
                lbl_DriverID.Text = l.DriverID.ToString();
                if(File.Exists(l.Driver.ImagePath))
                    picBox_Person.Image = Image.FromFile(l.Driver.ImagePath);
            }
            lbl_IssueDate.Text = l.IssueDate.ToString("dd MMM yyyy");
            switch(l.IssueReason) 
            {
                case 1:
                    lbl_IssueReason.Text = "First Time";
                    break;
                case 2:
                    lbl_IssueReason.Text = "Renew License";
                    break;
                case 3:
                    lbl_IssueReason.Text = "Replacement for a Lost";
                    break;
                case 4:
                    lbl_IssueReason.Text = "Replacement for a Damaged";
                    break;
                case 6:
                    lbl_IssueReason.Text = "International License";
                    break;                
            }
            lbl_Notes.Text = l.Notes;
            lbl_IsActive.Text = l.IsActive ? "Yes" : "No";
            lbl_ExpirationDate.Text = l.ExpirationDate.ToString("dd MMM yyyy");
            lbl_IsDetained.Text = clsDetainedLicenses.isLicenseDetaine(l.LicenseID) ? "Yes" : "No";
            LicenseFound(LicenseID);
        }
        public void FindInternationalLicense(int iLicenseID)
        {
            clsInternationalLicense il = clsInternationalLicense.Find(iLicenseID);
            if(il == null )
            {
                MessageBox.Show(clsInternationalLicense.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbl_Class.Text = clsLicenseClasses.LicenseClassesName(3);
            lbl_LicenseID.Text = il.InternationalLicenseID.ToString();
            if (il.Driver != null)
            {
                lbl_Name.Text = il.Driver.FullName();
                lbl_NarionalNo.Text = il.Driver.NationalNo;
                lbl_Gendor.Text = il.Driver.Gendor ? "Female" : "Male";
                lbl_DateOfBirth.Text = il.Driver.DateOfBirth.ToString("dd MMM yyyy");
                lbl_DriverID.Text = il.DriverID.ToString();
            }
            lbl_IssueDate.Text = il.IssueDate.ToString("dd MMM yyyy");
            lbl_IssueReason.Text = "International License";
            lbl_Notes.Text = "";
            lbl_IsActive.Text = il.IsActive ? "Yes" : "No";
            lbl_ExpirationDate.Text = il.ExpirationDate.ToString("dd MMM yyyy");
            LicenseFound(iLicenseID);
        }

        public event Action<int> onLicenseFound;
        protected virtual void LicenseFound(int LicenseID)
        {
            Action<int> Handler = onLicenseFound;
            if (Handler != null)
                Handler(LicenseID);
        }
    }
}
