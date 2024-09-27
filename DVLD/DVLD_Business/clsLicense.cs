using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Business
{
    public class clsLicense : clsLicenseClasses
    {      
        int _DriverID;
        public int LicenseID { get; set; }
        public int LRAppID { get; set; }
        public int AppID { get; set; }
        public int DriverID
        {
            get { return _DriverID; }
            set 
            {
                Driver = clsDrivers.Find(value);
                if(Driver != null)
                {
                    _DriverID = value;
                }
            }
        }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        public clsDrivers Driver { get; private set; }
        enum enMode { enAddNew, enUpdate }
        enMode Mode { get; set; }
        static public new string Log { get; private set; }
        static stLicense ConvertObjToStLicense(clsLicense License)
        {
            stLicense L = new stLicense();
            L.LicenseID = License.LicenseID;
            L.IssueDate = License.IssueDate;
            L.IssueReason = License.IssueReason;
            L.Notes = License.Notes;
            L.IsActive = License.IsActive;
            L.DriverID = License.DriverID;
            L.ExpirationDate = License.ExpirationDate;
            L.AppID = License.AppID;
            L.PaidFees = License.PaidFees;
            L.CreatedByUserID = License.CreatedByUserID;
            L.LicenseClassID = License.LicenseClassID;
            return L;
        }
        public clsLicense() : base()
        {
            Mode = enMode.enAddNew;
        }
        clsLicense(stLicense License) : base(License.LicenseClassID)
        {
            LicenseID = License.LicenseID;
            IssueDate = License.IssueDate;
            IssueReason = License.IssueReason;
            Notes = License.Notes;
            IsActive = License.IsActive;
            DriverID = License.DriverID;
            ExpirationDate = License.ExpirationDate;
            AppID = License.AppID;
            PaidFees = License.PaidFees;
            CreatedByUserID = License.CreatedByUserID;
            Mode = enMode.enUpdate;
        }
        static public new clsLicense Find(int LicenseID)
        {
            stLicense l = new stLicense();
            l.LicenseID = LicenseID;
            if (clsLicenseData.Find(ref l))            
                return new clsLicense(l);
            
            else
            {
                Log = stLicense.Log;
                return null;
            }
        }
        static public int FindIDByAppID(int AppID)
        {
            int License = clsLicenseData.IsAppHasLicense(AppID);            

            Log = stLicense.Log;
            return License;
        }
        static public int FindIDByLDLAppID(int LDLAppID)
        {
            int License = clsLicenseData.GetLicenseIDbyLDLApp(LDLAppID);            
            Log = stLicense.Log;
            return License;
        }
        bool _AddNew()
        {
            stLicense l = ConvertObjToStLicense(this);

            if(clsLicenseData.AddNew(ref l))
            {
                LicenseID = l.LicenseID;
                return true;
            }
            Log = stLicense.Log;

            return false;
        }
        bool _Update()
        {
            stLicense l = ConvertObjToStLicense(this);

            if (clsLicenseData.Update(ref l))            
                return true;
            
            Log = stLicense.Log;
            return false;
        }        
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.enAddNew:
                    return _AddNew();
                case enMode.enUpdate:
                    return _Update();
            }
            return false;
        }
        static public clsLicense IssueReplacedLicense(int oldLicenseID, int AppTypesID, int CreatedByUserID)
        {            
            clsLicense OldLicense = Find(oldLicenseID);
            if (OldLicense == null) return null;
            if (!OldLicense.IsActive)
            {
                Log = "Old License is not Active";
                return null;
            }
            if (clsDetainedLicenses.isLicenseDetaine(oldLicenseID))
            {
                Log = "This License is Detained";
                return null;
            }
            clsLocalLicenseApp llApp = new clsLocalLicenseApp();
            llApp.LicenseClassID = OldLicense.LicenseClassID;
            llApp.PersonID = GetPersonID(oldLicenseID);
            llApp.ApplicationDate = DateTime.Now;
            llApp.ApplicationTypeID = AppTypesID;
            llApp.ApplicationStatus = 3;
            llApp.LastStatusDate = DateTime.Now;
            llApp.PaidFees = llApp.ApplicationFees;
            llApp.CreatedByUserID = CreatedByUserID;
            if(!llApp.Save())
            {
                Log = clsLocalLicenseApp.Log;
                return null;
            }
            
            clsLicense License = new clsLicense();
            License.LRAppID = llApp.LocalLicenseID;
            License.AppID = llApp.ApplicationID;
            License.DriverID = OldLicense.DriverID;
            License.LicenseClassID = OldLicense.LicenseClassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = GetExpirationDate(OldLicense.LicenseClassID);
            License.Notes = "";
            License.PaidFees = llApp.PaidFees;
            License.IsActive = true;
            License.IssueReason = (byte)AppTypesID;
            License.CreatedByUserID = CreatedByUserID;
            if(License.Save())
            {
                OldLicense.IsActive = false;

                if (OldLicense.Save())
                    return License;
            }
            return null;
        }        
        static public bool isExist(int personID, int licenseClassID)
        {
            return clsLicenseData.isExist(personID, licenseClassID);
        }
        static public clsLicense IssueNewLicense(int AppID, int CreatedByUserID, int LDLAppID, string Notes)
        {
            clsApplications App = clsApplications.Find(AppID);
            if( App == null ) 
            { 
                Log = clsApplications.Log; 
                return null; 
            }
            clsLocalLicenseApp llApp = clsLocalLicenseApp.Find(LDLAppID);
            if(llApp == null )
            {
                Log = clsLocalLicenseApp.Log;
                return null;
            }
            clsDrivers d = clsDrivers.GetDriver(App.PersonID, CreatedByUserID);
            if (d == null)
            {
                Log = clsDrivers.Log;
                return null;
            }

            clsLicense License = new clsLicense();
            License.AppID = AppID;
            License.DriverID = d.DriverID;
            License.LicenseClassID = llApp.LicenseClassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = GetExpirationDate(llApp.LicenseClassID);
            License.Notes = Notes;
            License.PaidFees = GetLicenseFee(llApp.LicenseClassID);
            License.IsActive = true;
            License.IssueReason = (byte)App.ApplicationTypeID;
            License.CreatedByUserID = CreatedByUserID;
            if (License.Save())
            {
                clsApplications.CompleteApp(App.ApplicationID);
                return License;
            }
            Log = stLicense.Log;
            return null;
        }
        static public bool IsLicenseActive(int LicenseID)
        {
            bool Result = clsLicenseData.IsLicenseActive(LicenseID);
            Log = stLicense.Log;
            return Result;
        }
        static public int GetPersonID(int LicenseID)
        {
            int Result = clsLicenseData.GetPersonID(LicenseID);
            Log = stLicense.Log;
            return Result;
        }
        static public clsLicense RenewLicense(int LicenseID, int CreatedByUserID, string Notes)
        {
            clsLicense ol = clsLicense.Find(LicenseID);
            if(ol == null)
            {
                Log = clsLicense.Log;
                return null;
            }
            if(ol.ExpirationDate > DateTime.Now)
            {
                Log = "This license has not expired yet";
                return null;
            }
            if (!ol.IsActive)
            {
                Log = "This license is not Active";
                return null;
            }
            if (clsDetainedLicenses.isLicenseDetaine(ol.LicenseID))
            {
                Log = "This License is Detained";
                return null;
            }
            clsApplications App = clsApplications.RenewLicenseApp(LicenseID, CreatedByUserID);
            if(App == null)
            {
                Log = clsApplications.Log;
                return null;
            }

            clsLicense L = new clsLicense();

            L.IssueDate = DateTime.Now;
            L.IssueReason = (byte)App.ApplicationTypeID;
            L.Notes = Notes;
            L.IsActive = true;
            L.DriverID = ol.DriverID;
            L.ExpirationDate = clsLicenseClasses.GetExpirationDate(ol.LicenseClassID);
            L.AppID = App.ApplicationID;
            L.PaidFees = ol.PaidFees;
            L.CreatedByUserID = CreatedByUserID;
            L.LicenseClassID = ol.LicenseClassID;

            if(L.Save())
            {
                ol.IsActive = false;
                ol.Save();

                return L;
            }

            return null;
        }
        static public int FindLicenseIDForIssueNewInteLicense(int PersonID)
        {
            int LicenseID = clsLicenseData.FindLicenseIDForIssueNewInteLicense(PersonID);
            Log = stLicense.Log;
            return LicenseID;
        }
    }
}
