using System;
using System.Collections.Generic;
namespace DenMagiskaFabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            Carblueprint carblueprint = new Carblueprint();
            Bicycleblueprint bikeplueprint = new Bicycleblueprint();
            Factory theFactory = new Factory();
            theFactory.AddBluePrint(carblueprint);
            theFactory.AddBluePrint(bikeplueprint);
            theFactory.Manufacture();
            theFactory.ReceivePart(new Wheel());
            theFactory.ReceivePart(new Wheel());
            theFactory.ReceivePart(new Metal("Iron"));
            theFactory.Manufacture();
            theFactory.ReceivePart(new Wheel());
            theFactory.ReceivePart(new Wheel());
            theFactory.ReceivePart(new Metal("Aluminum"));
            theFactory.Manufacture();

                   }
    //while (true)
    //{
    //    theWarehouse.PrintInventory();
    //    Console.WriteLine("These are the items in stock \n which item do you want to pick?");
    //    int theIndex = int.Parse(Console.ReadLine());
    //    Part pickedPart = theWarehouse.PickItem(theIndex);
    //    if(pickedPart == null)
    //    {
    //        Console.WriteLine("Felaktigt val");
    //    }
    //    else
    //    {
    //        theFactory.ReceivePart(pickedPart);  
    //    }

    //}
    }
}