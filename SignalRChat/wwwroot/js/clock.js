var connection = new signalR.HubConnectionBuilder().withUrl("/clockHub").build();

connection.on("DisplayTime", function (time) {
    var li = document.createElement("li");
    li.textContent = time;
    document.getElementById("serverDate").appendChild(li);
});

connection.start().then(function () {

}).catch(function (err) {
    return console.error(err.toString());
});

setInterval(function () {

    connection.invoke("PrintTime").catch(function (err) {
        return console.error(err.toString());
    });

}, 1000);