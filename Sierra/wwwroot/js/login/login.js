function ShowElement() {
    var target = "/Login/Index"
    window.location.href = target;
}
function login() {
    var userName = $("#Username").val();
    var passWord = $("#Password").val();
    $.ajax({
        type: "POST",
        url: "Login/ Login",
        data: { ID: userName, PassWord: passWord },
        success: function (data) {
            if (data.status === "error") {
                alert("Giriş başarısız. Kullanıcı adı veya şifre yanlış")
                $("#Username").val("");
                $("#Password").val("");
            }
            else {
                window.location.href = "/EmployeeSystem/Index";
            }
        },
    })
}
//looglama, Nlog, seriLog, logFornet
//orm çeşitleri database bağlantıları için depper ve entity framework core bunlar içnde class
//orm ler için dataaccess klasör enty ve depper için ayrı base interface orda yazdıklarını oradan türet