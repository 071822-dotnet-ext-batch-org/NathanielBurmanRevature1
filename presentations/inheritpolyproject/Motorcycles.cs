using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritpolyproject
{
    public class Motorcycles : Transportation
    {
        public Motorcycles() : base()
        {
            this.noOfDoors = 0;
            this.noOfWheels= 2;
            this.color="red";
            this.engineType="gas";
        }
        public override int GetNumWheels(){
            return noOfWheels;
        }

    }
}