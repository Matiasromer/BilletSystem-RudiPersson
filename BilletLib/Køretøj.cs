﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public abstract class Køretøj
    {
        public DateTime Dato { get; set; }
        public string Nummerplade { get; set; }


        public abstract int Pris();
        public abstract string KøretøjType();
    }
}
