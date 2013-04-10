require("http").createServer(
function (request, response){
	response.write("Hello World");
	response.end();
}).listen(8080);