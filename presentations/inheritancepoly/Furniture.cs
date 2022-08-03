using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritancepoly
{
    public class Furniture
    {
        public static int NumEditions = 0;

        public Furniture(){}

        public int NumLegs{get;set;}
        public int Color{get;set;}
        public int Material{get;set;}


        public virtual string GetNumEditions(){
            return Convert.ToString(NumEditions);
        }

        public virtual int IncNumEditions(){
            return NumEditions++;
        }

        public virtual string Astring(){
            return "this is a string";
        }

    }
}