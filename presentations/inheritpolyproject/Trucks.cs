using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritpolyproject
{
    public class Trucks : Transportation
    {
        public Trucks()
        {
            this.noOfDoors = 2;
            this.noOfWheels= 4;// 6, 8, 10, 12
            this.color="pink";
            this.engineType="electric";
        }
    }
}