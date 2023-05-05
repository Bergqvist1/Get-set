using System;
using Get_set;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_set
{
    class Minklass
    {

        private string mc;


        public string Mc
        {
            get { return mc; }
            set { mc = value; }
        }

    }

    class Bil
    {
        private string bilmärke;
        private int årsmodell;
        private string modell;

        public Bil(string b, int å, string m)
        {
            bilmärke = b;
            årsmodell = å;
            modell = m;
        }

        public string b
        {
            get { return bilmärke;}
            set { bilmärke = value; }
        }

        public int å
        {
            get { return årsmodell; }
            set { årsmodell = value; }
        }

        public string m
        {
            get { return modell; }
            set { modell = value; }
        }

    }
}
