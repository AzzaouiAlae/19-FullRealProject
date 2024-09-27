using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;

namespace DVLD_DataAccess
{
    public struct stDetained
    {
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }
        static public string Log { get; set; }
    }
    public class clsDetainedLicensesData
    {
        static void _SetParameters(ref SqlCommand Command, stDetained Detained)
        {
            Command.Parameters.AddWithValue("@DetainID", Detained.DetainID);
            Command.Parameters.AddWithValue("@LicenseID", Detained.LicenseID);
            Command.Parameters.AddWithValue("@DetainDate", Detained.DetainDate);
            Command.Parameters.AddWithValue("@FineFees", Detained.FineFees);
            Command.Parameters.AddWithValue("@CreatedByUserID", Detained.CreatedByUserID);
            Command.Parameters.AddWithValue("@IsReleased", Detained.IsReleased);
        }
        static public bool AddNew(ref stDetained Detained)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "insert into DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased) VALUES " +
                               "(@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased) Select SCOPE_IDENTITY()";
                    
                SqlCommand Command = new SqlCommand(Query, Connection);
                _SetParameters(ref Command, Detained);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    Detained.DetainID = ID;
                    return true;
                }
                else
                    stDetained.Log = "Detain not Added";
            }
            catch (Exception ex)  
            {
                stDetained.Log = ex.Message;
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
        static public bool isLicenseDetaine(int LicenseID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select LicenseID from DetainedLicenses where LicenseID = @LicenseID and IsReleased = 0";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@LicenseID", LicenseID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)                
                    return true;                
                else
                    stDetained.Log = "Detain not Added";
            }
            catch (Exception ex) 
            {
                stDetained.Log = ex.Message;
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
        static public int FindDetaineID(int LicenseID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select DetainID from DetainedLicenses where LicenseID = @LicenseID and IsReleased = 0";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@LicenseID", LicenseID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int DetainID))
                    return DetainID;
                else
                    stDetained.Log = "Detain not Added";
            }
            catch (Exception ex) 
            {
                stDetained.Log = ex.Message;
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
            return 0;
        }
        static stDetained _GetStDetained(SqlDataReader Reader)
        {
            stDetained Detained = new stDetained();

            Detained.DetainID = (int)Reader["DetainID"];
            Detained.LicenseID = (int)Reader["LicenseID"];
            Detained.DetainDate = (DateTime)Reader["DetainDate"];
            Detained.FineFees = (decimal)Reader["FineFees"];
            Detained.CreatedByUserID = (int)Reader["CreatedByUserID"];
            Detained.IsReleased = (bool)Reader["IsReleased"];

            if (Reader["ReleaseDate"] != DBNull.Value)
                Detained.ReleaseDate = (DateTime)Reader["ReleaseDate"];

            if (Reader["ReleasedByUserID"] != DBNull.Value)
                Detained.ReleasedByUserID = (int)Reader["ReleasedByUserID"];

            if (Reader["ReleaseApplicationID"] != DBNull.Value)
                Detained.ReleaseApplicationID = (int)Reader["ReleaseApplicationID"];

            return Detained;
        }
        static public bool Find(ref stDetained Detained)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select * from DetainedLicenses where DetainID = @DetainID";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@DetainID", Detained.DetainID);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    Detained = _GetStDetained(Reader);
                    return true;
                }                
                else
                    stDetained.Log = "Detain not found";
            }
            catch (Exception ex) 
            {
                stDetained.Log = ex.Message;
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
        static public bool Update(ref stDetained Detained)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Update DetainedLicenses set IsReleased = @IsReleased, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID where DetainID = @DetainID";
                SqlCommand Command = new SqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("@DetainID", Detained.DetainID);
                Command.Parameters.AddWithValue("@IsReleased", Detained.IsReleased);
                Command.Parameters.AddWithValue("@ReleaseDate", Detained.ReleaseDate);
                Command.Parameters.AddWithValue("@ReleasedByUserID", Detained.ReleasedByUserID);
                Command.Parameters.AddWithValue("@ReleaseApplicationID", Detained.ReleaseApplicationID);

                Connection.Open();
                int Result = Command.ExecuteNonQuery();
                if (Result > 0)
                    return true;
                else
                    stDetained.Log = "Detained not Updated";
            }
            catch (Exception ex)  
            {
                stDetained.Log = ex.Message;
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
        static public DataTable GetAllDetainedLicense()
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            DataTable DT = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = @"SELECT DetainedLicenses.DetainID as [D.ID], DetainedLicenses.LicenseID as [L.ID], 
                                 DetainedLicenses.DetainDate as [D.Date], DetainedLicenses.IsReleased as [Is Released], 
                                 DetainedLicenses.FineFees as [Fine Fees], DetainedLicenses.ReleaseDate as [Release Date], 
                                 People.NationalNo as [N.No], People.FirstName + (case WHEN SecondName is null then '' else ' ' + SecondName END) + 
                                 (case WHEN ThirdName is null then '' else ' ' + ThirdName END) + ' ' + People.LastName as [Full Name], 
                                 DetainedLicenses.ReleaseApplicationID as [Release App.ID] 
                                 FROM DetainedLicenses 
                                 INNER JOIN Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID
                                 INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID 
                                 INNER JOIN People ON Drivers.PersonID = People.PersonID";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    DT = new DataTable();
                    DT.Load(Reader);
                }
                else
                    stDetained.Log = "Detain not Added";
            }
            catch (Exception ex)  
            {
                stDetained.Log = ex.Message;
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
            return DT;
        }
        static public bool IsRelease(int DetainID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select IsReleased from DetainedLicenses where DetainID = @DetainID";

                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@DetainID", DetainID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)                
                    return (bool)Result;
                
                else
                    stDetained.Log = "Detain not found";
            }
            catch (Exception ex)  
            {
                stDetained.Log = ex.Message;
                string sourceName = "DVLD";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
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
