using System;

namespace inheritancepoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // init the class
            WorkItem myWI1 = new WorkItem();
            WorkItem myWI2 = new WorkItem();

            Console.WriteLine(myWI1.ToString());

            Furniture f = new Furniture();
            Bed b = new Bed();

            Console.WriteLine($"{f.GetNumEditions()} {b.GetNumEditions()}");

            Console.WriteLine($"The furnitue has {f.NumLegs} legs; the bed has {b.NumLegs} legs.");

            Console.WriteLine($"The furniture edition is {Furniture.NumEditions}");
            Console.WriteLine($"The bed edition is {Bed.NumEditions}");

            Console.WriteLine(f.Astring());
            Console.WriteLine(b.Astring());

            Furniture.NumEditions++;
            Bed.NumEditions++;
            Furniture.NumEditions++;
            Bed.NumEditions++;
            Furniture.NumEditions++;
            Bed.NumEditions++;

            Console.Write(f.GetNumEditions());
            Console.Write(b.GetNumEditions());
        }
    }
}
