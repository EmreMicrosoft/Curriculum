class Personel {

    constructor(name, surname) {
        this.name = name;
        this.surname = surname;
    }

    save(){
        window.console.log("personel saved"/* + this.name*/);
    }
}

const personel = new Personel(/*"pName","pSurname"*/);
personel.save();

personel.name = "pName";
personel.surname = "pSurname";
console.log(personel.name + " " + personel.surname);