using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public struct stLicenseClasses
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }
        static public string Log { get; set; }
    }
    public class clsLicenseClassesData
    {        
        static public DataTable GetAllLicenseClasses()
        {
            DataTable dt = null;
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select * from LicenseClasses";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt = new DataTable();
                    dt.Load(Reader);
                }
                else
                    stLicenseClasses.Log = "License Classes is empty";
            }
            catch (Exception ex) 
            {
                stLicenseClasses.Log = ex.Message;
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
        static stLicenseClasses _GetStLicenseClasses(SqlDataReader Reader)
        {
            stLicenseClasses LicenseClass = new stLicenseClasses();

            LicenseClass.LicenseClassID = (int)Reader["LicenseClassID"];
            LicenseClass.ClassName = (string)Reader["ClassName"];
            LicenseClass.ClassDescription = (string)Reader["ClassDescription"];
            LicenseClass.MinimumAllowedAge = (byte)Reader["MinimumAllowedAge"];
            LicenseClass.DefaultValidityLength = (byte)Reader["DefaultValidityLength"];
            LicenseClass.ClassFees = (decimal)Reader["ClassFees"];

            return LicenseClass;
        }
        static public bool Find(ref stLicenseClasses LicenseClasses)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select * from LicenseClasses where LicenseClassID = @ID or ClassName = @ClassName";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ID", LicenseClasses.LicenseClassID);
                Command.Parameters.AddWithValue("@ClassName", LicenseClasses.ClassName);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    LicenseClasses = _GetStLicenseClasses(Reader);
                    return true;
                }
                else
                    stLicenseClasses.Log = "License Classes not found";
            }
            catch (Exception ex) 
            {
                stLicenseClasses.Log = ex.Message;
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
        static public string LicenseClassesName(int ID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select ClassName from LicenseClasses where LicenseClassID = @ID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ID", ID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    return Result.ToString();
                }
                else
                    stLicenseClasses.Log = "License Classes not found";
            }
            catch (Exception ex) 
            {
                stLicenseClasses.Log = ex.Message;
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
        static public decimal GetLicenseFee(int LicenseClasseID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select ClassFees from LicenseClasses where LicenseClassID = @ID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ID", LicenseClasseID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && decimal.TryParse(Result.ToString(), out decimal Fee))                
                    return Fee;
                
                else
                    stLicenseClasses.Log = "License Classes not found";
            }
            catch (Exception ex) 
            {
                stLicenseClasses.Log = ex.Message;
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
        static public byte GetLicenseClasseIDByClassName(string ClassName)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select LicenseClassID from LicenseClasses where ClassName = @ClassName";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ClassName", ClassName);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && byte.TryParse(Result.ToString(), out byte LicenseClassID))
                    return LicenseClassID;

                else
                    stLicenseClasses.Log = "License Classes not found";
            }
            catch (Exception ex) 
            {
                stLicenseClasses.Log = ex.Message;
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
