using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritpolyproject
{
    public class Boats : Transportation
    {

        public Boats() : base()
        {
            this.noOfDoors = 0;
            this.noOfWheels= 0;
            this.color="white";
            this.engineType="deisel";
        }

        public override int GetNumWheels(){
            return 0;
        }

    }
}