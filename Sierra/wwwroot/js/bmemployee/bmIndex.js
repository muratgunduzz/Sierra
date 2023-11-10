var elementShow = [];


$(".bmemployee-index-login-button").click(function () {
    $(".bmemployee-index-login-button").hide();
    
})

// element olayları
function ShowElement() {
    elementShow[0] = 1;
    $.ajax({
        type: "POST",
        url: "/BMEmployee/Show",
        data: { elementShow: elementShow },
        success: function (response) {
            var check = response.check;
            if (check === 1) {
                $(".bmemployee-index-identify").append("<input placeholder='ID'><input placeholder='Password' type='password'><button class='bmemployee-index-identify-button'>?</button>")
            }
        }
    })
}

//
