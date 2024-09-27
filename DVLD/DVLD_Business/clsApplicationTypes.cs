using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsApplicationTypes
    {
        int _ApplicationTypeID = -1;
        public int ApplicationTypeID
        {
            get { return _ApplicationTypeID; }
            set 
            {
                FindAppTypes(value);
            }
        }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }
        static public string Log { get; set; }
        static public DataTable GetAllApplicationTypes()
        {
            DataTable DT = clsApplicationTypesData.GetAllApplicationTypes();

            if (DT == null)
                Log = stAppType.Log;

            return DT;
        }
        protected clsApplicationTypes(stAppType AppType)
        {
            _ApplicationTypeID = AppType.ApplicationTypeID;
            ApplicationTypeTitle = AppType.ApplicationTypeTitle;
            ApplicationFees = AppType.ApplicationFees;
        }
        public clsApplicationTypes()
        {

        }
        public static clsApplicationTypes ApplicationTypesFind(int AppTypeID)
        {
            stAppType AppType = new stAppType();
            AppType.ApplicationTypeID = AppTypeID;

            if(clsApplicationTypesData.Find(ref AppType))            
                return new clsApplicationTypes(AppType);
            
            Log = stAppType.Log;

            return null;
        }
        public static decimal GetApplicationFees(int ID)
        {
            clsApplicationTypes AppTypes = ApplicationTypesFind(ID);

            if (AppTypes != null)
                return AppTypes.ApplicationFees;

            else 
                return -1;
        }
        void FindAppTypes(int ID)
        {
            stAppType AppType = new stAppType();
            AppType.ApplicationTypeID = ID;

            if (clsApplicationTypesData.Find(ref AppType))
            {
                _ApplicationTypeID = AppType.ApplicationTypeID;
                ApplicationTypeTitle = AppType.ApplicationTypeTitle;
                ApplicationFees = AppType.ApplicationFees;
            }
        }
        static stAppType ConvertObjToStAppType(clsApplicationTypes AppType)
        {
            stAppType appType = new stAppType();

            appType.ApplicationTypeID = AppType.ApplicationTypeID;
            appType.ApplicationTypeTitle = AppType.ApplicationTypeTitle;
            appType.ApplicationFees = AppType.ApplicationFees;

            return appType;
        }
        public bool Update()
        {
            stAppType appType = ConvertObjToStAppType(this);
            bool Result = clsApplicationTypesData.Update(ref appType);
            Log = stAppType.Log;
            return Result;
        }
    }
}
