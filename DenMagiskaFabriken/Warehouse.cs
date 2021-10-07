using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenMagiskaFabriken
{
    class Warehouse
    {
        List<Part> _inventory; 
        public Warehouse()
        {
            _inventory = new List<Part> { }; 
        }
        public void PrintInventory()
        {
            for(int j=0; j< _inventory.Count; j++)
            {
                Console.WriteLine($"{j + 1}: {_inventory[j].Desc}") ;
            } 
        }
        public Part PickItem(int index)
        {
            int correctIndex = index - 1; //Handle the fact that user is presented with a 1-indexed list while the inventory is 0-indexed 
            if(correctIndex < 0 || correctIndex > _inventory.Count-1)
            {
                return null; 
            }
            else
            {
                Part tmp = _inventory[correctIndex];
                _inventory.RemoveAt(correctIndex);
                return tmp; 
            }
        }
        public void AddItem(Part thePart)
        {
            _inventory.Add(thePart); 
        }
    }
}
