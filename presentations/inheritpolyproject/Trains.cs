using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritpolyproject
{
    public class Trains : Transportation
    {
        private int noOfCars = 0;
        public Trains(string x, int i) : base(x, i)
        {
            this.noOfDoors = 0;
            //this.noOfWheels= 8;
            //this.color="brown";
            this.engineType="coal";
        }
    }
}