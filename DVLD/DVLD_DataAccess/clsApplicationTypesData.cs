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
    public struct stAppType
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }
        static public string Log { get; set; }
    }
    public class clsApplicationTypesData
    {
        static public DataTable GetAllApplicationTypes()
        {
            DataTable dt = null;
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select * from ApplicationTypes";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt = new DataTable();
                    dt.Load(Reader);
                }
                else
                    stAppType.Log = "ApplicationTypes is empty";
            }
            catch (Exception ex) 
            {
                stAppType.Log = ex.Message;
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
            return dt;
        }
        static stAppType GetStAppType(SqlDataReader Reader)
        {
            stAppType AppType = new stAppType();

            AppType.ApplicationTypeID = (int)Reader["ApplicationTypeID"];
            AppType.ApplicationTypeTitle = (string)Reader["ApplicationTypeTitle"];
            AppType.ApplicationFees = (decimal)Reader["ApplicationFees"];

            return AppType;
        }
        static public bool Find(ref stAppType AppType)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select * from ApplicationTypes where ApplicationTypeID = @ID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ID", AppType.ApplicationTypeID);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    AppType = GetStAppType(Reader);
                    return true;
                }
                else
                    stAppType.Log = "Application Type not found";
            }
            catch (Exception ex)  
            {
                stAppType.Log = ex.Message;
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
        static public bool Update(ref stAppType AppType)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Update ApplicationTypes set ApplicationTypeTitle = @ApplicationTypeTitle, ApplicationFees = @ApplicationFees where ApplicationTypeID = @ApplicationTypeID";
                SqlCommand Command = new SqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("@ApplicationTypeID", AppType.ApplicationTypeID);
                Command.Parameters.AddWithValue("@ApplicationTypeTitle", AppType.ApplicationTypeTitle);
                Command.Parameters.AddWithValue("@ApplicationFees", AppType.ApplicationFees);

                Connection.Open();
                int Result = Command.ExecuteNonQuery();
                if (Result > 0)
                    return true;
                else
                    stAppType.Log = "Application Types not Updated";
            }
            catch (Exception ex)  
            {
                stAppType.Log = ex.Message;
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
