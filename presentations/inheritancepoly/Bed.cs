using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritancepoly
{
    public class Bed : Furniture
    {
        public Bed()
        {
        }

        public override string GetNumEditions(){
            return $"a new GetNumEdition method";
        }

        public override int IncNumEditions(){
            return ++NumEditions;
        }

        public override string Astring(){
            return "this is a new string";
        }
    }
}