using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace VVW_1.Datenbank
{
    class SqlVerbindung
    {
        public MySqlConnection _Verbindung()
        {
            return new MySqlConnection(ConfigurationManager.ConnectionStrings["MyCon"].ToString());
        }

        public SqlConnection _MsSqlVer()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["MsSqlServer"].ToString());
        }

    }
}
