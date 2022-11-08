using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Lab1
{
    public class DatabaseConnection
    {
        private static SqlConnection _SqlConnection;
        private static string constr = @"server=(localdb)\mssqllocaldb;Database=Nortwind;Trusted_Connection=true";

        //Cunstructer private olarak isaretlenir ki instance alinamasin.
        private DatabaseConnection()
        {

        }

        //Metodlu Singleton
        public static SqlConnection GetConnection()
        {
            if (_SqlConnection == null)
            {
                _SqlConnection = new SqlConnection(constr);
            }
            return _SqlConnection;
        }
    }
}
