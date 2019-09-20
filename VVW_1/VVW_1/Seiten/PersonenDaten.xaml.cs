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
            cboanr.ItemsSource =  _DBL._Anrede.DefaultView;
            cboanr.DisplayMemberPath = _DBL._ContVonPause().Columns[1].ToString();
            cboanr.SelectedValuePath = _DBL._ContVonPause().Columns[0].ToString();
        }
    }
}
