using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVW_1.Globales
{
    class CreateGUID
    {
        public void _GUID()
        {   
            
            GlobalClass._Sessionid = Guid.NewGuid().ToString();
            
            
        }


    }
}
