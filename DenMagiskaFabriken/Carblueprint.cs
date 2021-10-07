using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabriken
{
    class Carblueprint: Blueprint 
    {
        public Carblueprint(): base(new List<Part> { new Wheel(), new Wheel(), new Wheel(), new Wheel(), new Metal("Aluminum"), new Metal("Iron") }, "A car")
        {

        }
    }
}
