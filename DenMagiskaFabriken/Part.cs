using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabriken
{
    abstract class Part
    {
        public string Desc {get; set;}
        public int ComplexityScore{ get; set;}
    }
}
