using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabriken
{
    class Blueprint
    {
        public List<Part> partsNeeded
        {
            get => partsNeeded;
        }
        public string _description;
        public Blueprint(List<Part> theParts, string Description)
        {
            foreach(Part thePart in theParts)
            {
                partsNeeded.Add(thePart); 
            }
        }public int getNumberPartsNeeded()
        {
            return partsNeeded.Count;
        }
    }
}
