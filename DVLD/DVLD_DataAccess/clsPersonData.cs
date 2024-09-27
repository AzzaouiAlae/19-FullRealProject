using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public struct stPerson
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        static public string Log { get; set; }
    }
    public class clsPersonData
    {
        static public DataTable GetAllPeople()
        {
            DataTable dt = null;
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select People.PersonID,People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, " +
                    "case WHEN People.Gendor = 0 THEN 'Male' ELSE 'Female' END as Gender, People.DateOfBirth, Countries.CountryName as Nationality, " +
                    "People.Phone, People.Email from People inner join Countries on People.NationalityCountryID = CountryID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt = new DataTable();
                    dt.Load(Reader);
                } 
                else
                    stPerson.Log = "People is empty";
            }
            catch (Exception ex) 
            {
                stPerson.Log = ex.Message;
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
        static string _SetQuery(stPerson person)
        {
            string Query = "Select * from People ";
            if (person.PersonID != -1)
                Query += " Where PersonID = @PersonID";

            else if(person.NationalNo != "?")
                Query += " Where NationalNo = @NationalNo";

            return Query;
        }
        static void _SetParameters(ref SqlCommand Command, stPerson person)
        {
            Command.Parameters.AddWithValue("@PersonID", person.PersonID);
            Command.Parameters.AddWithValue("@NationalNo", person.NationalNo);
            Command.Parameters.AddWithValue("@FirstName", person.FirstName);

            if (string.IsNullOrEmpty(person.SecondName))
                Command.Parameters.AddWithValue("@SecondName", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@SecondName", person.SecondName);

            if (string.IsNullOrEmpty(person.ThirdName))
                Command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ThirdName", person.ThirdName);

            Command.Parameters.AddWithValue("@LastName", person.LastName);
            Command.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", person.Gendor);
            Command.Parameters.AddWithValue("@Address", person.Address);
            Command.Parameters.AddWithValue("@Phone", person.Phone);

            if (person.Email == null)
                Command.Parameters.AddWithValue("@Email", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Email", person.Email);

            Command.Parameters.AddWithValue("@NationalityCountryID", person.NationalityCountryID);

            if(person.ImagePath == null)
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ImagePath", person.ImagePath);
        }
        static stPerson _GetStPerson(SqlDataReader Reader)
        {
            stPerson Person = new stPerson();

            Person.PersonID = (int)Reader["PersonID"];
            Person.NationalNo = (string)Reader["NationalNo"];
            Person.FirstName = (string)Reader["FirstName"];
            if (Reader["SecondName"] != DBNull.Value)
                Person.SecondName = (string)Reader["SecondName"];
            else
                Person.SecondName = "";

            if (Reader["ThirdName"] != DBNull.Value)
                Person.ThirdName = (string)Reader["ThirdName"];
            else
                Person.ThirdName = "";

            Person.LastName = (string)Reader["LastName"];
            Person.DateOfBirth = (DateTime)Reader["DateOfBirth"];

            Person.Gendor = (bool)Reader["Gendor"];
            Person.Address = (string)Reader["Address"];
            Person.Phone = (string)Reader["Phone"];

            if (Reader["Email"] != DBNull.Value)
                Person.Email = (string)Reader["Email"];
            else
                Person.Email = "";

            Person.NationalityCountryID = (int)Reader["NationalityCountryID"];

            if (Reader["ImagePath"] != DBNull.Value)
                Person.ImagePath = (string)Reader["ImagePath"];
            else
                Person.ImagePath = "";

            return Person;
        }
        static public bool Find(ref stPerson person)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = _SetQuery(person);
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@PersonID", person.PersonID);
                Command.Parameters.AddWithValue("@NationalNo", person.NationalNo);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    person = _GetStPerson(Reader);
                    return true;
                }
                else
                    stPerson.Log = "Person not found";
            }
            catch (Exception ex) 
            {
                stPerson.Log = ex.Message;
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
        static public bool AddNew(ref stPerson person)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "insert into People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, " +
                    "Phone, Email, NationalityCountryID, ImagePath) VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, " +
                    "@DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath) Select SCOPE_IDENTITY()";
                SqlCommand Command = new SqlCommand(Query, Connection);
                _SetParameters(ref Command, person);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    person.PersonID = ID;
                    return true;
                }
                else
                    stPerson.Log = "Person not Added";
            }
            catch (Exception ex) 
            {
                stPerson.Log = ex.Message;
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
        static public bool Update(ref stPerson person)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Update People set NationalNo = @NationalNo, FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName," +
                    "LastName = @LastName, DateOfBirth = @DateOfBirth, Gendor = @Gendor, Address = @Address, Phone = @Phone, Email = @Email," +
                    "NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath where PersonID = @PersonID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                _SetParameters(ref Command, person);
                Connection.Open();
                int Result = Command.ExecuteNonQuery();
                if (Result > 0)                
                    return true;                
                else
                    stPerson.Log = "Person not Updated";
            }
            catch (Exception ex) 
            {
                stPerson.Log = ex.Message;
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
        static public bool Delete(int PersonID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Delete from People where PersonID = @PersonID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@PersonID", PersonID);
                //_SetParameters(ref Command, person);
                Connection.Open();
                int Result = Command.ExecuteNonQuery();
                if (Result > 0)
                    return true;
                else
                    stPerson.Log = "Person not Deleted";
            }
            catch (Exception ex) 
            {
                stPerson.Log = ex.Message;
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
        static public bool IsPersonExist(int ID, string nationalNo)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select PersonID from People where PersonID = @PersonID or NationalNo = @NationalNo";
                SqlCommand Command = new SqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("@PersonID", ID);
                Command.Parameters.AddWithValue("@NationalNo", nationalNo);

                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)                
                    return true;                
                else
                    stPerson.Log = "Person not found";
            }
            catch (Exception ex) 
            {
                stPerson.Log = ex.Message;
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
        static public string GetFullNameByID(int ID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = @"Select FirstName + 
                                 (case WHEN SecondName is null then '' else ' ' + SecondName END) + 
                                 (case WHEN ThirdName is null then '' else ' ' + ThirdName END) + 
                                 ' ' + LastName as FullName 
                                 from People where PersonID = @ID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@ID", ID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    return (string)Result;
                }
                else
                    stPerson.Log = "Person not found";
            }
            catch (Exception ex) 
            {
                stPerson.Log = ex.Message;
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
    }
}
