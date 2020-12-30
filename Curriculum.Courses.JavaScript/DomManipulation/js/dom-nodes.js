
// ----- WORKING WITH NODES ----- //

var heading = document.createElement("h2");
var node = document.createTextNode("Lorem Ipsum");
heading.appendChild(node);

var div1 = document.getElementById("div1");
var p2 = document.getElementById("p2");

alert("inserting h2");
div1.insertBefore(heading, p1);

alert("deleting P3");
div1.removeChild(p3);

alert("changing P1");
var p1 = document.getElementById("p1");
div1.replaceChild(heading, p1);