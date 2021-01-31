// bütün değerleri vermek zorundayız.
interface IProduct {
    id: number;
    name: string;
    unitPrice: number;
}

function save1(product1: IProduct) {
    console.log(product1.name + " kaydedildi.");
}

save1({ id: 1, name: "Laptop", unitPrice: 990.99 });

// bütün değerleri vermesek de olur.
class Product {
    id: number;
    name: string;
    unitPrice: number;
}

function save2(product2: Product) {
    console.log(product2.name + " kaydedildi.");
}

let mouse = new Product();
mouse.name = "ATech";

save2(mouse);

// -------------------------------------------------- // 

interface IPersonService {
    save();
}

class CustomerService implements IPersonService {
    save() {

    }
}