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

namespace DVLD.Forms.License
{
    public partial class NewDrivingLicenseFrm : Form
    {
        public NewDrivingLicenseFrm(int userID)
        {
            InitializeComponent();
            UserID = userID;
            _LoadLicenseClassesData();
            lbl_AppDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lbl_CreatedBy.Text = clsUser.GetUsernameByID(UserID);
        }
        public NewDrivingLicenseFrm(int userID, int LocalLicenseAppID)
        {
            InitializeComponent();
            UserID = userID;
            _LoadLicenseClassesData();
            lbl_AppDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lbl_CreatedBy.Text = clsUser.GetUsernameByID(UserID);
            LocalApp = clsLocalLicenseApp.Find(LocalLicenseAppID);
            lbl_Title.Text = "Update Local Driving License Application";
            _LoadLocalLicenseApp();
        }
        void _LoadLocalLicenseApp()
        {
            if(LocalApp != null)
            {
                findPerson.personFillter1.txt_Find.Text = LocalApp.PersonID.ToString();                
                lbl_AppID.Text = LocalApp.LocalLicenseID.ToString();
                lbl_AppDate.Text = LocalApp.ApplicationDate.ToString();
                cbx_ClassList.SelectedIndex = LocalApp.LicenseClassID - 1;
                lbl_AppFees.Text = LocalApp.ApplicationFees.ToString("0.00");
                lbl_CreatedBy.Text = clsUser.GetUsernameByID(LocalApp.CreatedByUserID);
                PersonID = LocalApp.PersonID;
                if (findPerson.personFillter1.cbx_FindBy.Text == "Person ID")
                {
                    if (int.TryParse(findPerson.personFillter1.txt_Find.Text, out int PersonID))
                        findPerson.personInfo.FindPerson(PersonID);
                }
                else
                    findPerson.personInfo.FindPerson(findPerson.personFillter1.txt_Find.Text);
            }
        }

        clsLocalLicenseApp LocalApp;

        DataTable dt;

        int PersonID = -1;

        int UserID = -1;
        void _LoadLicenseClassesData()
        {
            dt = clsLicenseClasses.GetAllLicenseClasses();
            if (dt == null) return;
            foreach(DataRow dr in dt.Rows)
            {
                cbx_ClassList.Items.Add(dr["ClassName"]);
            }
            if (cbx_ClassList.Items.Count > 0)
            {
                cbx_ClassList.SelectedIndex = 2;
                lbl_AppFees.Text = ((decimal)dt.Rows[2]["ClassFees"]).ToString("0.00");
            }
        }
        private void btn_Next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void findPerson_onPersonSelected(int personID)
        {
            PersonID = personID;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(LocalApp == null)
            {
                LocalApp = clsLocalLicenseApp.NewLocalLicense(PersonID, cbx_ClassList.SelectedIndex + 1, UserID);
                if (LocalApp != null)
                {
                    MessageBox.Show("Applications saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbl_AppID.Text = LocalApp.LocalLicenseID.ToString();
                    lbl_Title.Text = "Update Local Driving License Application";
                    Saved?.Invoke();
                }
                else
                    MessageBox.Show(clsLocalLicenseApp.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LocalApp.LicenseClassID = cbx_ClassList.SelectedIndex + 1;
                LocalApp.LastStatusDate = DateTime.Now;
                LocalApp.PersonID = PersonID;
                if (LocalApp.Save())
                {
                    MessageBox.Show("Applications saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Saved?.Invoke();
                }                
                else
                    MessageBox.Show(clsLocalLicenseApp.Log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbx_ClassList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_ClassList.SelectedItem == null) return;
            clsLicenseClasses lc = clsLicenseClasses.Find(cbx_ClassList.SelectedItem.ToString());
            if(lc != null)
                lbl_AppFees.Text = lc.ClassFees.ToString("0.00");
        }

        public Action Saved { get; set; }
    }
}