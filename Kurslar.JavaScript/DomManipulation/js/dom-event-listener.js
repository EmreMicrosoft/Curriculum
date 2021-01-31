
// ----- ADD EVENT LISTENER ----- //
function changeColorAndName() {

    window.document.getElementById("main-div").style.color = "red";

    const nameElements = window.document.getElementsByName("customerName");
    nameElements[0].value = "New Customer";
}

var textLine = document.getElementById("text-line")
    .addEventListener("click", changeColorAndName);

var message = document.getElementById("message")
    .addEventListener("mouseover", changeColorAndName);