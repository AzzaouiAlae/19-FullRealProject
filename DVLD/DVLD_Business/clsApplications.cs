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
    public class clsApplications : clsApplicationTypes
    {
        public int ApplicationID { get; set; }
        public int PersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        enum enMode { enAddNew, enUpdate }
        enMode Mode { get; set; }
        protected clsApplications(stApp App) : base()
        {
            ApplicationID = App.ApplicationID;
            PersonID = App.PersonID;
            ApplicationDate = App.ApplicationDate;
            ApplicationStatus = App.ApplicationStatus;
            LastStatusDate = App.LastStatusDate;
            PaidFees = App.PaidFees;
            CreatedByUserID = App.CreatedByUserID;
            ApplicationTypeID = App.ApplicationTypeID;
            Mode = enMode.enUpdate;
        }
        public clsApplications() : base()
        {

        }
        static public clsApplications Find(int ID)
        {
            stApp App = new stApp();
            App.ApplicationID = ID;
            if(!clsApplicationsData.Find(ref App))
            {
                Log = stApp.Log;
                return null;                
            }

            return new clsApplications(App);
        }
        static protected stApp ConvertObjToStApp(clsApplications Applications)
        {
            stApp App = new stApp();

            App.ApplicationID = Applications.ApplicationID;
            App.PersonID = Applications.PersonID;
            App.ApplicationDate = Applications.ApplicationDate;
            App.ApplicationStatus = Applications.ApplicationStatus;
            App.LastStatusDate = Applications.LastStatusDate;
            App.PaidFees = Applications.PaidFees;
            App.CreatedByUserID = Applications.CreatedByUserID;
            App.ApplicationTypeID = Applications.ApplicationTypeID;

            return App;
        }
        bool _AddNew()
        {
            stApp App = ConvertObjToStApp(this);
            if(clsApplicationsData.AddNew(ref App))
            {
                ApplicationID = App.ApplicationID;
                return true;
            }
            Log = stApp.Log;
            return false;
        }
        bool _Update()
        {
            stApp App = ConvertObjToStApp(this);
            if (clsApplicationsData.Update(ref App))
            {
                ApplicationID = App.ApplicationID;
                return true;
            }
            Log = stApp.Log;
            return false;

        }
        public bool SaveApp()
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
        protected bool DeleteApp()
        {
            bool result = clsApplicationsData.Delete(ApplicationID);
            Log = stApp.Log;
            return result;
        }
        static public bool CancelApp(int LDLAppID)
        {
            int ApplicationID = clsLocalLicenseData.FindAppID(LDLAppID);
            bool Result = clsApplicationsData.Cancel(ApplicationID);
            Log = stApp.Log;
            return Result;
        }
        static public bool CompleteApp(int ApplicationID)
        {
            bool Result = clsApplicationsData.Complete(ApplicationID);
            Log = stApp.Log;
            return Result;
        }        
        static public clsApplications RenewLicenseApp(int LicenseID, int CreatedByUserID)
        {
            clsLicense l = clsLicense.Find(LicenseID);
            if(l == null)
            {
                Log = clsLicense.Log;
                return null;
            }

            clsApplications App = new clsApplications();
            App.PersonID = l.Driver.PersonID;
            App.ApplicationDate = DateTime.Now;

            // Application Status = 3 is complete
            App.ApplicationStatus = 3;

            App.LastStatusDate = DateTime.Now;

            // Application Type "2" is : Renew Driving License Service
            App.ApplicationTypeID = 2;

            App.PaidFees = App.ApplicationFees;
            App.CreatedByUserID = CreatedByUserID;
            if(App.SaveApp())            
                return App;

            return null;
        }
        static public clsApplications NewReleaseDetainedLicsense(int LicenseID, int CreatedByUserID, int DetaineID)
        {
            clsLicense l = clsLicense.Find(LicenseID);
            clsDetainedLicenses d = clsDetainedLicenses.Find(DetaineID);
            
            if (l != null)
            {
                clsApplications ReleaseApp = new clsApplications();
                ReleaseApp.PersonID = l.Driver.PersonID;
                ReleaseApp.ApplicationDate = DateTime.Now;
                //Release Detained Driving Licsense
                ReleaseApp.ApplicationTypeID = 5;
                ReleaseApp.ApplicationStatus = 3;
                ReleaseApp.LastStatusDate = DateTime.Now;
                ReleaseApp.PaidFees = ReleaseApp.ApplicationFees;
                ReleaseApp.CreatedByUserID = CreatedByUserID;
                if(ReleaseApp.SaveApp())
                {
                    if (d != null)
                    {
                        d.IsReleased = true;
                        d.ReleaseDate = DateTime.Now;
                        d.ReleasedByUserID = CreatedByUserID;
                        d.ReleaseApplicationID = ReleaseApp.ApplicationID;
                        if (d.Save())
                            return ReleaseApp;
                        else
                            Log = stDetained.Log;
                    }
                    else
                        Log = stDetained.Log;                    
                }
            }
            else
                Log = stApp.Log;

            return null;
        }
    }
}
