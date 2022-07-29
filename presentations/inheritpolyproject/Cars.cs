using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritpolyproject
{
    public class Cars : Transportation
    {
        public Cars() : base()
        {
            this.noOfDoors = 4;
            this.noOfWheels= 4;
        }
    }
}