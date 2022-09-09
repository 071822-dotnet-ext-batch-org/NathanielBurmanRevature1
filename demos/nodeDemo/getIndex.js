var http = require('http');
// require the filesystem library
var fs = require('fs');

console.log('getIndex.js loaded...');

// this creates a new file and put value inside
//fs.writeFileSync('./NewFile.txt','this is some text');

if(false){
    http.createServer(function (req, res) {
        fs.readFile('index.html', function(err, data) {
          res.writeHead(200, {'Content-Type': 'text/html'});
          res.write(data);
          //console.log(data);
          return res.end();
        });
      }).listen(8080);
}