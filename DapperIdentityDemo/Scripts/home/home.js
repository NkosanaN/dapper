$(document).ready(function () {

    bootbox.alert("Hello world!", function () {
        console.log("Alert Callback");
    });

    $.notify("Access granted", "success", { position: "top center" });
})