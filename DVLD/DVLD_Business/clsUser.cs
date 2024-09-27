using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsUser
    {
        enum enMode { enAddNew, enUpdate }
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        static public string Log { get; set; }
        enMode Mode { get; set; }
        public clsUser()
        {
            UserID = -1;
            PersonID = -1;
            UserName = "?";
            Password = "?";
            IsActive = false;
            Log = "";
            Mode = enMode.enAddNew;
        }
        clsUser(stUser User)
        {
            UserID = User.UserID;
            PersonID = User.PersonID;
            UserName = User.UserName;
            Password = User.Password;
            IsActive = User.IsActive;
            Mode = enMode.enUpdate;
        }
        static public DataTable GetAllUsers()
        {
            DataTable dt = clsUserData.GetAllUsers();
            Log = stUser.Log;
            return dt;
        }
        static stUser _ConvertObjToStUser(clsUser User)
        {
            stUser user = new stUser();

            user.UserID = User.UserID;
            user.PersonID = User.PersonID;
            user.UserName = User.UserName;
            user.Password = User.Password;
            user.IsActive = User.IsActive;            
            stUser.Log = Log;

            return user;
        }
        static clsUser Find(clsUser User)
        {
            stUser user = _ConvertObjToStUser(User);

            if (clsUserData.Find(ref user))
                return new clsUser(user);
            
            Log = stUser.Log;
            return null;
        }
        static public clsUser FindByID(int ID)
        {
            clsUser User = new clsUser();
            User.UserID = ID;

            return Find(User);
        }
        static public clsUser FindByUserName(string UserName)
        {
            clsUser User = new clsUser();
            User.UserName = UserName;

            return Find(User);
        }
        static public bool isPersonHasUser(int PersonID)
        {
            return clsUserData.isPersonHasUser(PersonID);
        }
        bool _AddNew()
        {
            stUser u = _ConvertObjToStUser(this);
            if(clsUserData.AddNew(ref u))
            {
                UserID = u.UserID;
                return true;
            }
            Log = stUser.Log;
            return false;
        }
        bool _Update()
        {
            stUser u = _ConvertObjToStUser(this);
            if (clsUserData.Update(ref u))
            {
                return true;
            }            
            Log = stUser.Log;
            return false;
        }
        static public bool Delete(int ID)
        {
            if(clsUserData.Delete(ID))
                return true;

            else
            {
                Log = stUser.Log;
                return false;
            }
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.enAddNew: return _AddNew();
                case enMode.enUpdate: return _Update();
            }
            return false;
        }
        static public int Login(string Username, string Password)
        {
            clsUser User = FindByUserName(Username);
            if (User == null) return -1;
            if (User.UserID == -1) return -1;
            if (!(User.Password == Password)) return -1;
            if (User.IsActive) return User.UserID;
            return -1;
        }
        static public string GetUsernameByID(int ID)
        {
            string username = clsUserData.GetUsernameByID(ID);
            Log = stUser.Log;
            return username;
        }
        static public bool isUserNameExist(string Username)
        {
            bool Result = clsUserData.isUserNameExist(Username);
            Log = stUser.Log;
            return Result;
        }
        static public bool isPasswordCorrect(int UserID, string Password)
        {
            bool Result = clsUserData.isPasswordCorrect(UserID, Password);
            Log = stUser.Log;
            return Result;
        }
        static public bool ChangePassword(int UserID, string NewPassword, string OldPassword)
        {
            clsUser User = FindByID(UserID);
            if(User != null && User.Password == OldPassword) 
            { 
                User.Password = NewPassword;
                if (User.Save())                
                    return true;                
            }
            return false;
        }
        public static string AppPath
        {
            get => DataAccessSetting.AppPath;
            set => DataAccessSetting.AppPath = value;
        }
    }
}
