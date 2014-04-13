function initIndexPage() {
    $("#Login").bind("click", function () {
        $(".error-msg").hide();
        $("#username_required").css("visibility", "hidden");
        $("#password_required").css("visibility", "hidden");

        $("#login-wait-img").show(250);
        $("#Login").hide(250);

        setTimeout(function () {
            if (validateLogin() == true) {
                window.location.href = "loggedin.html";
            }
            else {
                $("#login-wait-img").hide(250);
                $("#Login").show(250);
            }
        }, 800);
    });
}


function validateLogin() {
    var fail = false;
    if ($("#UserName").val() == "") {
        fail = true;
        $("#username_required").css("visibility", "visible");
    }

    if ($("#login-password").val() == "") {
        fail = true;
        $("#password_required").css("visibility", "visible");
    }

    var url = "http://testapp1.com/api/login/" + $("#txtname").val() + "/" + $("#txtpassword").val();
    hideLoginError();

    $.ajax({
        url: url,
        type: "get",
        contentType: "application/json",
        dataType: 'jsonp',
        crossDomain: true
    }).error(function (error, status) {
        alert("doLogin() error");
    }).success(function (data) {
        debugger;
        if (data == null) {
            showLoginError();
            return;
        }
        window.location = "firstpage.html";
    });
}

function checkAuth() {
    debugger;
    var url = "http://testapp1.com/api/auth";
    $.ajax({
        url: url,
        type: "get",
        contentType: "application/json",
        dataType: 'jsonp',
        jsonpCallback: 'jsonCallback',
        crossDomain: true,
        timeout: 6000
    })
    .fail(function (err) {
        window.location = "error.html";
    })
    .error(function (err) {
        window.location = "error.html";
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

