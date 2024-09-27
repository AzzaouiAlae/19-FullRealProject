using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsTestAppointment : clsTestTypes
    {
        public int TestAppointmentID { get; set; }
        public int LocalLicenseAppID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestAppID {  get; set; }
        enum enMode { enAddNew, enUpdate }
        static public new string Log { get; set; }
        enMode Mode { get; set; }
        public clsTestAppointment()
        {
            Mode = enMode.enAddNew;
        }
        protected clsTestAppointment(stTestAppointment TA)
        {
            TestAppointmentID = TA.TestAppointmentID;
            TestTypeID = TA.TestTypeID;
            LocalLicenseAppID = TA.LocalLicenseAppID;
            AppointmentDate = TA.AppointmentDate;
            TestTypeFees = TA.PaidFees;
            CreatedByUserID = TA.CreatedByUserID;
            IsLocked = TA.IsLocked;
            Mode = enMode.enUpdate;
        }
        protected static stTestAppointment NewStTestApp()
        {
            stTestAppointment TA = new stTestAppointment();

            TA.TestAppointmentID = -1;
            TA.TestTypeID = -1;
            TA.LocalLicenseAppID = -1;
            TA.AppointmentDate = DateTime.Now;
            TA.PaidFees = -1;
            TA.CreatedByUserID = -1;
            TA.IsLocked = false;

            return TA;
        }
        static stTestAppointment _ConvertObjTostTestApp(clsTestAppointment clsTestApp)
        {
            stTestAppointment TestApp = new stTestAppointment();

            TestApp.TestAppointmentID = clsTestApp.TestAppointmentID;
            TestApp.TestTypeID = clsTestApp.TestTypeID;
            TestApp.LocalLicenseAppID = clsTestApp.LocalLicenseAppID;
            TestApp.AppointmentDate = clsTestApp.AppointmentDate;
            TestApp.PaidFees = clsTestApp.TestTypeFees;
            TestApp.CreatedByUserID = clsTestApp.CreatedByUserID;
            TestApp.IsLocked = clsTestApp.IsLocked;
            TestApp.RetakeTestAppID = clsTestApp.RetakeTestAppID;

            return TestApp;
        }
        static public DataTable FindListAppointment(int LDLAppID, byte TestTypeID)
        {
            clsLocalLicenseApp llApp = clsLocalLicenseApp.Find(LDLAppID);

            DataTable dt = clsTestAppointmentData.FindListAppointment(llApp.LicenseClassID, llApp.PersonID, TestTypeID, LDLAppID);
            Log = stTestAppointment.Log; 
            return dt;    
        }
        static public clsTestAppointment FindTestApp(int ID)
        {
            stTestAppointment ta = NewStTestApp();
            ta.TestAppointmentID = ID;
            if(clsTestAppointmentData.Find(ref ta))
            {
                return new clsTestAppointment(ta);
            }
            Log = stTestAppointment.Log;
            return null;
        }
        bool _AddNewTestApp()
        {
            stTestAppointment TestApp = _ConvertObjTostTestApp(this);
            if(clsTestAppointmentData.AddNew(ref TestApp))
            {
                TestAppointmentID = TestApp.TestAppointmentID;
                return true;
            }
            Log = stTestAppointment.Log;
            return false; 
        }
        bool _UpdateTestApp()
        {
            stTestAppointment TestApp = _ConvertObjTostTestApp(this);
            if (clsTestAppointmentData.Update(ref TestApp))            
                return true;
            
            
            Log = stTestAppointment.Log;
            return false;
        }
        public bool Lock()
        {
            IsLocked = true;

            return _UpdateTestApp();
        }
        protected bool UnLock()
        {
            IsLocked = false;

            return _UpdateTestApp();
        }
        public bool SaveTestApp()
        {
            if(IsLocked)
            {
                Log = "the Test Appointment Is Locked";
                return false;
            }
            switch (Mode)
            {
                case enMode.enAddNew:
                    return _AddNewTestApp();
                case enMode.enUpdate:
                    return _UpdateTestApp();
            }
            return false;
        }
        static public clsTestAppointment NewTestApp(int TestTypeID, int LDLAppID, int CreatedByUserID, DateTime AppDate, int retakeTestApp)
        {
            clsTestAppointment TestApp = new clsTestAppointment();
            TestApp.TestTypeID = TestTypeID;
            TestApp.LocalLicenseAppID = LDLAppID;
            TestApp.AppointmentDate = AppDate;
            TestApp.CreatedByUserID = CreatedByUserID;
            TestApp.IsLocked = false;
            TestApp.RetakeTestAppID = retakeTestApp;
            if (TestApp.SaveTestApp())
                return TestApp;

            Log = stTestAppointment.Log;
            return null;
        }       
        static public bool HasUnLockedAppointment(byte TestTypeID, int LDLAppID)
        {
            clsLocalLicenseApp llApp = clsLocalLicenseApp.Find(LDLAppID);

            bool Result = clsTestAppointmentData.HasUnLockedAppointment(llApp.LicenseClassID, llApp.PersonID, TestTypeID);
            Log = stTestAppointment.Log;
            return Result;
        }        
    }
}
