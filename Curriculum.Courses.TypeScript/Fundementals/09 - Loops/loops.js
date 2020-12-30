var cities = ["Ankara", "Istanbul", "Antalya"];
// elemanın index numarasını verir: 1 2 3
for (var c in cities) {
    console.log(c);
}
// elemanın değerini verir: Ankara Istanbul Antalya
for (var _i = 0, cities_1 = cities; _i < cities_1.length; _i++) {
    var _c = cities_1[_i];
    console.log(_c);
}
