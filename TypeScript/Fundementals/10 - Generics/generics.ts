function value1(x: number): number {
    return x;
}

let var1 = value1(10);
console.log(var1);

function value2(x: string): string {
    return x;
}

let var2 = value2("Lorem");
console.log(var2);

// ------------------------------------- // 


function value3<T>(x: T): T {
    return x;
}

let var3 = value3<number>(2);
let var4 = value3<string>("Ipsum");

console.log(var3);
console.log(var4);