var config = {
    errorpage: "error.html"
};


function doLogin() {

    var url = "http://testapp1.com/api/login/" + $("#txtname").val() + "/" + $("#txtpassword").val();
    hideLoginError();

    $.ajax({
        url: url,
        type:"get",
        contentType: "application/json",
        dataType: 'jsonp',
        crossDomain: true
    }).error(function (error, status) {
        alert("doLogin() error");
    }).success(function (data) {
//        debugger;
        if (data == null) {
            showLoginError();
            return;
        }
        window.location = "firstpage.html";
    });
}

function checkAuth() {
    var url = "http://testapp1.com/api/auth";
    debugger;
    $.ajax({
        url: url,
        type: "get",
        contentType: "application/json",
        dataType: 'jsonp',
        crossDomain: true,
        timeout: 6000
    })
    .fail(function (err) {
        window.location = "error.html";
    })
    .error(function (err) {
        window.location="error.html";
    })
    .done(function (data) {
        $("h2").html("You're in!!");
    }).always(function (data) {
//        debugger;
    });
}

function showLoginError() {
    $("#loginerror").show();
}

function hideLoginError() {
    $("#loginerror").hide();
}
