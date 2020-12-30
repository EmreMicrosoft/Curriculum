function save1(product1) {
    console.log(product1.name + " kaydedildi.");
}
save1({ id: 1, name: "Laptop", unitPrice: 990.99 });
// bütün değerleri vermesek de olur.
var Product = /** @class */ (function () {
    function Product() {
    }
    return Product;
}());
function save2(product2) {
    console.log(product2.name + " kaydedildi.");
}
var mouse = new Product();
mouse.name = "ATech";
save2(mouse);
var CustomerService = /** @class */ (function () {
    function CustomerService() {
    }
    CustomerService.prototype.save = function () {
    };
    return CustomerService;
}());
