using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DVLD_DataAccess
{
    public class DataAccessSetting
    {
        //static public string ConnectionString = "Server=.;Database=DVLD;User Id=alae;Password=a;";
        static string _AppPath = "";
        public static string AppPath
        {
            get => _AppPath;
            set
            {
                _AppPath = value;
                ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"{_AppPath}\\Database1.mdf\";Integrated Security=True";
            }
        }

        static public string ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"{AppPath}\\Database1.mdf\";Integrated Security=True";
    }
}
