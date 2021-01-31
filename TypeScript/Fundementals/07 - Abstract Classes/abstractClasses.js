var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var CreditBase = /** @class */ (function () {
    function CreditBase() {
    }
    // tamamlanmış operasyon:
    CreditBase.prototype.save = function () {
        console.log("Saved");
    };
    return CreditBase;
}());
// Eğer bir sınıf, bir abstract sınıfı extend ederse, 
// constructor'unun içine super(); metodunu çağırmak durumundadır. 
// Eğer abstract class, dışarıdan bir parametre alıyor olsaysaydı, 
// o parametreyi super(parameter); ile gönderirdik. (Örneğin connectionString)
// CreditBase'i extend ediyorsak, calculate() metodunu ezmek zorundayız:
var ConsumerCredit = /** @class */ (function (_super) {
    __extends(ConsumerCredit, _super);
    function ConsumerCredit( /*parameters*/) {
        return _super.call(this) || this;
    }
    ConsumerCredit.prototype.calculate = function () {
        console.log("Tüketici kredisine göre faiz hesaplandı.");
    };
    return ConsumerCredit;
}(CreditBase));
var MortgageCredit = /** @class */ (function (_super) {
    __extends(MortgageCredit, _super);
    function MortgageCredit( /*parameters*/) {
        return _super.call(this) || this;
    }
    MortgageCredit.prototype.calculate = function () {
        console.log("Konut kredisine göre faiz hesaplandı.");
    };
    return MortgageCredit;
}(CreditBase));
var consumerCredit = new ConsumerCredit();
consumerCredit.calculate();
consumerCredit.save();
var mortgageCredit = new MortgageCredit();
mortgageCredit.calculate();
mortgageCredit.save();
