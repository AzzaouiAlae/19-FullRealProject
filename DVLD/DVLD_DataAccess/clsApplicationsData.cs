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
    public struct stApp
    {
        public int ApplicationID { get; set; }
        public int PersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public byte ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        static public string Log { get; set; }
    }
    public class clsApplicationsData
    {
        static void _SetParameters(ref SqlCommand Command, stApp App)
        {
            Command.Parameters.AddWithValue("@ApplicationID", App.ApplicationID);
            Command.Parameters.AddWithValue("@PersonID", App.PersonID);
            Command.Parameters.AddWithValue("@ApplicationDate", App.ApplicationDate);
            Command.Parameters.AddWithValue("@ApplicationTypeID", App.ApplicationTypeID);
            Command.Parameters.AddWithValue("@ApplicationStatus", App.ApplicationStatus);
            Command.Parameters.AddWithValue("@LastStatusDate", App.LastStatusDate);
            Command.Parameters.AddWithValue("@PaidFees", App.PaidFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", App.CreatedByUserID);
        }
        static public bool AddNew(ref stApp App)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "insert into Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID) values " +
                    "(@PersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID) Select SCOPE_IDENTITY()";
                SqlCommand Command = new SqlCommand(Query, Connection);
                _SetParameters(ref Command, App);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    App.ApplicationID = ID;
                    return true;
                }
                else
                    stApp.Log = "Application not added";
            }
            catch (Exception ex) 
            {
                stApp.Log = ex.Message;
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                    Console.WriteLine("Event source created.");
                }
                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Information);
            }
            finally
            {
                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
            return false;
        }
        static stApp _GetStApp(SqlDataReader Reader)
        {
            stApp App = new stApp();

            App.ApplicationID = (int)Reader["ApplicationID"];
            App.PersonID = (int)Reader["ApplicantPersonID"];
            App.ApplicationDate = (DateTime)Reader["ApplicationDate"];
            App.ApplicationTypeID = (int)Reader["ApplicationTypeID"];
            App.ApplicationStatus = (byte)Reader["ApplicationStatus"];
            App.LastStatusDate = (DateTime)Reader["LastStatusDate"];
            App.PaidFees = (decimal)Reader["PaidFees"];
            App.CreatedByUserID = (int)Reader["CreatedByUserID"];

            return App;
        }
        static public bool Find(ref stApp App)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select * from Applications where ApplicationID = @ID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ID", App.ApplicationID);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    App = _GetStApp(Reader);
                    return true;
                }
                else
                    stApp.Log = "Local License Application not found";
            }
            catch (Exception ex) 
            {
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                    Console.WriteLine("Event source created.");
                }
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
        static public bool Update(ref stApp App)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Update Applications set LastStatusDate = @LastStatusDate, ApplicationStatus = @ApplicationStatus, ApplicantPersonID = @PersonID where ApplicationID = @ApplicationID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                _SetParameters(ref Command, App);
                Connection.Open();
                int Result = Command.ExecuteNonQuery();
                if (Result > 0)
                    return true;
                else
                    stApp.Log = "Application not updated";
            }
            catch (Exception ex) 
            {
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                    Console.WriteLine("Event source created.");
                }
                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Information);
            }
            finally
            {
                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
            return false;
        }
        static public bool Delete(int AppID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Delete from Applications where ApplicationID = @ApplicationID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ApplicationID", AppID);
                Connection.Open();
                int Result = Command.ExecuteNonQuery();
                if (Result > 0)
                    return true;
                else
                    stApp.Log = "Application not Deleted";
            }
            catch (Exception ex) 
            {
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                    Console.WriteLine("Event source created.");
                }
                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Information);
            }
            finally
            {
                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
            return false;
        }
        static public bool Cancel(int AppID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Update Applications set ApplicationStatus = 2, ApplicationDate = @ApplicationDate where ApplicationID = @ApplicationID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ApplicationDate", DateTime.Now);
                Command.Parameters.AddWithValue("@ApplicationID", AppID);
                Connection.Open();
                int Result = Command.ExecuteNonQuery();
                if (Result > 0)
                    return true;
                else
                    stApp.Log = "Application not updated";
            }
            catch (Exception ex) 
            {
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                    Console.WriteLine("Event source created.");
                }
                EventLog.WriteEntry(sourceName, ex.Message, EventLogEntryType.Information);
            }
            finally
            {
                if (Connection != null && Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }
            return false;
        }
        static public bool Complete(int AppID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Update Applications set ApplicationStatus = 3, ApplicationDate = @ApplicationDate where ApplicationID = @ApplicationID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ApplicationDate", DateTime.Now);
                Command.Parameters.AddWithValue("@ApplicationID", AppID);
                Connection.Open();
                int Result = Command.ExecuteNonQuery();
                if (Result > 0)
                    return true;
                else
                    stApp.Log = "Application not updated";
            }
            catch (Exception ex) 
            {
                stApp.Log = ex.Message;
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                    Console.WriteLine("Event source created.");
                }
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
