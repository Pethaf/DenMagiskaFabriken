using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabriken
{
    class Blueprint
    {
        private List<Part> _partsNeeded; 
        public List<Part> partsNeeded
        {
            get => _partsNeeded;
        }
        public string _description;
        public Blueprint(List<Part> theParts, string Description)
        {
            _partsNeeded = new List<Part>();
            _description = Description;
            foreach(Part thePart in theParts)
            {
                _partsNeeded.Add(thePart); 
            }
        }public int getNumberPartsNeeded()
        {
            return _partsNeeded.Count;
        }
    }
}
