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
using System.Windows.Shapes;
using VVW_1.Seiten;
using System.Windows.Threading;


namespace VVW_1.Fenster
{
    /// <summary>
    /// Interaktionslogik für Master.xaml
    /// </summary>
    public partial class Master : Window
    {
        public Master()
        {
            InitializeComponent();
            frmSeiten.Source = new Uri("/Seiten/PersonenDaten.xaml", UriKind.RelativeOrAbsolute);
            Globales.GlobalClass._SeitenNr = 1;
            _Aktualisieren();
                
        }

        private void BtnVor_Click(object sender, RoutedEventArgs e)
        {
            Datenbank.SqlLesen _DBL = new Datenbank.SqlLesen();
            //_DBL._ContVonPause();

            switch (Globales.GlobalClass._SeitenNr)
            {
                case 1:
                    frmSeiten.Source = new Uri("/Seiten/PersonenSparten.xaml", UriKind.RelativeOrAbsolute);
                    Globales.GlobalClass._SeitenNr = 2;
                    btnVorgaenger.IsEnabled = true;
                    break;
                case 2:
                    frmSeiten.Source = new Uri("/Seiten/PersonenBank.xaml", UriKind.RelativeOrAbsolute);
                    Globales.GlobalClass._SeitenNr = 3;
                    break;
                case 3:
                    frmSeiten.Source = new Uri("/Seiten/PersonenAnsicht.xaml", UriKind.RelativeOrAbsolute);
                    Globales.GlobalClass._SeitenNr = 4;
                    btnVor.Content = "Speichern";
                    break;
                case 4:
                    MessageBox.Show("Jetzt wird gespeichert");
                    break;
            }
        }

        private void BtnVorgaenger_Click(object sender, RoutedEventArgs e)
        {
            switch (Globales.GlobalClass._SeitenNr)
            {
                case 4:
                    frmSeiten.Source = new Uri("/Seiten/PersonenBank.xaml", UriKind.RelativeOrAbsolute);
                    Globales.GlobalClass._SeitenNr = 3;
                    btnVor.Content = "weiter >> ";
                    break;

                case 3:
                    frmSeiten.Source = new Uri("/Seiten/PersonenSparten.xaml", UriKind.RelativeOrAbsolute);
                    Globales.GlobalClass._SeitenNr = 2;
                    break;
                case 2:
                    frmSeiten.Source = new Uri("/Seiten/PersonenDaten.xaml", UriKind.RelativeOrAbsolute);
                    Globales.GlobalClass._SeitenNr = 1;
                    btnVorgaenger.IsEnabled = false;
                    break;
                
            }
        }
        DispatcherTimer _t = new DispatcherTimer();
        public void _Aktualisieren()
        {
            _t.Interval = new TimeSpan(60000);
            _t.Tick += t_Tick;
            _t.Start();
        }
        public void t_Tick(object sender, EventArgs e)
        {
            lblNameMitgl.Content = "Erfasst wird: " + Globales.GlobalClass._Vname + " " + Globales.GlobalClass._Nname;
        }
    }
}
