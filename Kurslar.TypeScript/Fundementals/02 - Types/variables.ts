let n: number;
n = 10;
n = 6.4;

let str: string;
str = "lorem";
str = "ipsum";

let isTrue: boolean;
isTrue = true;
isTrue = false;

let numbers1: number[] = [1, 2, 3];
let numbers2: Array<number> = [1, 2, 3];

let array1 = [1, "Roma"];
let array2: [number, string] = [2, "Athens"];

enum Color { Black = 1, Gray, White };

//let color: Color = Color.White;
let color = Color.White;

let notSure: any = "String";
notSure = 2;
notSure = {};

// undefined:
let year: number;

let v: void = undefined;

function funcVoid(): void {
    console.log("Test String");
    //return 5;
}