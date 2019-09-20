using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVW_1.Globales
{
    class GlobalClass
    {

        private static int _seiten_nr;
        private static string _vname;
        private static string _nname;
        private static string _strasse;
        private static string _hnr;
        private static string _plz;
        private static string _ort;
        private static string _tel;
        private static string _mobil;
        private static int _anrede;
        private static int _titel;
        private static int _geschl;
        
        public static int _SeitenNr { get => _seiten_nr; set => _seiten_nr = value; }
        public static string _Vname { get => _vname; set => _vname = value; }
        public static string _Nname { get => _nname; set => _nname = value; }
        public static string _Strasse { get => _strasse; set => _strasse = value; }
        public static string _Hnr { get => _hnr; set => _hnr = value; }
        public static string _Plz { get => _plz; set => _plz = value; }
        public static string _Ort { get => _ort; set => _ort = value; }
        public static string _Tel { get => _tel; set => _tel = value; }
        public static string _Mobil { get => _mobil; set => _mobil = value; }
        public static int _Geschl { get => _geschl; set => _geschl = value; }
        public static int _Titel { get => _titel; set => _titel = value; }
        public static int _Anrede { get => _anrede; set => _anrede = value; }
    }
}
