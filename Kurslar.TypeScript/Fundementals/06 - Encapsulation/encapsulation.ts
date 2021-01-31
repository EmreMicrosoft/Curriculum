// Getters & Setters

class Car {
    private _model: string;

    get model(): string {
        return this._model;
    }
    set model(str: string) {
        this._model = str;
    }

    save() {
        console.log("Car saved");
    }
}

let car = new Car();
car.model = "Audi";
console.log(car.model);
car.save();