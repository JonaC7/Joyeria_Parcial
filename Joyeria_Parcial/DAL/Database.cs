using Joyeria_Parcial.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joyeria_Parcial.DALL
{
    class Database
    {
        public static string getStrConnection()
        {
            return Settings.Default.joyeriaConnectionString;
        }

        public SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection(getStrConnection());
            return Con;
        }

        public bool testConection()
        {
            SqlConnection Con = this.getConnection();
            Con.Open();
            if (Con.State == System.Data.ConnectionState.Open)
            {
                Con.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
