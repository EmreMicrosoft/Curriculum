var Ev = /** @class */ (function () {
    function Ev(odaSayisi, pencereSayisi, bulunduguKat) {
        this.odaSayisi = odaSayisi;
        this.pencereSayisi = pencereSayisi;
        this.bulunduguKat = bulunduguKat;
    }
    Ev.prototype.kapiyiAc = function () {
        return this.bulunduguKat + "'inci kattaki evde " + "kapı açıldı";
    };
    Ev.prototype.kapiyiKapat = function () {
        return "kapı kapandı";
    };
    return Ev;
}());
var ev = new Ev(4, 9, 2);
console.log("Bulundu\u011Fu Kat : " + ev.bulunduguKat);
console.log(ev.kapiyiAc());
console.log(ev.kapiyiKapat());
