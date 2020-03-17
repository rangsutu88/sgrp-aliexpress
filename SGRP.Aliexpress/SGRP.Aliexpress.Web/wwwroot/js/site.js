﻿"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/aliexpressHub").build();


connection.on("ReceiveMessage", function (user, message) {
    document.getElementById('messagesList').innerHTML = message;
});

connection.start().then(function () {

}).catch(function (err) {
    return console.error(err.toString());
});

//document.getElementById("sendButton").addEventListener("click", function (event) {
//    var user = document.getElementById("userInput").value;
//    var message = document.getElementById("messageInput").value;
//    connection.invoke("SendMessage", user, message).catch(function (err) {
//        return console.error(err.toString());
//    });
//    event.preventDefault();
//});