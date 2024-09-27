using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

namespace DVLD_DataAccess
{
    public struct stTest
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        static public string Log { get; set; }
    }
    public class clsTestData
    {
        static void _SetParameters(ref SqlCommand Command, stTest Test)
        {
            Command.Parameters.AddWithValue("@TestID", Test.TestID);
            Command.Parameters.AddWithValue("@TestAppointmentID", Test.TestAppointmentID);
            Command.Parameters.AddWithValue("@TestResult", Test.TestResult);
            Command.Parameters.AddWithValue("@Notes", Test.Notes);
            Command.Parameters.AddWithValue("@CreatedByUserID", Test.CreatedByUserID);
        }
        public static bool AddNew(ref stTest Test)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "insert into Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)" +
                    "VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID) Select SCOPE_IDENTITY()";
                SqlCommand Command = new SqlCommand(Query, Connection);
                _SetParameters(ref Command, Test);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    Test.TestAppointmentID = ID;
                    return true;
                }
                else
                    stTest.Log = "Test not Added";
            }
            catch (Exception ex) 
            {
                stTest.Log = ex.Message;
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                    EventLog.CreateEventSource(sourceName, "Application");

                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Information);
            }
            finally
            {
                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
            return false;
        }
        public static int CountFailTest(int LocalLicenseID, int TestTypeID, ref string Log )
        {
            SqlConnection Connection = null;
            object Result = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = @"SELECT sum(case WHEN Tests.TestResult = 0 then 1 else 0 end)
                                 FROM Tests
                                 INNER JOIN TestAppointments ON 
                                 TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                                 where TestTypeID = @TestTypeID and 
                                 LocalDrivingLicenseApplicationID = @LocalLicenseID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);
                Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                Connection.Open();
                Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int FailTests))                
                    return FailTests;
                else
                {
                    Log = "Test Appointments is empty";
                    return 0;
                }
            }
            catch (Exception ex) 
            {
                Log = ex.Message;
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                    EventLog.CreateEventSource(sourceName, "Application");

                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Information);
            }
            finally
            {
                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
            return 0;
        }        
        static public bool isFaildCurrentTest(int LocalLicenseID, byte CurrentTest)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "SELECT Tests.TestResult FROM TestAppointments INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID where LocalDrivingLicenseApplicationID = @LocalLicenseID and TestTypeID = @TestTypeID and TestResult = @TestResult";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);
                Command.Parameters.AddWithValue("@TestTypeID", CurrentTest);
                Command.Parameters.AddWithValue("@TestResult", false);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    return true;
                }
                else
                    stLocalLicense.Log = "Local License is empty";
            }
            catch (Exception ex) 
            {
                stLocalLicense.Log = ex.Message;
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                    EventLog.CreateEventSource(sourceName, "Application");

                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Information);
            }
            finally
            {
                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
            return false;
        }
        static public byte CountPassTests(int LocalLicenseID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = @"SELECT sum(case WHEN Tests.TestResult = 1 then 1 else 0 end)
                                 FROM Tests
                                 INNER JOIN TestAppointments ON 
                                 TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                                 where LocalDrivingLicenseApplicationID = @LocalLicenseID";

                SqlCommand Command = new SqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);

                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && byte.TryParse(Result.ToString(), out byte PassTests))
                {
                    return PassTests;
                }
                else
                    stTest.Log = "Test Appointments is empty";
            }
            catch (Exception ex) 
            {
                stTest.Log = ex.Message;
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                    EventLog.CreateEventSource(sourceName, "Application");

                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Information);
            }
            finally
            {
                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
            return 0;
        }
    }
}
