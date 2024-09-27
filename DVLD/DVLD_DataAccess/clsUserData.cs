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
    public struct stUser
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        static public string Log { get; set; }
    }
    public class clsUserData
    {
        public static DataTable GetAllUsers()
        {
            DataTable dt = null;
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = @"SELECT Users.UserID as 'User ID', Users.PersonID as 'Person ID', FirstName + 
                                 (case WHEN SecondName is null then '' else ' ' + SecondName END) + 
                                 (case WHEN ThirdName is null then '' else ' ' + ThirdName END) +
                                 ' ' + People.LastName as 'Full Name',Users.UserName,
                                 'Is Active' = 
                                    case 
                                        WHEN Users.IsActive = 1 then 'True' 
                                        else 'False' 
                                    END 
                                 FROM Users 
                                 INNER JOIN People ON Users.PersonID = People.PersonID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt = new DataTable();
                    dt.Load(Reader);
                }
                else
                    stUser.Log = "Users is empty";
            }
            catch (Exception ex) 
            {
                stUser.Log = ex.Message;
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
        static string _SetQuery(stUser User)
        {
            string Query = "Select * from Users";
            if (User.PersonID != -1)
                Query += " Where PersonID = @PersonID";

            else if (User.UserID != -1)
                Query += " Where UserID = @UserID";

            else if (User.UserName != "?")
                Query += " Where UserName = @UserName";

            return Query;
        }
        static void _SetParameters(ref SqlCommand Command, stUser User)
        {
            Command.Parameters.AddWithValue("@UserID", User.UserID);
            Command.Parameters.AddWithValue("@PersonID", User.PersonID);
            Command.Parameters.AddWithValue("@UserName", User.UserName);
            Command.Parameters.AddWithValue("@Password", User.Password);
            Command.Parameters.AddWithValue("@IsActive", User.IsActive);
        }
        static stUser _GetStUser(SqlDataReader Reader)
        {
            stUser User = new stUser();

            User.UserID = (int)Reader["UserID"];
            User.PersonID = (int)Reader["PersonID"];
            User.UserName = (string)Reader["UserName"];
            User.Password = (string)Reader["Password"];
            User.IsActive = (bool)Reader["IsActive"];

            return User;
        }
        static public bool Find(ref stUser User)
        {
            SqlConnection Connection = null;
            SqlDataReader Reader = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = _SetQuery(User);
                SqlCommand Command = new SqlCommand(Query, Connection);
                _SetParameters(ref Command, User);
                Connection.Open();
                Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    User = _GetStUser(Reader);
                    return true;
                }
                else
                    stUser.Log = "User not found";
            }
            catch (Exception ex) 
            {
                stUser.Log = ex.Message;
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
        static public bool AddNew(ref stUser User)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "insert into Users (PersonID, UserName, Password, IsActive) VALUES " +
                    "(@PersonID, @UserName, @Password, @IsActive) Select SCOPE_IDENTITY()";                    
                SqlCommand Command = new SqlCommand(Query, Connection);
                _SetParameters(ref Command, User);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    User.UserID = ID;
                    return true;
                }
                else
                    stUser.Log = "User not Added";
            }
            catch (Exception ex) 
            {
                stUser.Log = ex.Message;
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
        static public bool Update(ref stUser User)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Update Users set PersonID = @PersonID, UserName = @UserName, Password = @Password, IsActive = @IsActive where UserID = @UserID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                _SetParameters(ref Command, User);
                Connection.Open();
                int Result = Command.ExecuteNonQuery();
                if (Result > 0)
                    return true;
                else
                    stUser.Log = "User not Updated";
            }
            catch (Exception ex) 
            {
                stUser.Log = ex.Message;
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
        static public bool Delete(int ID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Delete from Users where UserID = @UserID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@UserID", ID);
                Connection.Open();
                int Result = Command.ExecuteNonQuery();
                if (Result > 0)
                    return true;
                else
                    stUser.Log = "User not Deleted";
            }
            catch (Exception ex) 
            {
                stUser.Log = ex.Message;
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
        static public bool isPersonHasUser(int PersonID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select UserID from Users Where PersonID = @PersonID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@PersonID", PersonID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    return true;
                }
                else
                    stUser.Log = "User not found";
            }
            catch (Exception ex) 
            {
                stUser.Log = ex.Message;
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
        static public string GetUsernameByID(int ID)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select UserName from Users where UserID = @UserID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@UserID", ID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)                
                    return (string)Result;
                
                else
                    stUser.Log = "User not found";
            }
            catch (Exception ex) 
            {
                stUser.Log = ex.Message;
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
        static public bool isUserNameExist(string Username)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select UserID from Users Where UserName = @UserName";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@UserName", Username);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    return true;
                }
                else
                    stUser.Log = "User not found";
            }
            catch (Exception ex) 
            {
                stUser.Log = ex.Message;
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
        static public bool isPasswordCorrect(int UserID, string Password)
        {
            SqlConnection Connection = null;
            try
            {
                Connection = new SqlConnection(DataAccessSetting.ConnectionString);
                string Query = "Select Password from Users Where UserID = @UserID";
                SqlCommand Command = new SqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@UserID", UserID);
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    return Result.ToString() == Password ? true : false;
                }
                else
                    stUser.Log = "User not found";
            }
            catch (Exception ex) 
            {
                stUser.Log = ex.Message;
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
