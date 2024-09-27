using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTestTypes
    {
        int _TestTypeID = -1;
        public int TestTypeID 
        {
            get { return _TestTypeID; } 
            protected set 
            { 
                if(value != _TestTypeID)
                {
                    FindTypes(value);
                }
            }
        }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set;}
        public decimal TestTypeFees { get; set;}
        static public string Log {  get; set; }
        protected clsTestTypes()
        {

        }
        clsTestTypes(stTestTypes TestTypes)
        {
            TestTypeID = TestTypes.TestTypeID;
            TestTypeTitle = TestTypes.TestTypeTitle;
            TestTypeDescription = TestTypes.TestTypeDescription;
            TestTypeFees = TestTypes.TestTypeFees;
        }
        static public clsTestTypes FindTestTypes(int ID)
        {
            stTestTypes TestTypes = new stTestTypes();
            TestTypes.TestTypeID = ID;
            if (clsTestTypesData.Find(ref TestTypes))
            {
                return new clsTestTypes(TestTypes);
            }
            Log = stTestTypes.Log;
            return null;
        }
        protected void FindTypes(int ID)
        {
            stTestTypes TestTypes = new stTestTypes();
            TestTypes.TestTypeID = ID;
            if (clsTestTypesData.Find(ref TestTypes))
            {
                _TestTypeID = TestTypes.TestTypeID;
                TestTypeTitle = TestTypes.TestTypeTitle;
                TestTypeDescription = TestTypes.TestTypeDescription;
                TestTypeFees = TestTypes.TestTypeFees;
            }
            Log = stTestTypes.Log;
        }
        public static decimal GetTestTypeFees(int testTypeID)
        {
            decimal result = clsTestTypesData.GetTestTypeFees(testTypeID);
            Log = stTestTypes.Log;
            return result;
        }
        stTestTypes ConvertObjStTestType(clsTestTypes TestType)
        {
            stTestTypes testTypes = new stTestTypes();

            testTypes.TestTypeID = TestType.TestTypeID;
            testTypes.TestTypeTitle = TestType.TestTypeTitle;
            testTypes.TestTypeDescription = TestType.TestTypeDescription;
            testTypes.TestTypeFees = TestType.TestTypeFees;

            return testTypes;
        }
        public bool Update()
        {
            stTestTypes testTypes = ConvertObjStTestType(this);
            bool Result = clsTestTypesData.Update(ref testTypes);
            Log = stTestTypes.Log;
            return Result;
        }
        static public DataTable GetAllTestTypes()
        {
            DataTable DT = clsTestTypesData.GetAllTestTypes();
            Log = stTestTypes.Log;
            return DT;
        }
    }
}
