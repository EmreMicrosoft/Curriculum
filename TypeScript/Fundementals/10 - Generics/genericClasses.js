var GenericClass = /** @class */ (function () {
    function GenericClass() {
    }
    GenericClass.prototype.func = function (parameter) {
        return parameter;
    };
    return GenericClass;
}());
var genericClass = new GenericClass();
genericClass.func("Lorem Ipsum");
// ----- //
console.log(genericClass.func("Lorem Ipsum"));
