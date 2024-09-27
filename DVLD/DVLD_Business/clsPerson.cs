using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsPerson : clsCountries
    {
        int _PersonID;
        public int PersonID { 
            get { return _PersonID; } 
            set {
            { 
                if(_PersonID != value)
                {
                    Find(value);
                }
            } }
        }
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
        public string ImagePath { get; set; }
        enum enMode { enAddNew, enUpdate }
        static public string Log { get; set; }
        enMode Mode { get; set; }
        public string FullName()
        {
            string s = FirstName;

            if (!string.IsNullOrEmpty(SecondName))
                s += " " + SecondName;
            if (!string.IsNullOrEmpty(ThirdName))
                s += " " + ThirdName;
            s += " " + LastName;

            return s;
        }
        public clsPerson()
        {
            Mode = enMode.enAddNew;
        }
        protected clsPerson(int PersonID)
        {
            Find(PersonID);
        }
        clsPerson(stPerson Person)
        {
            _PersonID = Person.PersonID;
            NationalNo = Person.NationalNo;
            FirstName = Person.FirstName;
            SecondName = Person.SecondName;
            ThirdName = Person.ThirdName;
            LastName = Person.LastName;
            DateOfBirth = Person.DateOfBirth;
            Gendor = Person.Gendor;
            Address = Person.Address;
            Phone = Person.Phone;
            Email = Person.Email;
            CountryID = Person.NationalityCountryID;
            ImagePath = Person.ImagePath;
            Log = stPerson.Log;
            Mode = enMode.enUpdate;
        }
        static stPerson _ConvertObjToStPerson(clsPerson Person)
        {
            stPerson p = new stPerson();
            
            p.PersonID = Person.PersonID;
            p.NationalNo = Person.NationalNo;
            p.FirstName = Person.FirstName;
            p.SecondName = Person.SecondName;
            p.ThirdName = Person.ThirdName;
            p.LastName = Person.LastName;
            p.DateOfBirth = Person.DateOfBirth;
            p.Gendor = Person.Gendor;
            p.Address = Person.Address;
            p.Phone = Person.Phone;
            p.Email = Person.Email;
            p.NationalityCountryID = Person.CountryID;
            p.ImagePath = Person.ImagePath;
            stPerson.Log = Log;

            return p;
        }
        static public DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }        
        static public clsPerson FindPerson(int PersonID)
        {
            stPerson Person = new stPerson();
            Person.PersonID = PersonID;
            Person.NationalNo = "?";

            if (clsPersonData.Find(ref Person))            
                return new clsPerson(Person);                
            
            Log = stPerson.Log;
            return null;
        }
        static public clsPerson FindPerson(string nationalNo)
        {
            stPerson Person = new stPerson();
            Person.PersonID = -1;
            Person.NationalNo = nationalNo;

            if (clsPersonData.Find(ref Person))            
                return new clsPerson(Person);
            
            Log = stPerson.Log;
            return null;
        }
        static public bool IsPersonExist(string nationalNo)
        {
            if (clsPersonData.IsPersonExist(-1, nationalNo))
                return true;
            else
                return false;
        }
        void _SetPersonData(stPerson Person)
        {
            _PersonID = Person.PersonID;
            NationalNo = Person.NationalNo;
            FirstName = Person.FirstName;
            SecondName = Person.SecondName;
            ThirdName = Person.ThirdName;
            LastName = Person.LastName;
            DateOfBirth = Person.DateOfBirth;
            Gendor = Person.Gendor;
            Address = Person.Address;
            Phone = Person.Phone;
            Email = Person.Email;
            CountryID = Person.NationalityCountryID;
            ImagePath = Person.ImagePath;
            Log = stPerson.Log;
            Mode = enMode.enUpdate;
        }
        bool _AddNew()
        {
            stPerson P = _ConvertObjToStPerson(this);
            if(clsPersonData.AddNew(ref P))
            {
                _PersonID = P.PersonID;
                return true;
            }
            Log = stPerson.Log;
            return false;
        }
        bool _Update()
        {
            stPerson P = _ConvertObjToStPerson(this);

            if (clsPersonData.Update(ref P))
            {
                return true;
            }
                
            
            Log = stPerson.Log;
            return false;
        }
        static public bool Delete(int PersonID)
        {
            if(clsPersonData.Delete(PersonID))
                return true;
            
            Log = stPerson.Log;
            return false;            
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.enAddNew:
                    return _AddNew();
                case enMode.enUpdate:
                    return _Update();
            }
            return false;
        }
        void Find(int PersonID)
        {
            stPerson Person = new stPerson();
            Person.PersonID = PersonID;
            Person.NationalNo = "?";

            if (clsPersonData.Find(ref Person))
            {
                _SetPersonData(Person);
            }
            Log = stPerson.Log;
        }
        static public string GetFullNameByID(int PersonID)
        {
            return clsPersonData.GetFullNameByID(PersonID);
        }
    }
}
