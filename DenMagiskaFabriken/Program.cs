using System;

namespace DenMagiskaFabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            Metal Iron = new Metal("Iron");
            Metal Iron2 = new Metal("Iron");
            Metal Iron3 = new Metal("Iron");
            Console.WriteLine(Iron.Desc);
            Metal Aluminium = new Metal("Aluminum");
            Metal Copper = new Metal("Copper");
            Warehouse theWarehouse = new Warehouse();
            theWarehouse.AddItem(Aluminium);
            theWarehouse.AddItem(Copper);
            theWarehouse.AddItem(Iron);
            theWarehouse.AddItem(Iron2);
            theWarehouse.AddItem(Iron3);
            Factory theFactory = new Factory();
            while (true)
            {
                theWarehouse.PrintInventory();
                Console.WriteLine("These are the items in stock \n which item do you want to pick?");
                int theIndex = int.Parse(Console.ReadLine());
                Part pickedPart = theWarehouse.PickItem(theIndex);
                if(pickedPart == null)
                {
                    Console.WriteLine("Felaktigt val");
                }
                else
                {
                    theFactory.ReceivePart(pickedPart);  
                }

            }
        }
    }
}
