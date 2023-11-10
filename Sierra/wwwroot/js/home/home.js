document.addEventListener("DOMContentLoaded", function () {
    const slider = document.getElementById("mySlider");
    let counter = 1;

    setInterval(function () {
        slider.style.transform = "translateX(" + -counter * 100 + "%)";
        counter++;
        if (counter === 4) {
            counter = 0;
        }
    }, 3000);
});
