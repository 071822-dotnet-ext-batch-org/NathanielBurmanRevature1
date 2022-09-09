console.log('otherfile loaded...');

// each file constitues a module
let otherVar = 'nathaniel';
let otherVar2= 'hatred';

let otherFunct = function(string){
    return 'Reading ' + string;
}

module.exports.otherVar = otherVar;
exports.otherVar2 = otherVar2;
exports.otherFunct = otherFunct;