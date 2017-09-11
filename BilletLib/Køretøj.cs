using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public abstract class Køretøj
    {
        private string nummerPlade;
        public DateTime Dato { get; set; }
        public string Nummerplade
        {
            get { return nummerPlade; }
            set
            {
                if (value.Length > 7)
                    throw new ArgumentException("Nummerpladen må ikke være mere end 7 tegn");

                nummerPlade = value;
            }
        }


        public abstract int Pris();
        public abstract string KøretøjType();
    }
}
