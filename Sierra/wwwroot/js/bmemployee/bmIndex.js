var elementShow = [];
var login = [];

$(".bmemployee-index-login-button").click(function () {
    $(".bmemployee-index-login-button").hide();
    
})

// element show

// login check
function Login() {
    var ID = $("#ID").val();
    var Password = $("#Password").val();
    login = login.push(ID, Password);
    $.ajax({
        type: "POST",
        url: ""
    })
}
