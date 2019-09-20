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
using VVW_1.Seiten;

namespace VVW_1.Seiten
{
    /// <summary>
    /// Interaktionslogik für PersonenDaten.xaml
    /// </summary>
    public partial class PersonenDaten : Page
    {
        public PersonenDaten()
        {
            InitializeComponent();
            _FillCBO();
        }


        public void _FillCBO()
        {
            Datenbank.SqlLesen _DBL = new Datenbank.SqlLesen();
            cboanr.ItemsSource =  _DBL._Anrede().DefaultView;
            cboanr.DisplayMemberPath = _DBL._Anrede().Columns[1].ToString();
            cboanr.SelectedValuePath = _DBL._Anrede().Columns[0].ToString();
            cboanr.SelectedIndex = 0;

            cbogeschl.ItemsSource = _DBL._Geschlecht().DefaultView;
            cbogeschl.DisplayMemberPath = _DBL._Geschlecht().Columns[1].ToString();
            cbogeschl.SelectedValuePath = _DBL._Geschlecht().Columns[0].ToString();
            cbogeschl.SelectedIndex = 0;

            cbotil.ItemsSource = _DBL._Titel().DefaultView;
            cbotil.DisplayMemberPath = _DBL._Titel().Columns[1].ToString();
            cbotil.SelectedValuePath = _DBL._Titel().Columns[0].ToString();
            cbotil.SelectedIndex = 0;
            



        }

        private void _ChangedInGlobalClassCBO(object sender, SelectionChangedEventArgs e)
        {
            if (cboanr.SelectedIndex >= 0) { Globales.GlobalClass._Anrede = Convert.ToInt16(cboanr.SelectedValue.ToString()); }
            if (cbotil.SelectedIndex >= 0 ){Globales.GlobalClass._Titel = Convert.ToInt16(cbotil.SelectedValue.ToString());}
            if (cbogeschl.SelectedIndex >= 0) { Globales.GlobalClass._Geschl = Convert.ToInt16(cbogeschl.SelectedValue.ToString()); }
        }

        private void _ChangedInGlobalClassTXT(object sender, RoutedEventArgs e)
        {
            if (txtvname.Text.Length > 0) { Globales.GlobalClass._Vname = txtvname.Text; }
            if (txtnname.Text.Length > 0) { Globales.GlobalClass._Nname = txtnname.Text; }
            Globales.GlobalClass._Strasse = txtstrasse.Text;
            Globales.GlobalClass._Hnr = txthnr.Text;
            Globales.GlobalClass._Plz = txtplz.Text;
            Globales.GlobalClass._Ort = txtort.Text;
            Globales.GlobalClass._Tel = txttel.Text;
            Globales.GlobalClass._Mobil = txtmobil.Text;
        }
    }
}
