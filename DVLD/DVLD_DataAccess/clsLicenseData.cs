using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Diagnostics;

namespace DVLD_DataAccess
{
    public struct stLicense
    {
        public int LicenseID { get; set; }
        public int AppID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        static public string Log { get; set; }
    }
    public class clsLicenseData
    {
        static stLicense _GetLicenseData(SqlDataReader Reader)
        {
            stLicense License = new stLicense();

            License.LicenseID = (int)Reader["LicenseID"];
            License.IssueDate = (DateTime)Reader["IssueDate"];
            License.IssueReason = (byte)Reader["IssueReason"];

            if (Reader["Notes"] != DBNull.Value)
                License.Notes = (string)Reader["Notes"];
            else
                License.Notes = "";

            License.IsActive = (bool)Reader["IsActive"];
            License.DriverID = (int)Reader["DriverID"];
            License.ExpirationDate = (DateTime)Reader["ExpirationDate"];
            License.LicenseClassID = (int)Reader["LicenseClassID"];
            return License;
        }
        static public bool Find(ref stLicense License)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "SELECT * FROM Licenses where LicenseID = @LicenseID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@LicenseID", License.LicenseID);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    License = _GetLicenseData(Reader);
                    return true;
                }
                else
                    stLicense.Log = "License not found";
            }
            catch (Exception ex) 
            {
                stLicense.Log = ex.Message;
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
        static public int IsAppHasLicense(int AppID)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select LicenseID from Licenses where ApplicationID = @AppID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@AppID", AppID);
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ID))                
                    return ID;
                
                else
                    stLicense.Log = "License not found";
            }
            catch (Exception ex) 
            {
                stLicense.Log = ex.Message;
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
            return -1;
        }
        static public int GetLicenseIDbyLDLApp(int LDLAppID)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "SELECT Licenses.LicenseID FROM LocalDrivingLicenseApplications INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN Licenses ON Applications.ApplicationID = Licenses.ApplicationID where LocalDrivingLicenseApplicationID = @ID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ID", LDLAppID);
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                    return ID;

                else
                    stLicense.Log = "License not found";
            }
            catch (Exception ex) 
            {
                stLicense.Log = ex.Message;
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
            return -1;
        }
        static void _SetParameters(ref SqlCommand Command, stLicense License)
        {
            Command.Parameters.AddWithValue("@ApplicationID", License.AppID);
            Command.Parameters.AddWithValue("@DriverID", License.DriverID);
            Command.Parameters.AddWithValue("@LicenseClass", License.LicenseClassID);
            Command.Parameters.AddWithValue("@IssueDate", License.IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", License.ExpirationDate);
            Command.Parameters.AddWithValue("@Notes", License.Notes);
            Command.Parameters.AddWithValue("@PaidFees", License.PaidFees);
            Command.Parameters.AddWithValue("@IsActive", License.IsActive);
            Command.Parameters.AddWithValue("@IssueReason", License.IssueReason);
            Command.Parameters.AddWithValue("@CreatedByUserID", License.CreatedByUserID);
        }
        static public bool AddNew(ref stLicense License)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "insert into Licenses (ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, " +
                    "IssueReason, CreatedByUserID) VALUES (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, " +
                    "@Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID) Select SCOPE_IDENTITY()";
                SqlCommand Command = new SqlCommand(Query, Connection);
                _SetParameters(ref Command, License);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    License.LicenseID = ID;
                    return true;
                }
                else
                    stLicense.Log = "License not Added";
            }
            catch (Exception ex) 
            {
                stLicense.Log = ex.Message;
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
        static public bool Update(ref stLicense License)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Update Licenses set IsActive = @IsActive where LicenseID = @LicenseID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@LicenseID", License.LicenseID);
                Command.Parameters.AddWithValue("@IsActive", License.IsActive);
                Connection.Open();
                int Result = Command.ExecuteNonQuery();
                if (Result > 0)
                    return true;
                else
                    stLicense.Log = "License not Updated";
            }
            catch (Exception ex) 
            {
                stLicense.Log = ex.Message;
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
        static public bool isExist(int personID, int licenseClassID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "SELECT Licenses.LicenseID, Drivers.PersonID, Licenses.LicenseClassID FROM Licenses INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID where PersonID = @PersonID and LicenseClassID = @LicenseClassID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@PersonID", personID);
                Command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)                
                    return true;                
                else
                    stLicense.Log = "License not found";
            }
            catch (Exception ex) 
            {
                stLicense.Log = ex.Message;
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
        static public bool IsLicenseActive(int LicenseID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "SELECT IsActive FROM Licenses where LicenseID = @LicenseID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@LicenseID", LicenseID);

                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    if ((bool)Result)
                        return true;
                    else                    
                        stLicense.Log = "License not Active";                    
                }
                else
                    stLicense.Log = "License not found";
            }
            catch (Exception ex) 
            {
                stLicense.Log = ex.Message;
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
        static public int GetPersonID(int LicenseID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "SELECT Drivers.PersonID FROM Licenses INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID Where LicenseID = @LicenseID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@LicenseID", LicenseID);

                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int PersonID))
                {
                    return PersonID;
                }
                else
                    stLicense.Log = "License not found";
            }
            catch (Exception ex) 
            {
                stLicense.Log = ex.Message;
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
            return -1;
        }
        static public int FindLicenseIDForIssueNewInteLicense(int PersonID)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "SELECT Licenses.LicenseID FROM Licenses INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID Where PersonID = @PersonID and LicenseClassID = 3 and IsActive = 1";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@PersonID", PersonID);
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int LicenseID))
                    return LicenseID;

                else
                    stLicense.Log = "License not found";
            }
            catch (Exception ex) 
            {
                stLicense.Log = ex.Message;
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
            return -1;
        }
    }
}
