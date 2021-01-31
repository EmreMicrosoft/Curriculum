var Car = /** @class */ (function () {
    function Car() {
    }
    Object.defineProperty(Car.prototype, "model", {
        get: function () {
            return this._model;
        },
        set: function (str) {
            this._model = str;
        },
        enumerable: true,
        configurable: true
    });
    Car.prototype.save = function () {
        console.log("Car saved");
    };
    return Car;
}());
var car = new Car();
car.model = "Audi";
console.log(car.model);
car.save();
