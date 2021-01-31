let cities = ["Ankara", "Istanbul", "Antalya"];

// elemanın index numarasını verir: 0 1 2
for (let c in cities) {
    console.log(c);
}

// elemanın değerini verir: Ankara Istanbul Antalya
for (let c of cities) {
    console.log(c);
}