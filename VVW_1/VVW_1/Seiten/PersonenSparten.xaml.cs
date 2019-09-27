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
        Datenbank.SqlSchreiben _SS = new Datenbank.SqlSchreiben();
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
                _chb.Click += _chb_Click;
                 
                wpCheckBoxenSparten.Children.Add(_chb);
                
            }


            //_chb_Fill(_chb);

        }
        
        private void _chb_Fill(object sender)
        {
            CheckBox _chk = (CheckBox)sender;
            if (_DBL._ChkSparten().Rows.Count > 0)
            {
                for (int i = 0; i < _DBL._ChkSparten().Rows.Count; i++)
                {
                    if (_chk.Name == "chk" + _DBL._ChkSparten().Rows[i][0].ToString())
                    {
                        _chk.IsChecked = true;
                    }
                }

            }

        }

        private void _chb_Click(object sender, RoutedEventArgs e)
        {
            CheckBox _chk = (CheckBox)sender;
            if (_chk.IsChecked == true)
            {
                _SS._Ins_Temp_ChekBox_Sparten(Convert.ToInt16(_chk.Name.Substring(3)));
            }
            else
            {
                _SS._Del_Temp_ChekBox_Sparten(Convert.ToInt16(_chk.Name.Substring(3)));
            }
        }

        private void _chb_Checked(object sender, RoutedEventArgs e)
        {

            CheckBox _chk = (CheckBox)sender;
            if (_DBL._ChkSparten().Rows.Count > 0)
            {
                for (int i = 0; i < _DBL._ChkSparten().Rows.Count; i++)
                {
                    if (_chk.TabIndex == Convert.ToInt16 ( _DBL._ChkSparten().Rows[i][0].ToString()))
                    {
                        //_chb.("chk" + _DBL._ChkSparten().Rows[i][0].ToString()).IsChecked = true;
                        _chk.IsChecked = true;
                    }
                }

            }



            //int _chkKlick = 0;
            //CheckBox _chk = (CheckBox)sender;
            //if (_chkKlick > 0)
            //{
            //    Globales.Sparten.GClassSparten.ChkSparten = "";
            //}
            //else if (_chk.IsChecked == true)
            //{
            //    Globales.Sparten.GClassSparten.ChkSparten += _chk.Name.Substring(3) + "|";
            //    _chkKlick ++;
            //}

        }
    
    
    }
}
