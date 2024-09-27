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
    public struct stDriver
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        static public string Log { get; set; }
    }
    public class clsDriversData
    {
        public static bool AddNew(ref stDriver driver)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "insert into Drivers (PersonID, CreatedByUserID, CreatedDate) VALUES " +
                    "(@PersonID, @CreatedByUserID, @CreatedDate) Select SCOPE_IDENTITY()";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@PersonID", driver.PersonID);
                Command.Parameters.AddWithValue("@CreatedByUserID", driver.CreatedByUserID);
                Command.Parameters.AddWithValue("@CreatedDate", driver.CreatedDate);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    driver.DriverID = ID;
                    return true;
                }
                else
                    stDriver.Log = "Driver not Added";
            }
            catch (Exception ex)                 
            {
                stDriver.Log = ex.Message;
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
        public static bool Find(ref stDriver driver)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "SELECT * FROM  Drivers where PersonID = @PersonID or DriverID = @DriverID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@PersonID", driver.PersonID);
                Command.Parameters.AddWithValue("@DriverID", driver.DriverID);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    driver.DriverID = (int)Reader["DriverID"];
                    driver.PersonID = (int)Reader["PersonID"];
                    driver.CreatedByUserID = (int)Reader["CreatedByUserID"];
                    driver.CreatedDate = (DateTime)Reader["CreatedDate"];

                    return true;
                }
                else
                    stDriver.Log = "Driver not found";
            }
            catch (Exception ex)  
            {
                stDriver.Log = ex.Message;
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
        static public DataTable GetAllDrivers()
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            DataTable dt = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = @"SELECT Drivers.DriverID, Drivers.PersonID, People.NationalNo, People.FirstName + 
                                 (case WHEN SecondName is null then '' else ' ' + SecondName END) + 
                                 (case WHEN ThirdName is null then '' else ' ' + ThirdName END) 
                                 + ' ' + People.LastName as [Full Name], Drivers.CreatedDate, 
                                 sum(cast(Licenses.IsActive as int)) as [Active Licenses] 
                                 FROM Drivers 
                                 INNER JOIN People ON Drivers.PersonID = People.PersonID 
                                 left JOIN Licenses ON Drivers.DriverID = Licenses.DriverID 
                                 group by Drivers.DriverID, Drivers.PersonID, People.NationalNo, 
                                 People.FirstName, People.SecondName, People.ThirdName, 
                                 People.LastName, Drivers.CreatedDate";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt = new DataTable();
                    dt.Load(Reader);
                }
                else
                    stDriver.Log = "Driver not found";
            }
            catch (Exception ex) 
            {
                stDriver.Log = ex.Message;
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
    }
}
