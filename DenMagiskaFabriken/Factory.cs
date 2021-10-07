using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabriken
{
    class Factory 
    {
        public List<Part> stock;
        private List<Blueprint> _blueprints; 
        public Factory()
        {
            stock = new List<Part> { };
            _blueprints = new List<Blueprint> { }; 
        }
        public void AddBluePrint(Blueprint ThebBueprint)
        {
            _blueprints.Add(ThebBueprint); 
        }
        public void ReceivePart(Part aPart)
        {

            Console.WriteLine($"recieved {aPart.Desc}");
            stock.Add(aPart);
        }
        public Part Manufacture()
        {
            List<Blueprint> craftableItems = new List<Blueprint> { }; 
            foreach(var blueprint in _blueprints)
            {
                if (CheckSubset(blueprint.partsNeeded))
                {
                    craftableItems.Add(blueprint);
                }
            }

            if (stock.Count == 0)
            {
                Console.WriteLine("Nothing in stock");
            }
            else
            {
                Console.WriteLine("The factory has the following items in stock");
                foreach(var part in stock)
                {
                    Console.WriteLine($"{part.Desc}");
                }
                Console.WriteLine("The factory can manfacture the following items");
                foreach (var blueprint in craftableItems)
                {
                    Console.WriteLine($"{blueprint._description}");
                }
            }


            return new Metal("Fish");
        }
        private bool CheckSubset(List<Part> listOfParts)
        {
            if(listOfParts.Count > stock.Count)
            {
                return false; 
            }
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            Dictionary<string, int> dict2 = new Dictionary<string, int>();
            foreach (var item in listOfParts)
            {
                if (dict1.ContainsKey(item.Desc))
                {
                    dict1[item.Desc]++;
                }
                else
                {
                    dict1[item.Desc] = 1;
                }
            }
            foreach (var item in stock)
            {
                if (dict2.ContainsKey(item.Desc))
                {
                    dict2[item.Desc]++;
                }
                else
                {
                    dict2[item.Desc] = 1;
                }
            }
            bool isSubset = true;
            foreach (var item in dict1)
            {
                if (dict2.TryGetValue(item.Key, out int count))
                {
                    if (count != dict1[item.Key])
                    {
                        isSubset = false;
                        break;
                    }

                }
                else
                {
                    isSubset = false;
                    break;
                }
            }
            return isSubset;
        }
    }
}
