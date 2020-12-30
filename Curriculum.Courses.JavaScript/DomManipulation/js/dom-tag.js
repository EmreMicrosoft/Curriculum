
// ----- GET ELEMENTS BY TAG NAME ----- //
var intro1 = document.getElementById("intro1");
var message = document.getElementById("message");

message.innerHTML = intro1.innerHTML;

var allLists = document.getElementsByTagName("ul");
var cityList = allLists[0];
var cities = cityList.getElementsByTagName("li");

for (let i = 0; i < cities.length; i++) {
    alert(cities[i].innerHTML);
}

//// Aynı kod böyle de çalışıyor:
//var cittt = document.getElementsByTagName("ul")[0]
//    .getElementsByTagName("li");

//for (let i = 0; i < cittt.length; i++) {
//    alert(cittt[i].innerHTML);
//}