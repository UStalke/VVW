using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VVW_1.Seiten
{
    /// <summary>
    /// Interaktionslogik für PersonenSparten.xaml
    /// </summary>
    public partial class PersonenSparten : Page
    {
        public PersonenSparten()
        {
            InitializeComponent();
            _SpartenUe();
        }
        Datenbank.SqlLesen _DBL = new Datenbank.SqlLesen();
        CheckBox _chb;
        public void _SpartenUe()
        {
            


            for (int i = 0; i < _DBL._Sparten().Rows.Count; i++)
            {
                _chb = new CheckBox();
                _chb.Name = "chb" + _DBL._Sparten().Rows[i][0].ToString();
                _chb.TabIndex = Convert.ToInt16(_DBL._Sparten().Rows[i][0].ToString());
                _chb.Content = _DBL._Sparten().Rows[i][1].ToString();
                _chb.Margin = new Thickness(5);
                _chb.Checked += _chb_Checked;
                wpCheckBoxenSparten.Children.Add(_chb);

            }


        }

        private void _chb_Checked(object sender, RoutedEventArgs e)
        {
            int _chkKlick = 0;
            CheckBox _chk = (CheckBox)sender;
            if (_chkKlick > 0)
            {
                Globales.Sparten.GClassSparten.ChkSparten = "";
            }
            else if (_chk.IsChecked == true)
            {
                Globales.Sparten.GClassSparten.ChkSparten += _chk.Name.Substring(3) + "|";
                _chkKlick ++;
            }

        }
    
    
    }
}
