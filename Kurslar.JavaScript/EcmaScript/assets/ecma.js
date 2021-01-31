// İLERİ FONKSİYON // 
var func1 = function func() {
    window.console.log("Lorem ipsum 1");
};

func1();


const func2 = () => {
    window.console.log("Lorem ipsum 2-a");
    window.console.log("Lorem ipsum 2-b");
};

func2();

const  func3 = (sms) => {
    window.console.log(sms);
};

func3("Sample SMS");

// ------------------------------------------ //

// İLERİ DİZİ //
const numbers = [1, 2, 3, 4];

numbers.forEach(number => {
    window.console.log(number);
});

const squareArray = [];

numbers.forEach(number => {
    squareArray.push(number * number);
});

console.log(squareArray);


// ------------------------------------------ //

// MAP //
const mapArray = numbers.map(number => number * 3);
console.log(mapArray);

const filteredArray = numbers.filter(number => number > 2);
console.log(filteredArray);

// ------------------------------------------ //




// REDUCE - kümulatif toplam //
// acc için default başlangıç değeri 0'dır.
const sum1 = numbers.reduce((acc, number) => {
    return acc + number;
});
console.log(sum1);

// acc için başlangıç değerini 5 yapalım:
const sum2 = numbers.reduce((acc, number) => {
    return acc + number;
},5);
console.log(sum2);

// ------------------------------------------ //




// İLERİ NESNE //

//[] === [] ---> sonuç: false
//[1,2] === [1,2] ---> sonuç: false
//this === window ---> sonuç: true

const productService = {
    add: function() {
        window.console.log(this);
    }
};

productService.add();