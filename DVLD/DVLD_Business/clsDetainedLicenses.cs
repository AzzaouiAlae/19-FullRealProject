using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Business
{
    public class clsDetainedLicenses
    { 
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }        
        enum enMode { enAddNew, enUpdate}        
        static public string Log { get; set; }
        enMode Mode {  get; set; }
        clsDetainedLicenses(stDetained Detained)
        {
            DetainID = Detained.DetainID;
            LicenseID = Detained.LicenseID;
            DetainDate = Detained.DetainDate;
            FineFees = Detained.FineFees;
            CreatedByUserID = Detained.CreatedByUserID;
            IsReleased = Detained.IsReleased;
            ReleaseDate = Detained.ReleaseDate;
            ReleasedByUserID = Detained.ReleasedByUserID;
            ReleaseApplicationID = Detained.ReleaseApplicationID;
            
            Mode = enMode.enUpdate;
        }
        clsDetainedLicenses()
        {
            Mode = enMode.enAddNew;
        }
        static stDetained ConvetObjToStDetained(clsDetainedLicenses detained)
        {
            stDetained Detained = new stDetained();

            Detained.DetainID = detained.DetainID;
            Detained.LicenseID = detained.LicenseID;
            Detained.DetainDate = detained.DetainDate;
            Detained.FineFees = detained.FineFees;
            Detained.CreatedByUserID = detained.CreatedByUserID;
            Detained.IsReleased = detained.IsReleased;
            Detained.ReleaseDate = detained.ReleaseDate;
            Detained.ReleasedByUserID = detained.ReleasedByUserID;
            Detained.ReleaseApplicationID = detained.ReleaseApplicationID;

            return Detained;
        }
        bool _AddNew()
        {
            stDetained D = ConvetObjToStDetained(this);

            if (!clsDetainedLicensesData.AddNew(ref D))
            {
                Log = stDetained.Log;
                return false;
            }
            DetainID = D.DetainID;

            return true;
        }
        bool _Update()
        {
            stDetained d = ConvetObjToStDetained(this);
            bool Result = clsDetainedLicensesData.Update(ref d);
            
            Log = stDetained.Log;

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
        static public bool isLicenseDetaine(int LicenseID)
        {
            bool Result = clsDetainedLicensesData.isLicenseDetaine(LicenseID);
            Log = stDetained.Log;
            return Result;
        }
        static public clsDetainedLicenses DetaineLicense(int LicenseID, decimal Fees, int CreatedByUserID)
        {
            if(isLicenseDetaine(LicenseID))
            {
                Log = "This License is Already Detained";
                return null;
            }
            if(!clsLicense.IsLicenseActive(LicenseID))
            {
                Log = clsLicense.Log;
                return null;
            }
            clsDetainedLicenses dl = new clsDetainedLicenses();
            dl.LicenseID = LicenseID;
            dl.DetainDate = DateTime.Now;
            dl.FineFees = Fees;
            dl.CreatedByUserID = CreatedByUserID;
            dl.IsReleased = false;
            if (dl.Save())
                return dl;

            return null;
        }        
        static public int FindDetaineID(int LicenseID)
        {
            int Result = clsDetainedLicensesData.FindDetaineID(LicenseID);
            Log = stDetained.Log;
            return Result;
        }
        static public clsDetainedLicenses Find(int DetainID)
        {
            stDetained d = new stDetained();
            d.DetainID = DetainID;
            if(clsDetainedLicensesData.Find(ref d))
            {
                return new clsDetainedLicenses(d);
            }
            Log = stDetained.Log;
            return null;
        }
        static public DataTable GetAllDetainedLicense()
        {
            DataTable DT = clsDetainedLicensesData.GetAllDetainedLicense();
            Log = stDetained.Log;
            return DT;
        }
        static public bool IsRelease(int DetainID)
        {
            bool Result = clsDetainedLicensesData.IsRelease(DetainID);
            Log = stDetained.Log;
            return Result;
        }
    }
}
