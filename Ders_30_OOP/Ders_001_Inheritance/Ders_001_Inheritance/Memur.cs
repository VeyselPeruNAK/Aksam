using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_001_Inheritance
{
    class Memur : Insan
    {
        public int Maasi { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        private string _MyVar;
        public string MyVar
        {
            get { return _MyVar; }
            set { _MyVar = value; }
        }

        public string MyVar2 { get; set; }




    }
}
