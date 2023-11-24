$(document).ready(function () {
    showOverlay();
});

function showOverlay() {
    var overlay = $("#overlay");
    var overlayText = $("#overlayText");

    overlay.css("display", "flex");
    overlayText.text("Welcome Dr. Breen");

    setTimeout(function () {
        overlay.animate({ opacity: 0 }, 2000, function () {
            overlay.css("display", "none");
            overlay.css("opacity", 1);
        });
    }, 2000);
}
