using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpsconsole2
{
    public class Player
    {
        //A class has properties, attributes, constructors and methods (mainly)

        //An attribute is a single piece of data like an age, DOB, name, etc
        // private here is an access modifier. it controls what parts of code can access a specific class or field (property or method)
        private int myAge = 0;
        // a getter method
        public int GetAge(){
            return myAge;
        }
        
        //A property is a c# abstraction and combination of Getters and Setters and the data
        public DateTime myDob { get; set; } = new DateTime(1983,7,24);
        public string sFName { get; set; }
        public string sLName { get; set; }
        public bool Gender { get; set; } // true is = female, false = male

        private int iwins;
        public int iWins  { 
            get{ return this.iwins; } 
            set{ this.iwins++;}
        }
        
        private int iloses;
        public int iLoses { 
            get{ return this.iloses; } 
            set{ this.iloses++;}
        }

        //Constructors are the methods called to instantiate & initialize a class object; these can be overloaded
        // you are given a defautl constructor Player; but if you create a parameterized constructoer you MUST create your own default constructor.
        public Player(){}
        
        // paramaterized constructor
        public Player(string fname){
            this.sFName = fname;
        }


        //Methods are sets of consecutive steps that the program completes. they can be called individually
        // getter & setter methods get/set data while protecting the data
        
        // a getter method
        public void SetAge(int age){
            if(age>110 || age<18){
                throw new FieldAccessException($"You cant set the age to {age}");
            }
            else{
                this.myAge = age;
            }
        }
    }
}