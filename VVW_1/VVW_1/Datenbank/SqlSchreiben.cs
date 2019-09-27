using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace VVW_1.Datenbank
{
    class SqlSchreiben
    {
        Datenbank.SqlVerbindung _SV = new SqlVerbindung();

        public void _Ins_Temp_ChekBox_Sparten( int _chknr )
        {
            SqlCommand _CMD = new SqlCommand();
            _CMD.Connection = _SV._MsSqlVer();
            _CMD.CommandType = System.Data.CommandType.StoredProcedure;
            _CMD.CommandText = "gp_Ins_ChkSparten";
            _CMD.Parameters.AddWithValue("@guid", Globales.GlobalClass._Sessionid);
            _CMD.Parameters.AddWithValue("@chk", _chknr);
            _CMD.Connection.Open();
            _CMD.ExecuteNonQuery();
            _CMD.Connection.Close();

        }

        public void _Del_Temp_ChekBox_Sparten(int _chknr)
        {
            SqlCommand _CMD = new SqlCommand();
            _CMD.Connection = _SV._MsSqlVer();
            _CMD.CommandType = System.Data.CommandType.StoredProcedure;
            _CMD.CommandText = "gp_Del_ChekSparten";
            _CMD.Parameters.AddWithValue("@guid", Globales.GlobalClass._Sessionid);
            _CMD.Parameters.AddWithValue("@chk", _chknr);
            _CMD.Connection.Open();
            _CMD.ExecuteNonQuery();
            _CMD.Connection.Close();
        }

    }
}
