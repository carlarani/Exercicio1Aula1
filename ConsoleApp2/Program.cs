using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory.Load();

            Inventory.Include(new Guitar());
            Inventory.Include(new Piano());
            Inventory.Include(new Violin());

            Console.WriteLine(Inventory.Count);


            Inventory.Save();
        }
    }
}
