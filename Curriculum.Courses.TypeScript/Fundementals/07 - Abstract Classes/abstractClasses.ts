abstract class CreditBase {
    constructor() {
        
    }
    // tamamlanmış operasyon:
    save(): void {
        console.log("Saved");
    }

    // imza şeklinde bırakılmış operasyon:
    abstract calculate():void;
}



// Eğer bir sınıf, bir abstract sınıfı extend ederse, 
// constructor'unun içine super(); metodunu çağırmak durumundadır. 
// Eğer abstract class, dışarıdan bir parametre alıyor olsaysaydı, 
// o parametreyi super(parameter); ile gönderirdik. (Örneğin connectionString)

// CreditBase'i extend ediyorsak, calculate() metodunu ezmek zorundayız:
class ConsumerCredit extends CreditBase {
    constructor(/*parameters*/) {
        super();
    }

    calculate(): void {
         console.log("Tüketici kredisine göre faiz hesaplandı.");
    }
}

class MortgageCredit extends CreditBase {
    constructor(/*parameters*/) {
        super();
    }

    calculate(): void {
        console.log("Konut kredisine göre faiz hesaplandı.");
    }
}

let consumerCredit = new ConsumerCredit();
consumerCredit.calculate();
consumerCredit.save();

let mortgageCredit = new MortgageCredit();
mortgageCredit.calculate();
mortgageCredit.save();