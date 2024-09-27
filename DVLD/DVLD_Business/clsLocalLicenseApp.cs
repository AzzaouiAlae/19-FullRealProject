using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_Business
{
    public class clsLocalLicenseApp : clsApplications
    {
        public int LocalLicenseID { get; set; }
        public int LicenseClassID { get; set; }
        enum enMode { enAddNew, enUpdate }
        enMode Mode { get; set; }
        clsLocalLicenseApp(stLocalLicense l, stApp app) : base(app)
        {
            LocalLicenseID = l.LocalLicenseID;
            LicenseClassID = l.LicenseClassID;
            Mode = enMode.enUpdate;
        }
        public clsLocalLicenseApp() : base() 
        {
            Mode = enMode.enAddNew;
        }
        public static DataTable GetAllLocalLicense()
        {
            DataTable dt = clsLocalLicenseData.GetAllLocalLicense();
            Log = stLocalLicense.Log;

            if(dt == null || dt.Rows.Count < 1)
                return dt;

            DataRow[] Restults = dt.Select();
            foreach (DataColumn col in dt.Columns)
            {
                col.ReadOnly = false;
            }

            foreach (DataRow RecordRow in Restults)
            {
                if(RecordRow[0] != null && int.TryParse(RecordRow[0].ToString(), out int LocalLicenseID))
                {
                    object PassTests = clsTestData.CountPassTests(LocalLicenseID);
                    RecordRow["PassTests"] = PassTests;
                }
            }
            return dt;
        }
        static stLocalLicense ConvertObjToStLocalLicense(clsLocalLicenseApp License)
        {
            stLocalLicense l = new stLocalLicense();

            l.LocalLicenseID = License.LocalLicenseID;
            l.ApplicationID = License.ApplicationID;
            l.LicenseClassID = License.LicenseClassID;

            return l;
        }
        static public new clsLocalLicenseApp Find(int ID)
        {
            stLocalLicense l = new stLocalLicense();
            l.LocalLicenseID = ID;
            if(!clsLocalLicenseData.Find(ref l))
            {
                Log = stLocalLicense.Log;
                return null;                
            }

            stApp app = new stApp();
            app.ApplicationID = l.ApplicationID;
            if (!clsApplicationsData.Find(ref app))
            {
                Log = stApp.Log;
                return null;
            }

            return new clsLocalLicenseApp(l, app);
        }
        static public DataTable FindLocalLicenseByPersonID(int PersonID)
        {
            DataTable DT = null;
            if (clsLocalLicenseData.FindLocalLicenseByPersonID(ref DT, PersonID))
            {
                return DT;
            }
            Log = stLocalLicense.Log;
            return null;
        }
        bool _AddNew()
        {
            stApp App = ConvertObjToStApp(this);
            if (!clsApplicationsData.AddNew(ref App))
            {
                Log = stApp.Log;
                return false;
            }
            ApplicationID = App.ApplicationID;

            stLocalLicense l = ConvertObjToStLocalLicense(this);
            if(!clsLocalLicenseData.AddNew(ref l))
            {
                Log = stLocalLicense.Log;
                return false;
            }
            LocalLicenseID = l.LocalLicenseID;
            
            Mode = enMode.enUpdate;
            return true;
        }
        bool _Update()
        {
            if(!SaveApp())
            {
                Log = stApp.Log;
                return false;
            }
            stLocalLicense ll = ConvertObjToStLocalLicense(this);
            bool Result = clsLocalLicenseData.Update(ref ll);
            Log = stLocalLicense.Log;
            return Result;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.enAddNew:
                    return _AddNew();
                case enMode.enUpdate:
                    return _Update();
            }
            return false;
        }
        static public bool IsLocalLicenseExists(int LicenseClassID, int PersonID)
        {
            return clsLocalLicenseData.IsLocalLicense(LicenseClassID, PersonID);
        }        
        static public clsLocalLicenseApp NewLocalLicense(int personID, int licenseClassID, int CreatedByUserID)
        {
            if(clsLicense.isExist(personID, licenseClassID))
            {
                Log = "This Licenses is already exist";
                return null;
            }
            if(IsLocalLicenseExists(licenseClassID, personID))
            {
                Log = "This Application for Local Licenses is already exist";
                return null;
            }
            clsLocalLicenseApp LLApp = new clsLocalLicenseApp();
            LLApp.PersonID = personID;
            LLApp.ApplicationDate = DateTime.Now;
            LLApp.ApplicationTypeID = 1;
            LLApp.LicenseClassID = licenseClassID;
            LLApp.ApplicationStatus = 1;
            LLApp.LastStatusDate = DateTime.Now;
            LLApp.PaidFees = LLApp.ApplicationFees;
            LLApp.CreatedByUserID = CreatedByUserID;
            if (LLApp.Save())
            {
                return LLApp;
            }
            return null;
        }
        static public bool Delete(int ID)
        {
            clsLocalLicenseApp lla = Find(ID);
            if (lla == null)
                return false;
            if(clsTest.PassTests(ID) > 0)
            {
                Log = "this Application can't be deleted";
                return false;
            }

            if (!clsLocalLicenseData.Delete(lla.LocalLicenseID))
            {
                Log = stLocalLicense.Log;
                return false;
            }

            if (!lla.DeleteApp())
            {
                Log = stApp.Log;
                return false;
            }
            
            return true;
        }
        static public int GetPersonID(int LDLAppID)
        {
            int Result = clsLocalLicenseData.GetPersonID(LDLAppID);
            Log = stLocalLicense.Log;
            return Result;
        }
        static public string GetPersonName(int LDLAppID)
        {
            string Result = clsLocalLicenseData.GetPersonName(LDLAppID);
            Log = stLocalLicense.Log;
            return Result;
        }
        static public string GetClassName(int LDLAppID)
        {
            string name = clsLocalLicenseData.GetClassName(LDLAppID);
            Log = stLocalLicense.Log;
            return name;
        }
        static public clsLocalLicenseApp NewReTakeTestLocalApp(int LDLAppID, int CreatedByUserID)
        {
            clsLocalLicenseApp lApp = clsLocalLicenseApp.Find(LDLAppID);

            clsLocalLicenseApp ReTakeTestApp = new clsLocalLicenseApp();
            ReTakeTestApp.PersonID = lApp.PersonID;
            ReTakeTestApp.ApplicationDate = DateTime.Now;
            // 7 = ReTake Test Application
            ReTakeTestApp.ApplicationTypeID = 7;
            // 3 =  Application Status Complete
            ReTakeTestApp.ApplicationStatus = 3;
            ReTakeTestApp.LastStatusDate = DateTime.Now;
            ReTakeTestApp.PaidFees = ReTakeTestApp.ApplicationFees;
            ReTakeTestApp.CreatedByUserID = CreatedByUserID;
            ReTakeTestApp.LicenseClassID = lApp.LicenseClassID;
            if (ReTakeTestApp.Save())
                return ReTakeTestApp;

            return null;
        }
    }
}
