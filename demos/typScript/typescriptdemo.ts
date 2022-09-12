import { myClass } from "./myModules/myModule";

interface Shape{
    shape : string;
}

interface Color{
    color : string;
}

interface Square extends Shape, Color {
    sides : number;
}

interface Star extends Shape, Color {
    points : number;
}

let aSquare = {} as Square;
let aStar   = {} as Star;

aSquare.color = "red";
aSquare.shape = "square";
aSquare.sides = 4;

aStar.color = "blue";
aStar.shape = "star";
aStar.points = 5;

console.log(aSquare);
console.log(aStar);

let myClass1 = new myClass('test', 'bang');
console.log(myClass1);