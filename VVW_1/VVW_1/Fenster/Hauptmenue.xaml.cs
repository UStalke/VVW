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

namespace VVW_1.Fenster
{
    /// <summary>
    /// Interaktionslogik für Hauptmenue.xaml
    /// </summary>
    public partial class Hauptmenue : Window
    {
        public Hauptmenue()
        {
            InitializeComponent();
        }

        private void btnKonfSparten_Click(object sender, RoutedEventArgs e)
        {
            Fenster.Backend.SpartenAktivieren _Spa = new Backend.SpartenAktivieren();
            _Spa.ShowDialog();
        }

        private void btnMitgliedNeu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
