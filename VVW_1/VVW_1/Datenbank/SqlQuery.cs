using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VVW_1.Datenbank
{
    class SqlQuery
    {
        public static string _SelAnrede = "SELECT * FROM tbl_Anrede";
        Datenbank.SqlVerbindung _DBV = new SqlVerbindung();
        public SqlDataAdapter _Sparten()
        {
            SqlDataAdapter _DA = new SqlDataAdapter();
            SqlCommand _CMD = new SqlCommand("gp_Sel_SpartenInaktiv", _DBV._MsSqlVer());
            _DA.SelectCommand = _CMD;

            _CMD = new SqlCommand("gp_Upd_SpartenAktiv @spa_akt,  @spa_id", _DBV._MsSqlVer());
            _CMD.Parameters.Add("@spa_id", SqlDbType.Int, 5, "spa_id");
            _CMD.Parameters.Add("@spa_akt", SqlDbType.Bit, 1, "spa_akt");
            _DA.UpdateCommand = _CMD;

            return _DA;

        }


    }
}
