/// <reference path="Customer.ts" />
/// <reference path="Supplier.ts" />
/// <reference path="Employee.ts" />

let person = new Person();
console.log(person.save());

let employee = new Employee();
console.log(employee.save());
console.log(employee.goBackToWork());

let supplier = new Supplier();
console.log(supplier.save());
console.log(supplier.buy());

let customer = new Customer();
console.log(customer.save());
console.log(customer.sell());

// Access Modifiers:
// public, private, protected