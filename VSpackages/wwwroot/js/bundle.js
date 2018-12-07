document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    elemant.textContent = "This is element from 4 js file (1)";
    document.querySelector("body").appendChild(element);
});
document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    elemant.textContent = "This is element from 3 (modified) js file (1)";
    document.querySelector("body").appendChild(element);
});