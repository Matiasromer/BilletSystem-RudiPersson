using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class MC : Køretøj
    {
        public override string KøretøjType()
        {
            return "MC";
        }

        public override int Pris()
        {
            return 125;
        }
    }



}
