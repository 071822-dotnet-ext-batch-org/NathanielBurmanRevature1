using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritpolyproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Transportation trans = new Transportation("vroom", 7);
            Cars  car  = new Cars();
            Boats boat = new Boats();
            Motorcycles bike = new Motorcycles();
            Trains train = new Trains("choochoo", 8);
            Trucks truck = new Trucks();

            Console.WriteLine($"# of wheels in transportation {trans.GetNumWheels()}");
            Console.WriteLine($"car # wheels method {car.GetNumWheels()}");
            Console.WriteLine($"boat {boat.GetNumWheels()}");
            Console.WriteLine($"bike {bike.GetNumWheels()}");
            Console.WriteLine($"train {train.GetNumWheels()}");
            Console.WriteLine($"truck {truck.GetNumWheels()}");

        }
    }
}
