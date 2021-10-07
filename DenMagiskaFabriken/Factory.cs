using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabriken
{
    class Factory 
    {
        private List<Part> stock;
        private List<Blueprint> _blueprints; 
        public Factory()
        {
            stock = new List<Part> { }; 
        }
        public void AddBluePrint(Blueprint ThebBueprint)
        {
            _blueprints.Add(ThebBueprint); 
        }
        public void ReceivePart(Part aPart)
        {

            Console.WriteLine($"recieved {aPart.Desc}");
        }
        public Part Manufacture()
        {
            List<Blueprint> craftableItems = new List<Blueprint> { }; 
            foreach(var blueprint in _blueprints)
            {
                if (blueprint.getNumberPartsNeeded() <= stock.Count)
                {
                    craftableItems.Add(blueprint);
                }
            }

            return new Metal("Fish", 1);
        }
    }
}
