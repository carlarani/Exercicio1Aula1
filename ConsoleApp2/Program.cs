using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory.Load();

            Inventory.Include(new Guitar(8,12,"Fender", 12000.50m));
            Inventory.Include(new Piano());
            Inventory.Include(new Violin());

            Console.WriteLine(Inventory.Count);


            Inventory.Save();
        }
    }
}
