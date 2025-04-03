using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEdElgueta
{
    class clsNodo
    {
        private int cod;
        private string nom;
        private string tra;
        private clsNodo sig;

        public int codigo
        {
            get { return cod; }
            set { cod = value; }
        }
        public string nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public string tramite
        {
            get { return tra; }
            set { tra = value; }
        }
        public clsNodo siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
    }
}
