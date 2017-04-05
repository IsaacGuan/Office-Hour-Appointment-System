using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 答疑预约系统
{
    class dbConnection
    {
        public static string connection {
            get {
                return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=qasystem.mdb";
            }
        }
    }
}
