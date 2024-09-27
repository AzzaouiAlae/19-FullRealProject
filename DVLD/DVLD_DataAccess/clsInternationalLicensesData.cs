using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel;
using System.Diagnostics;

namespace DVLD_DataAccess
{
    public struct stILicense
    {
        public int InternationalLicenseID;
        public int ApplicationID;
        public int DriverID;
        public int IssuedUsingLocalLicenseID;
        public DateTime IssueDate;
        public DateTime ExpirationDate;
        public bool IsActive;
        public int CreatedByUserID;
        static public string Log;
    }
    public class clsInternationalLicensesData
    {
        static void _SetParameter(ref SqlCommand Command, stILicense iLicense)
        {
            Command.Parameters.AddWithValue("@ApplicationID", iLicense.ApplicationID);
            Command.Parameters.AddWithValue("@DriverID", iLicense.DriverID);
            Command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", iLicense.IssuedUsingLocalLicenseID);
            Command.Parameters.AddWithValue("@IssueDate", iLicense.IssueDate);
            Command.Parameters.AddWithValue("@ExpirationDate", iLicense.ExpirationDate);
            Command.Parameters.AddWithValue("@IsActive", iLicense.IsActive);
            Command.Parameters.AddWithValue("@CreatedByUserID", iLicense.CreatedByUserID);
        }
        public static bool AddNew(ref stILicense iLicense)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "insert into InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID) VALUES " +
                    "(@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID) Select SCOPE_IDENTITY()";

                SqlCommand Command = new SqlCommand(Query, Connection);
                _SetParameter(ref Command, iLicense);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    iLicense.InternationalLicenseID = ID;
                    return true;
                }
                else
                    stILicense.Log = "International License not Added";
            }
            catch (Exception ex) 
            {
                stILicense.Log = ex.Message;
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
        static string _SetQuery(stILicense iLicense)
        {
            string Query = "Select * from InternationalLicenses";

            if(iLicense.InternationalLicenseID != -1)            
                Query += " Where InternationalLicenseID = @InternationalLicenseID";
            else if(iLicense.ApplicationID != -1)
                Query += " Where ApplicationID = @ApplicationID";
            else if (iLicense.DriverID != -1)
                Query += " Where DriverID = @DriverID";
            else if (iLicense.IssuedUsingLocalLicenseID != -1)
                Query += " Where IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID";

            return Query;
        }
        static stILicense _GetStILicense(SqlDataReader Reader)
        {
            stILicense ILicense =  new stILicense();
            ILicense.InternationalLicenseID = (int)Reader["InternationalLicenseID"];
            ILicense.ApplicationID = (int)Reader["ApplicationID"];
            ILicense.DriverID = (int)Reader["DriverID"];
            ILicense.IssuedUsingLocalLicenseID = (int)Reader["IssuedUsingLocalLicenseID"];
            ILicense.IssueDate = (DateTime)Reader["IssueDate"];
            ILicense.ExpirationDate = (DateTime)Reader["ExpirationDate"];
            ILicense.IsActive = (bool)Reader["IsActive"];
            ILicense.CreatedByUserID = (int)Reader["CreatedByUserID"];
            return ILicense;
        }
        public static bool Find(ref stILicense iLicense)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = _SetQuery(iLicense);
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@InternationalLicenseID", iLicense.InternationalLicenseID);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    iLicense = _GetStILicense(Reader);
                    return true;
                }
                else
                    stILicense.Log = "International License not found";
            }
            catch (Exception ex) 
            {
                stILicense.Log = ex.Message;
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
        public static int isILicenseExist(int LocalLicenseID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select InternationalLicenseID from InternationalLicenses where IssuedUsingLocalLicenseID = @LocalLicenseID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int iLicenseID))
                    return iLicenseID;                
                else
                    stILicense.Log = "International License not found";
            }
            catch (Exception ex) 
            {
                stILicense.Log = ex.Message;
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
        static public DataTable GetInterLicensesByPersonID(int PersonID)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            DataTable DT = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);

                string Query = "SELECT InternationalLicenses.InternationalLicenseID as [int.License ID], InternationalLicenses.ApplicationID as [Application ID], InternationalLicenses.IssuedUsingLocalLicenseID as [L.License ID], InternationalLicenses.IssueDate as [Issue Date], InternationalLicenses.ExpirationDate as [Expiration Date], InternationalLicenses.IsActive as [Is Active] FROM InternationalLicenses INNER JOIN Drivers ON InternationalLicenses.DriverID = Drivers.DriverID Where Drivers.PersonID = @PersonID";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@PersonID", PersonID);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    DT = new DataTable();
                    DT.Load(Reader);
                    return DT;
                }

                else
                    stILicense.Log = "International Licenses not found";
            }
            catch (Exception ex) 
            {
                stILicense.Log = ex.Message;
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
            return DT;
        }
        static public DataTable GetAllIntLicense()
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            DataTable DT = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);

                string Query = "SELECT InternationalLicenseID as [Int.License ID], ApplicationID as [Application ID], DriverID as [Driver ID], IssuedUsingLocalLicenseID as [L.License ID], IssueDate as [Issue Date], ExpirationDate as [Expiration Date], IsActive as [Is Active] FROM InternationalLicenses";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    DT = new DataTable();
                    DT.Load(Reader);
                    return DT;
                }

                else
                    stILicense.Log = "International Licenses not found";
            }
            catch (Exception ex)  
            {
                stILicense.Log = ex.Message;
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
            return DT;
        }
    }
}
