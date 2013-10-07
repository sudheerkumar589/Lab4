var echo = function(dataPass) {
    $.ajax({
        type: "POST",
        url: "/echo/json/",
        data: dataPass,
        cache: false,
        success: function(json) {
            alert("Result=" + json.Id);
        }
    });
};
$('.add').live('click', function() {
    $.get("http://170.224.169.112/aspnet_client/WebSite11/WebService.asmx", function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
$('.subtract').live('click', function() {
    $.get("http://170.224.169.112/aspnet_client/WebSite11/WebService.asmx", function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
$('.mul').live('click', function() {
    $.get("http://170.224.169.112/aspnet_client/WebSite11/WebService.asmx", function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
$('.div').live('click', function() {
    $.get("http://170.224.169.112/aspnet_client/WebSite11/WebService.asmx", function(data) {
        var json = {
            json: JSON.stringify(data),
            delay: 1
        };
        echo(json);
    });
});
