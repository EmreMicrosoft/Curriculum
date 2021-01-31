class Ev {
    odaSayisi: number;
    pencereSayisi: number;
    bulunduguKat: number;

    constructor(odaSayisi: number, pencereSayisi: number,
    bulunduguKat: number) {
        this.odaSayisi = odaSayisi;
        this.pencereSayisi = pencereSayisi;
        this.bulunduguKat = bulunduguKat;
    }

    kapiyiAc() {
        return this.bulunduguKat +
            "'inci kattaki evde " + "kapı açıldı";
    }

    kapiyiKapat() {
        return "kapı kapandı";
    }
}

let ev = new Ev(4, 9, 2);
console.log(`Bulunduğu Kat : ${ev.bulunduguKat}`);

console.log(ev.kapiyiAc());
console.log(ev.kapiyiKapat());