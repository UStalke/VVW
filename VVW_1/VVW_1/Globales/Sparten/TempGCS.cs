using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace VVW_1.Globales.Sparten
{
    class TempGCS
    {
        public DataTable _DT;

        public void _CreateDataTableChekSparten()
        {
            _DT = new DataTable();
            DataColumn _col;
            _col = new DataColumn();
            _col.DataType = System.Type.GetType("System.string");
            _col.ColumnName = "id";
            _DT.Columns.Add(_col);

            _col.DataType = System.Type.GetType("System.Int16");
            _col.ColumnName = "chk";
            _DT.Columns.Add(_col);
        }

        public void _InsertDataTablechekSparten(string _id, int _chknr)
        {
            DataRow _row;
            _row = _DT.NewRow();
            _row["id"] = _id;
            _row["chk"] = _chknr;
            _DT.Rows.Add(_row);
        }

    }
}
