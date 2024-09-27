using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DVLD_DataAccess
{
    public struct stLocalLicense
    {
        public int LocalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        static public string Log { get; set; }
    }
    public class clsLocalLicenseData
    {
        static public bool AddNew(ref stLocalLicense license)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "insert into LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) VALUES " +
                    "(@ApplicationID, @LicenseClassID) Select SCOPE_IDENTITY()";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
                Command.Parameters.AddWithValue("@LicenseClassID", license.LicenseClassID);

                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    license.LocalLicenseID = ID;
                    return true;
                }
                else
                    stLocalLicense.Log = "User not Added";
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
        static public DataTable GetAllLocalLicense()
        {
            DataTable dt = null;
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select * from LocalLicenseView order by [L.D.L.AppID] desc";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ApplicationTypeID", 1);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt = new DataTable();
                    dt.Load(Reader);
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
                if (Reader != null && !Reader.IsClosed)
                    Reader.Close();

                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
            return dt;
        }
        static public bool Find(ref stLocalLicense LocalLicense)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @ID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ID", LocalLicense.LocalLicenseID);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    LocalLicense.ApplicationID = (int)Reader["ApplicationID"];
                    LocalLicense.LicenseClassID = (int)Reader["LicenseClassID"];
                    return true;
                }
                else
                    stLocalLicense.Log = "Local License Application not found";
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
                if (Reader != null && !Reader.IsClosed)
                    Reader.Close();

                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
            return false;
        }        
        static public bool FindLocalLicenseByPersonID(ref DataTable DT, int PersonID)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);

                string Query = "Select Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive from Licenses inner join Applications on Applications.ApplicationID = Licenses.ApplicationID left join LicenseClasses on LicenseClasses.LicenseClassID = Licenses.LicenseClassID inner join People on People.PersonID = Applications.ApplicantPersonID where People.PersonID = @ID";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ID", PersonID);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    DT = new DataTable();
                    DT.Load(Reader);
                    return true;
                }
                
                else
                    stLocalLicense.Log = "Local License Application view not found";
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
                if (Reader != null && !Reader.IsClosed)
                    Reader.Close();

                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
            return false;
        }
        static public bool IsLocalLicense(int LicenseClassID, int PersonID)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "SELECT LocalDrivingLicenseApplications.LicenseClassID, Applications.ApplicantPersonID, Applications.ApplicationStatus FROM LocalDrivingLicenseApplications INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID where LicenseClassID = @LicenseClassID and ApplicantPersonID = @ApplicantPersonID and ApplicationStatus = 1";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                Command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    return true;
                }
                else
                    stLocalLicense.Log = "Local License Application not found";
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
                if (Reader != null && !Reader.IsClosed)
                    Reader.Close();

                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
            return false;
        }        
        static public bool Delete(int LDLAppID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Delete from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @ID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ID", LDLAppID);
                Connection.Open();
                int Result = Command.ExecuteNonQuery();
                if (Result > 0)
                    return true;
                else
                    stApp.Log = "Local Driving License Applications not Deleted";
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
        static public int FindAppID(int LDLAppID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select ApplicationID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @ID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ID", LDLAppID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))                
                    return ID;
                
                else
                    stLocalLicense.Log = "Local License Application not found";
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
            return -1;
        }
        static public int GetPersonID(int LDLAppID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "SELECT Applications.ApplicantPersonID FROM LocalDrivingLicenseApplications INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID Where LocalDrivingLicenseApplicationID = @LDLAppID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                    return ID;

                else
                    stLocalLicense.Log = "Local License Application not found";
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
            return -1;
        }
        static public string GetPersonName(int LDLAppID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "SELECT People.FirstName + (case WHEN SecondName is null then '' else ' ' + SecondName END) + (case WHEN ThirdName is null then '' else ' ' + ThirdName END) + ' ' + People.LastName FROM LocalDrivingLicenseApplications INNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN People ON Applications.ApplicantPersonID = People.PersonID Where LocalDrivingLicenseApplicationID = @LDLAppID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                    return Result.ToString();

                else
                    stLocalLicense.Log = "Local License Application not found";
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
            return "";
        } 
        static public string GetClassName(int LDLAppID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "SELECT LicenseClasses.ClassName FROM LocalDrivingLicenseApplications INNER JOIN LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID Where LocalDrivingLicenseApplicationID = @ID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ID", LDLAppID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                    return Result.ToString();

                else
                    stLocalLicense.Log = "Local License Application not found";
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
            return "";
        }
        static public bool Update(ref stLocalLicense LocalLicense)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Update LocalDrivingLicenseApplications set LicenseClassID = @LicenseClassID where LocalDrivingLicenseApplicationID = @LocalLicenseID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@LicenseClassID", LocalLicense.LicenseClassID);
                Command.Parameters.AddWithValue("@LocalLicenseID", LocalLicense.LocalLicenseID);
                Connection.Open();
                int Result = Command.ExecuteNonQuery();

                if (Result > 0)
                    return true;
                else
                    stLocalLicense.Log = "Local Driving License Applications not Updated";
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
    }
}
