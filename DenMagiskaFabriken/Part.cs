using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabriken
{
    abstract class Part : IComparable
    {
        public string Desc { get; set; }
        public int ComplexityScore { get; set; }

        public int CompareTo(Object o)
        {
            Console.WriteLine("I was called");
            if (this.GetType() == o.GetType())
            {
                return this.Desc.CompareTo(((Part)o).Desc);
            }
            else
            {
                return -1;
            }
        }
    }
}
