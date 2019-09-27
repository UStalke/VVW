using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace VVW_1.Globales.Sparten
{
    class GClassSparten
    {
        private static int[] _checkid = new int[1000];

        private static string _chkSparten;
        public static int[] _Chksparten { get { return _checkid; } set { _checkid = value; } }

        public static string ChkSparten { get => _chkSparten; set => _chkSparten = value; }





    }





}
