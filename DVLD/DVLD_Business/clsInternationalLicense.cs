using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsInternationalLicense
    {
        int _DriverID = -1;
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID
        {
            get { return _DriverID; }
            set
            {
                Driver = clsDrivers.Find(value);
                if (Driver != null)
                    _DriverID = value;
            }
        }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public clsDrivers Driver { get; private set; }
        enMode Mode { get; set; }
        enum enMode { enAddNew, enUpdate }
        static public string Log { get; set; }
        static public clsInternationalLicense IssueInternationalLicense(int CreatedByUserID, int LicenseID)
        {
            clsLicense l = clsLicense.Find(LicenseID);
            if (l == null)
            {
                Log = clsLicense.Log;
                return null;
            }

            //Class 3 - Ordinary driving license
            if (l.LicenseClassID != 3)
            {
                Log = "This License not Class 3 - Ordinary driving license";
                return null;
            }
            int interLicenseID = isILicenseExist(LicenseID);
            if(interLicenseID != -1)
            {
                Log = $"This License already has an International License, The ID is {interLicenseID}";
                return null;
            }
            if (clsDetainedLicenses.isLicenseDetaine(LicenseID))
            {
                Log = "This License is Detained";
                return null;
            }
            if (!clsLicense.IsLicenseActive(LicenseID))
            {
                Log = clsLicense.Log;
                return null;
            }
            clsApplications App = new clsApplications();
            App.PersonID = l.Driver.PersonID;
            App.ApplicationDate = DateTime.Now;

            //ApplicationType ID 6 = New International License
            App.ApplicationTypeID = 6;

            // Status 3 = Complete
            App.ApplicationStatus = 3;

            App.LastStatusDate = DateTime.Now;
            App.PaidFees = App.ApplicationFees;
            App.CreatedByUserID = CreatedByUserID;
            if(!App.SaveApp())
            {
                Log = clsApplications.Log;
                return null;
            }
            clsInternationalLicense iLicense = new clsInternationalLicense();
            iLicense.ApplicationID = App.ApplicationID;
            int DriverID = l.DriverID;
            if(DriverID == -1)
            {
                Log = clsDrivers.Log;
                return null;
            }
            iLicense.DriverID = DriverID;
            iLicense.IssuedUsingLocalLicenseID = LicenseID;
            iLicense.IssueDate = DateTime.Now;

            //Class 3 - Ordinary driving license | DefaultValidityLength = 10 Years
            iLicense.ExpirationDate = DateTime.Now.AddYears(10);

            iLicense.IsActive = true;
            iLicense.CreatedByUserID = CreatedByUserID;
            if(iLicense.Save())
            {
                return iLicense;
            }
            Log = stILicense.Log;
            return null;
        }
        static stILicense ConvertObjToStILicense(clsInternationalLicense iLicense)
        {
            stILicense il = new stILicense();
            il.InternationalLicenseID = iLicense.InternationalLicenseID;
            il.ApplicationID = iLicense.ApplicationID;
            il.DriverID = iLicense.DriverID;
            il.IssuedUsingLocalLicenseID = iLicense.IssuedUsingLocalLicenseID;
            il.IssueDate = iLicense.IssueDate;
            il.ExpirationDate = iLicense.ExpirationDate;
            il.IsActive = iLicense.IsActive;
            il.CreatedByUserID = iLicense.CreatedByUserID;
            return il;
        }
        clsInternationalLicense()
        {
            Mode = enMode.enAddNew;
        }
        clsInternationalLicense(stILicense iLicense)
        {
            InternationalLicenseID = iLicense.InternationalLicenseID;
            ApplicationID = iLicense.ApplicationID;
            DriverID = iLicense.DriverID;
            IssuedUsingLocalLicenseID = iLicense.IssuedUsingLocalLicenseID;
            IssueDate = iLicense.IssueDate;
            ExpirationDate = iLicense.ExpirationDate;
            IsActive = iLicense.IsActive;
            CreatedByUserID = iLicense.CreatedByUserID;
            Mode = enMode.enUpdate;
        }
        static public clsInternationalLicense Find(int iLicenseID)
        {
            stILicense iLicense = new stILicense();
            iLicense.InternationalLicenseID = iLicenseID;
            iLicense.ApplicationID = -1;
            iLicense.DriverID = -1;
            iLicense.IssuedUsingLocalLicenseID = -1;
            if(clsInternationalLicensesData.Find(ref iLicense))
            {
                return new clsInternationalLicense(iLicense);
            }
            return null;
        }
        bool _AddNew()
        {
            stILicense il = ConvertObjToStILicense(this);
            if(clsInternationalLicensesData.AddNew(ref il))
            {
                InternationalLicenseID = il.InternationalLicenseID;
                Mode = enMode.enUpdate;
                return true;
            }
            return false;
        }
        bool _Update()
        {
            return false;
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
        static int isILicenseExist(int LocalLicenseID)
        {
            int Result = clsInternationalLicensesData.isILicenseExist(LocalLicenseID);
            Log = stILicense.Log;
            return Result;
        }
        static public DataTable FindInterLicensesByPersonID(int PersonID)
        {
            DataTable Table = clsInternationalLicensesData.GetInterLicensesByPersonID(PersonID);
            Log = stILicense.Log;
            return Table;
        }
        static public DataTable GetAllIntLicense()
        {
            DataTable DT = clsInternationalLicensesData.GetAllIntLicense();
            Log = stILicense.Log;
            return DT;
        }
    }
}
