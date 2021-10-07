using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabriken
{
    class Bicycleblueprint: Blueprint
    {
        public Bicycleblueprint(): base(new List<Part> { new Wheel(), new Wheel(), new Metal("Iron") }, "A Bicycle")
        {
            
        }
    }
}
