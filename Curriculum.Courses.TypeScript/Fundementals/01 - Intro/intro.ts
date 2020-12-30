// parameter: string yerine parameter: any de olabilir.
function func(parameter: string) {
    return `Lorem ${parameter}`;
}

let message = func("ipsum");


// dinlemeyi başlattıktan sonra..
console.log(message);

// ve yeniden klasörün içinde cmd.exe ile tsc intro.ts kodunu 
// çalıştırdığımızda değişiklikler otomatik algılanır.