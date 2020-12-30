function sum1(x: any, y: any) {
    return x + y;
}

function sum2(x: number, y: number): number {
    return x + y;
}


let sum3 = (x: number, y: number): number => x + y;
//let sum3 = function (x: number, y: number): number {
//    return x + y;
//}

console.log(sum1(1, 2));
console.log(sum1("Antalya", 7));
console.log(sum2(3, 5));
console.log(sum3(12, 14));


// ----- Optional an Default Parameters ----- //
// opsiyonel/default değer sonda olur. 
function sum4(x: number, y: number = 4): number {
    return x + y;
}
console.log(sum4(3));

function sum5(x: number, y?: number): number {
    return x + y;
}
console.log(sum5(2)); //returns NaN (Not a Number)

function sum6(x: number, y?: number): number {
    if (y) {
        return x + y;    
    }
    return x;
}
console.log(sum6(12));


// ----- Rest Parameters ----- //
// alacağımız parametre sayısı belli değilse kullanırız.
function davetEt1(ilkDavetli: string, ...digerleri: string[]): string {
    return ilkDavetli + " " + digerleri.join(" ");
}
console.log(davetEt1("Person1", "Person2", "Person3", "Person4"));

// ya da;
function davetEt2(...digerleri: string[]): string {
    return digerleri.join(" ");
}
console.log(davetEt2("Person1", "Person2", "Person3", "Person4"));
