console.log("starting...");


let objHere = {
    name1:'nathaniel',
    age:39,
    myFunct: function() {
        return `${this.name1} and age ${this.age} years old`;
    }
}

let myObj = objHere.myFunct();

console.log(myObj);


objHere.myFunct2 = function(name, age) {
    return {name , age}
}

console.log(objHere.myFunct2('NATHANIEL',29));

class myClass{
    constructor(name, age){
        this.name1 = name;
        this.age = age;
    }
}

let myPerson = new myClass('NaThAnIeL',11);

console.log(myPerson, myPerson.age, myPerson.name1, myClass.name);

class myBody {
    static count = 0;
    static staticName = 'Mac';

    constructor(name, age){
        this.name1 = name;
        this.age   = age;
        this.counter = 0;
        this.incTheCounter();
    }

    incTheCounter(){
        ++this.counter;
    }

    get nameAndAge(){
        return `name is ${this.name1} and age is ${this.age}`;
    }

    set setAge(value){
        if(value >100 || value <1){
            //return `thats not a value of age`;
            throw new RangeError(`that age ${value} is invalid`);
        }else{
            this.age = value;
        }
    }

    static getStatic(){
        ++this.count;
        //this.incTheCounter();
        return `getStatic ${this.staticName}, times: ${this.count}`;
    }
}

let nathan = new myBody('nathaniel', 39);
console.log(nathan);

nathan.setAge=22;

console.log(nathan);
console.log(nathan.nameAndAge);

console.log(nathan.getStatic);

console.log(myBody.getStatic());

class myRobot extends myBody{
    constructor(myName, age, address='112 main blvd'){
        super(myName, age);
        this.address= address;
    }
}

let bender = new myRobot('bender', 30);

console.log(`my robot ${bender.name1} is ${bender.age} years old and lives on ${bender.address}`);