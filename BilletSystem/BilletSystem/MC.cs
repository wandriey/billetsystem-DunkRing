﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletSystem
{
    public class MC
    {
        public int Pris()
        {
            return 125;
        }

        public string Køretøj()
        {
            return "MC";
        }
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }
    }
}
