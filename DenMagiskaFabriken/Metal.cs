﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabriken
{
    class Metal : Part
    {
        public Metal(string desc) : base()
        {
            base.Desc = desc;
            base.ComplexityScore = 1;
        }
     
    }
}
