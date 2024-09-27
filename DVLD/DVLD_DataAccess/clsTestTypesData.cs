using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using System.Diagnostics;

namespace DVLD_DataAccess
{
    public struct stTestTypes
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }
        static public string Log { get; set; }
    }
    public class clsTestTypesData
    {
        static stTestTypes _GetStTestTypes(SqlDataReader Reader)
        {
            stTestTypes Test = new stTestTypes();

            Test.TestTypeID = (int)Reader["TestTypeID"];
            Test.TestTypeTitle = (string)Reader["TestTypeTitle"];
            Test.TestTypeDescription = (string)Reader["TestTypeDescription"];
            Test.TestTypeFees = (decimal)Reader["TestTypeFees"];

            return Test;
        }
        static public bool Find(ref stTestTypes Test)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select * from TestTypes where TestTypeID = @TestTypeID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@TestTypeID", Test.TestTypeID);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Test = _GetStTestTypes(Reader);
                    return true;
                }
                else
                    stTestTypes.Log = "Test Types not found";
            }
            catch (Exception ex) 
            {
                stTestTypes.Log = ex.Message;
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
        static public decimal GetTestTypeFees(int testTypeID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select TestTypeFees from TestTypes where TestTypeID = @TestTypeID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@TestTypeID", testTypeID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && decimal.TryParse(Result.ToString(), out decimal Fee))
                {
                    return Fee;
                }
                else
                    stTestTypes.Log = "Test Types not found";
            }
            catch (Exception ex) 
            {
                stTestTypes.Log = ex.Message;
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
        static public DataTable GetAllTestTypes()
        {
            DataTable dt = null;
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select * from TestTypes";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt = new DataTable();
                    dt.Load(Reader);
                }
                else
                    stTestTypes.Log = "Test Types is empty";
            }
            catch (Exception ex) 
            {
                stTestTypes.Log = ex.Message;
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
        static public bool Update(ref stTestTypes Test)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Update TestTypes set TestTypeTitle = @TestTypeTitle, TestTypeDescription = @TestTypeDescription, TestTypeFees = @TestTypeFees where TestTypeID = @TestTypeID";
                SqlCommand Command = new SqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("@TestTypeID", Test.TestTypeID);
                Command.Parameters.AddWithValue("@TestTypeTitle", Test.TestTypeTitle);
                Command.Parameters.AddWithValue("@TestTypeDescription", Test.TestTypeDescription);
                Command.Parameters.AddWithValue("@TestTypeFees", Test.TestTypeFees);

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
