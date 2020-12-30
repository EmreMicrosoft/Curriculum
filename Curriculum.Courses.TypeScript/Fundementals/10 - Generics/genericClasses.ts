class GenericClass<T> {

    variable: T;

    func(parameter: T): T {
        return parameter;
    }
}

let genericClass = new GenericClass<string>();

genericClass.func("Lorem Ipsum");

// ----- //
console.log(genericClass.func("Lorem Ipsum"));