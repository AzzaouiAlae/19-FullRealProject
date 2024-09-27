using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DVLD_DataAccess
{
    public struct stTestAppointment
    {
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalLicenseAppID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestAppID { get; set; }
        static public string Log { get; set; }
    }
    public class clsTestAppointmentData
    {
        static void _SetParameters(ref SqlCommand Command, stTestAppointment TestAppo)
        {
            Command.Parameters.AddWithValue("@TestTypeID", TestAppo.TestTypeID);
            Command.Parameters.AddWithValue("@LocalLicenseAppID", TestAppo.LocalLicenseAppID);
            Command.Parameters.AddWithValue("@AppointmentDate", TestAppo.AppointmentDate);
            Command.Parameters.AddWithValue("@PaidFees", TestAppo.PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", TestAppo.CreatedByUserID);
            Command.Parameters.AddWithValue("@IsLocked", TestAppo.IsLocked);
            Command.Parameters.AddWithValue("@RetakeTestAppID", TestAppo.RetakeTestAppID);
        }
        public static bool AddNew(ref stTestAppointment TestAppo)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = @"insert into TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, 
                                 AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppID) 
                                 VALUES (@TestTypeID, @LocalLicenseAppID, @AppointmentDate, @PaidFees, 
                                 @CreatedByUserID, @IsLocked, @RetakeTestAppID) 
                                 Select SCOPE_IDENTITY()";
                SqlCommand Command = new SqlCommand(Query, Connection);
                _SetParameters(ref Command, TestAppo);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    TestAppo.TestAppointmentID = ID;
                    return true;
                }
                else
                    stTestAppointment.Log = "Test appointment not Added";
            }
            catch (Exception ex) 
            {
                stTestAppointment.Log = ex.Message;
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
        public static DataTable FindListAppointment(int LicenseClassID, int PersonID, byte TestTypeID, int LDLAppID)
        {
            DataTable dt = null;
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {/*INNER JOIN LocalDrivingLicenseApplications ON 
                                 Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID 
                                 INNER JOIN TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                                 where LicenseClassID = @LicenseClassID and ApplicantPersonID = @PersonID 
                                 and TestTypeID = @TestTypeID and */
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = @"SELECT TestAppointmentID, AppointmentDate, 
                                 PaidFees, IsLocked 
                                 FROM TestAppointments where 
                                 LocalDrivingLicenseApplicationID = @LDLAppID 
                                 and TestTypeID = @TestTypeID";
                SqlCommand Command = new SqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                Command.Parameters.AddWithValue("@PersonID", PersonID);
                Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                Command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt = new DataTable();
                    dt.Load(Reader);
                }
                else
                    stTestAppointment.Log = "Test Appointments is empty";
            }
            catch (Exception ex) 
            {
                stTestAppointment.Log = ex.Message;
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                    EventLog.CreateEventSource(sourceName, "Application");

                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Information);
            }
            finally
            {
                if (Reader != null && !Reader.IsClosed)
                    Reader.Close();

                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
            return dt;
        }
        static stTestAppointment _GetstTestAppointment(SqlDataReader Reader)
        {
            stTestAppointment TestAppo = new stTestAppointment();

            TestAppo.TestAppointmentID = (int)Reader["TestAppointmentID"];
            TestAppo.TestTypeID = (int)Reader["TestTypeID"];
            TestAppo.LocalLicenseAppID = (int)Reader["LocalDrivingLicenseApplicationID"];
            TestAppo.AppointmentDate = (DateTime)Reader["AppointmentDate"];
            TestAppo.PaidFees = (decimal)Reader["PaidFees"];
            TestAppo.CreatedByUserID = (int)Reader["CreatedByUserID"];
            TestAppo.IsLocked = (bool)Reader["IsLocked"];

            return TestAppo;
        }
        public static bool Find(ref stTestAppointment TestAppo)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select * from TestAppointments where TestAppointmentID = @ID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ID", TestAppo.TestAppointmentID);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    TestAppo = _GetstTestAppointment(Reader);
                    return true;
                }
                else
                    stTestAppointment.Log = "Test Appointments is empty";
            }
            catch (Exception ex) 
            {
                stTestAppointment.Log = ex.Message;
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                    EventLog.CreateEventSource(sourceName, "Application");

                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Information);
            }
            finally
            {
                if (Reader != null && !Reader.IsClosed)
                    Reader.Close();

                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
            return false;
        }
        static public bool Update(ref stTestAppointment TestAppo)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Update TestAppointments set IsLocked = @IsLocked, AppointmentDate = @AppointmentDate Where TestAppointmentID = @ID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@IsLocked", TestAppo.IsLocked);
                Command.Parameters.AddWithValue("@ID", TestAppo.TestAppointmentID);
                Command.Parameters.AddWithValue("@AppointmentDate", TestAppo.AppointmentDate);
                Connection.Open();
                int Result = Command.ExecuteNonQuery();
                if (Result > 0)
                    return true;
                else
                    stTestAppointment.Log = "Test Appointments not Updated";
            }
            catch (Exception ex) 
            {
                stTestAppointment.Log = ex.Message;
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
        static public bool HasUnLockedAppointment(int LicenseClassID, int PersonID, byte TestTypeID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "SELECT TestAppointments.TestAppointmentID FROM Applications INNER JOIN LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID where LicenseClassID = @LicenseClassID and ApplicantPersonID = @PersonID and TestTypeID = @TestTypeID and IsLocked = @IsLocked";
                SqlCommand Command = new SqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                Command.Parameters.AddWithValue("@PersonID", PersonID);
                Command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                Command.Parameters.AddWithValue("@IsLocked", false);

                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                    return true;
                else
                    stApp.Log = "Local License Application not found";
            }
            catch (Exception ex) 
            {
                stApp.Log = ex.Message;
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
    }
}
