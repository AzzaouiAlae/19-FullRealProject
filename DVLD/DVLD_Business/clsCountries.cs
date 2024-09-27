using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsCountries
    {
        int _CountryID = -1;
        public int CountryID 
        {   get { return _CountryID; }
            set 
            { 
                FindCountrie(value);
            }
        }
        public string CountryName { get; private set; }
        protected void FindCountrie(int ID)
        {
            stCountries c = new stCountries();
            c.CountryID = ID;
            if(clsCountriesData.Find(ref c))
            {
                _CountryID = c.CountryID;
                CountryName = c.CountryName;
            }
        }
        public static List<string> GetAllCountries()
        {
            return clsCountriesData.GetAllCountries();
        }
    }
}
