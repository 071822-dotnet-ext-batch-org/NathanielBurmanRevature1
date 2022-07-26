const fs = require('fs');

let readThisFile = function(sURL){
    fs.readFile(sURL, 'utf8', (err, data) => {
        if (err) {
        console.error(err);
        return;
        }
        // output to console
        console.log(data);
    });
}

let readThisFile2 = function(sURL){
    const data = fs.readFileSync(sURL,
            {encoding:'utf8', flag:'r'});
 
    // Display the file data
    console.log("Read from file... "+data);
}


let runFile = function(sUrl){
    // write to a new file
    fs.writeFileSync('./'+sUrl+'.txt', 'This is content from a new file');
    // append to file
    fs.appendFile('./'+sUrl+'.txt', ' APPENDED TO FILE', function(err,data){return true});
    // read from file
    readThisFile2('./'+sUrl+'.txt');
}

exports.runFile = runFile;