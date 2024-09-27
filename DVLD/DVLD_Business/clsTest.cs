using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Business
{
    public class clsTest : clsTestAppointment
    {
        public int TestID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        enum enMode { enAddNew, enUpdate }        
        static public new string Log { get; set; }
        enMode Mode { get; set; }
        static public int CountFailTest(int LocalLicenseID, int TestTypeID)
        {
            string log = "";
            int Result = clsTestData.CountFailTest(LocalLicenseID, TestTypeID, ref log);
            log = Log;
            return Result;
        }
        clsTest()
        {
            Mode = enMode.enAddNew;
        }
        clsTest(stTestAppointment ta) : base(ta)
        {
            Mode = enMode.enUpdate;
        }
        static stTest _ConvertObjToStTest(clsTest Test)
        {
            stTest t = new stTest();

            t.TestID = Test.TestID;
            t.TestAppointmentID = Test.TestAppointmentID;
            t.TestResult = Test.TestResult;
            t.Notes = Test.Notes;
            t.CreatedByUserID = Test.CreatedByUserID;

            return t;
        }
        bool _AddNew()
        {
            stTest t = _ConvertObjToStTest(this);

            if(clsTestData.AddNew(ref t))
            {
                TestID = t.TestID;
                return true;
            }

            Log = stTest.Log;
            return false;
        }
        bool _Update()
        {
            return false;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.enAddNew: return _AddNew();
                case enMode.enUpdate: return _Update();
            }
            return false;
        }
        static public new clsTest FindTestApp(int TestAppID)
        {
            stTestAppointment ta = NewStTestApp();
            ta.TestAppointmentID = TestAppID;
            if (clsTestAppointmentData.Find(ref ta))
            {
                return new clsTest(ta);
            }
            Log = stTestAppointment.Log;
            return null;
        }
        static public clsTest SaveTestResult(int TestAppID, bool TestResult, string Notes, int CreatedByUserID)
        {
            clsTest TestApp = FindTestApp(TestAppID);
            if (TestApp != null)
            {
                if (!TestApp.Lock())
                {
                    Log = clsTestAppointment.Log;
                    return null;
                }
            }
            else
                return null;
            clsTest t = new clsTest();
            t.TestAppointmentID = TestAppID;
            t.TestResult = TestResult;
            t.Notes = Notes;
            t.CreatedByUserID = CreatedByUserID;
            if (t.Save())
                return t;

            TestApp.UnLock();

            return null;
        }
        static public bool isPassCurrentTest(int LocalLicenseID, byte CurrentTest)
        {
            byte CountPassTests = PassTests(LocalLicenseID);
            bool Result = CountPassTests >= CurrentTest;
            Log = stLocalLicense.Log;
            return Result;
        }
        static public byte PassTests(int LocalLicenseID)
        {
            return clsTestData.CountPassTests(LocalLicenseID);
        }
        static public bool isFaildCurrentTest(int LocalLicenseID, byte CurrentTest)
        {
            bool Result = clsTestData.isFaildCurrentTest(LocalLicenseID, CurrentTest);
            Log = stTest.Log;
            return Result;
        }
    }
}