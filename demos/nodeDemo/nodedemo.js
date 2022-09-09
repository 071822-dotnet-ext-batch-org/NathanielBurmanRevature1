const myModule  = require('./otherfile.js');
const myIndex   = require('./getIndex.js');
const myHttpReq = require('./httpReq.js');

console.log('nodedemo file loaded...');

console.log(myModule.otherVar);
console.log(myModule.otherVar2);
console.log(myModule.otherFunct('this string'));

myHttpReq.runServer(myModule.otherVar + myModule.otherVar2 + myModule.otherFunct('this string'));