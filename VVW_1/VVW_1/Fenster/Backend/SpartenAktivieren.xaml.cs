using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VVW_1.Fenster.Backend
{
    /// <summary>
    /// Interaktionslogik für SpartenAktivieren.xaml
    /// </summary>
    public partial class SpartenAktivieren : Window
    {
        public SpartenAktivieren()
        {
            InitializeComponent();
            _FilldgSparten();
            _FilldgSpartenAktiv();
        }

        Datenbank.SqlVerbindung _CO = new Datenbank.SqlVerbindung();
        Datenbank.SqlQuery _DBQ = new Datenbank.SqlQuery();
        Datenbank.SqlLesen _SL = new Datenbank.SqlLesen();
        SqlDataAdapter _DA;
        DataSet _DS ;
        
        private void _FilldgSparten()
        {
                    
            _DS = new DataSet();
            _DBQ._Sparten().Fill(_DS);
            dgSpartenInaktive.ItemsSource = _DS.Tables[0].AsDataView();// _SL._SpartenInaktiv().DefaultView;
        }


        private void btnUebernehmen_Click(object sender, RoutedEventArgs e)
        {
            _DBQ._Sparten().Update(_DS);
            _FilldgSpartenAktiv();
        }

        private void _FilldgSpartenAktiv()
        {
           SqlDataAdapter _DA1 = new SqlDataAdapter("gp_Sel_SpartenAktiv", _CO._MsSqlVer());
            DataTable _DT1 = new DataTable();
            _DA1.Fill(_DT1);
            dgSpartenAktive.ItemsSource = _DT1.DefaultView;
        }


    }
}
