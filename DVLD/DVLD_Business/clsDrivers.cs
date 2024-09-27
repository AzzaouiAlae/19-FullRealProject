using DVLD_DataAccess;
using System;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DVLD_Business
{
    public class clsDrivers : clsPerson
    {       
        public int DriverID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        enum enMode { enAddNew, enUpdate }
        enMode Mode { get; set; }
        static public new string Log { get; set; }
        public clsDrivers()
        {
            Mode = enMode.enAddNew;
        }        
        clsDrivers(stDriver Driver) : base(Driver.PersonID)
        {
            DriverID = Driver.DriverID;
            CreatedByUserID = Driver.CreatedByUserID;
            CreatedDate = Driver.CreatedDate;
            Mode = enMode.enUpdate;
        }        
        static stDriver _ConvertObjToStDriver(clsDrivers d)
        {
            stDriver Driver = new stDriver();

            Driver.DriverID = d.DriverID;
            Driver.PersonID = d.PersonID;
            Driver.CreatedByUserID = d.CreatedByUserID;
            Driver.CreatedDate = d.CreatedDate;

            return Driver;
        }
        bool _AddNew()
        {
            stDriver d = _ConvertObjToStDriver(this);
            if(clsDriversData.AddNew(ref d))
            {
                DriverID = d.DriverID;
                return true;
            }
            Log = stDriver.Log;
            return false;
        }
        bool _Update()
        {
            return false;
        }
        public new bool Save()
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
        static public clsDrivers FindDriverByPersonID(int PersonID)
        {
            stDriver Driver = new stDriver();
            Driver.PersonID = PersonID;
            if(clsDriversData.Find(ref  Driver))
            {
                return new clsDrivers(Driver);
            }
            Log = stDriver.Log;
            return null;
        }        
        public static clsDrivers Find(int DriverID)
        {
            stDriver Driver = new stDriver();
            Driver.DriverID = DriverID;
            if (clsDriversData.Find(ref Driver))
            {
                return new clsDrivers(Driver);
            }
            Log = stDriver.Log;
            return null;
        }
        static public clsDrivers GetDriver(int PersonID, int CreatedByUserID)
        {
            clsDrivers driver = FindDriverByPersonID(PersonID);
            if (driver == null)
            {
                driver = new clsDrivers();
                driver.PersonID = PersonID;
                driver.CreatedByUserID = CreatedByUserID;
                driver.CreatedDate = DateTime.Now;
                if (!driver.Save())
                    return null;
            }
            return driver;
        }
        static public DataTable GetAllDrivers()
        {
            DataTable dt = clsDriversData.GetAllDrivers();
            Log = stDriver.Log;
            return dt;
        }
    }
}
