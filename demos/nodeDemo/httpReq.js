var http = require('http');

console.log('httpReq.js loaded...');

let runServer = function (sText){
    //create a server object:
    http.createServer(function (req, res) {
        console.log('server running...');
        res.write('Hello World! ' + sText); //write a response to the client
        res.end(); //end the response
    }).listen(8080); //the server object listens on port 8080
}

exports.runServer = runServer;