var i = 10;

var loop = function () {
	console.log(i + '. This will still run.');
	if (i-->0)
		setTimeout(loop, 10);
};

setTimeout(loop, 10);

console.log("Programm ended.");

/*
setTimeout(loop, 10);

var sleep = 1000000000;
while (sleep -- > 0) {}

var fs = require('fs');
var stream = fs.createReadStream('huge.txt');

stream.on('data', function(data) {
	console.log(data);
});
stream.on('end', function() {
	console.log('done');
});
stream.on('error', function(err) {
	console.log(err);
});
*/