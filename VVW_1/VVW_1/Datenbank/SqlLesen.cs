using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace VVW_1.Datenbank
{
    class SqlLesen
    {
         
        Datenbank.SqlVerbindung _CO = new SqlVerbindung();
        
            public DataTable _ContVonPause()
            {
            //MySqlCommand _Cmd = new MySqlCommand();
            //_Cmd.Connection = _CO._Verbindung();
            //_Cmd.CommandText = "gp_Sel_Anrede";
            //_Cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter _DA = new MySqlDataAdapter("gp_Sel_Anrede", _CO._Verbindung());
           // _DA.SelectCommand = _Cmd;
             DataTable _DT = new DataTable();
            _DA.Fill(_DT);
            return _DT;
             }

        public DataTable _Anrede()
        {
            SqlDataAdapter _DA = new SqlDataAdapter("gp_Sel_Anrede", _CO._MsSqlVer());
            DataTable _DT = new DataTable();
            _DA.Fill(_DT);
            return _DT;
        }

        public DataTable _Geschlecht()
        {
            SqlDataAdapter _DA = new SqlDataAdapter("gp_Sel_Geschl", _CO._MsSqlVer());
            DataTable _DT = new DataTable();
            _DA.Fill(_DT);
            return _DT;
        }

        public DataTable _Titel()
        {
            SqlDataAdapter _DA = new SqlDataAdapter("gp_Sel_Titel", _CO._MsSqlVer());
            DataTable _DT = new DataTable();
            _DA.Fill(_DT);
            return _DT;
        }

    }
}
