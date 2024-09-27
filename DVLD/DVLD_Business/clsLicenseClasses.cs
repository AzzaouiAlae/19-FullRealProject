using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLD_DataAccess;
using static DVLD_DataAccess.clsLicenseClassesData;

namespace DVLD_Business
{
    public class clsLicenseClasses
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }
        static public string Log {  get; set; }
        static public DataTable GetAllLicenseClasses()
        {
            DataTable DT = clsLicenseClassesData.GetAllLicenseClasses();
        
            Log = stLicenseClasses.Log;
                
            return DT;
        }
        public clsLicenseClasses()
        {

        }
        protected clsLicenseClasses(int licenseClassID)
        {
            stLicenseClasses l = new stLicenseClasses();
            l.LicenseClassID = licenseClassID;
            l.ClassName = "";
            if (clsLicenseClassesData.Find(ref l))
            {
                LicenseClassID = l.LicenseClassID;
                ClassName = l.ClassName;
                ClassDescription = l.ClassDescription;
                MinimumAllowedAge = l.MinimumAllowedAge;
                DefaultValidityLength = l.DefaultValidityLength;
                ClassFees = l.ClassFees;
            }        
        }
        protected clsLicenseClasses(stLicenseClasses l)
        {
            LicenseClassID = l.LicenseClassID;
            ClassName = l.ClassName;
            ClassDescription = l.ClassDescription;
            MinimumAllowedAge = l.MinimumAllowedAge;
            DefaultValidityLength = l.DefaultValidityLength;
            ClassFees = l.ClassFees;
        }        
        static public clsLicenseClasses Find(int ID)
        {
            stLicenseClasses l = new stLicenseClasses();
            l.LicenseClassID = ID;
            l.ClassName = "";
            if (clsLicenseClassesData.Find(ref l))
            {
                return new clsLicenseClasses(l);
            }
            Log = stLicenseClasses.Log;
            return null;
        }

        static public string LicenseClassesName(int ID)
        {
            return clsLicenseClassesData.LicenseClassesName(ID);
        }
        static public DateTime GetExpirationDate(int ID)
        {
            clsLicenseClasses L = Find(ID);
            if (L == null)
                return DateTime.Now;
            else
                return DateTime.Now.AddYears(L.DefaultValidityLength);
        }
        public static decimal GetLicenseFee(int LicenseClasseID)
        {
            decimal Result = clsLicenseClassesData.GetLicenseFee(LicenseClasseID);
            Log = stLicenseClasses.Log;
            return Result;
        }
        static public byte GetLicenseClasseIDByClassName(string ClassName)
        {
            byte LicenseClassID = clsLicenseClassesData.GetLicenseClasseIDByClassName(ClassName);
            Log = stLicenseClasses.Log;
            return LicenseClassID;
        }
        static public clsLicenseClasses Find(string ClassName)
        {
            stLicenseClasses l = new stLicenseClasses();
            l.LicenseClassID = 0;
            l.ClassName = ClassName;
            if (clsLicenseClassesData.Find(ref l))
            {
                return new clsLicenseClasses(l);
            }
            Log = stLicenseClasses.Log;
            return null;
        }
    }
}