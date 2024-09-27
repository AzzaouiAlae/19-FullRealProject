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
    public struct stCountries
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public static string Log {  get; set; }
    }
    public class clsCountriesData
    {
        static public List<string> GetAllCountries()
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            List <string> Countries = new List <string>();
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select * from Countries";
                SqlCommand Command = new SqlCommand(Query, Connection);                
                Connection.Open();
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Countries.Add((string)Reader["CountryName"]);
                }
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
            return Countries;
        }
        static public bool Find(ref stCountries Countrie)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select * from Countries Where CountryID = @CountryID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@CountryID", Countrie.CountryID);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Countrie.CountryName = (string)Reader["CountryName"];
                    return true;
                }
                else
                    stCountries.Log = "Countrie not found";
            }
            catch (Exception ex) 
            {
                stCountries.Log = ex.Message;
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
    }
}
