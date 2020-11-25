var express = require("express");
var app = express();
var  server= require("http").createSever(app);
var io = require("socket.io").listen(server);
var fs = require("fs");
server.listen(process.env.PORT || 3000);
io.sockets.on('connection', function (socket) {
    console.log("Have a people");
    io.sockets.emit('serverguitin', { noidung: "ok" });
    socket.on('servernhan', function (data) {
        io.socket.emit('serverguitin', { noidung: data });
        socket.emit('serverguitin', { noidung: data });
    });
})
app.get("/",function(req,res)
{
	res.sendFile(dirname + "/index.html");
});