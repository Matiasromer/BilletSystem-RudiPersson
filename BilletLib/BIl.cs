﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : Køretøj
    {
        public override string KøretøjType()
        {
            return "Bil";
        }

        public override int Pris()
        {
            return 240;
        }
    }
}
