using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritpolyproject
{
    public class Transportation
    {
        
        public Transportation(){
        }
        public Transportation(string str, int i){
            this.color= str;
            this.noOfWheels=i;
        }
        internal int noOfWheels{get;set;}
        public int noOfDoors{get;set;}
        public string color{get;set;}
        public string engineType{get;set;}

        public virtual int GetNumWheels(){
            return noOfWheels;
        }
        public virtual int GetNoOfDoors(){
            return noOfDoors;
        }
        public virtual string GetColor(){
            return color;
        }
        public virtual string GetEngineType(){
            return engineType;
        }
    }
}