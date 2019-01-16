/* The following logic is use:
We use combination for one char with other chars
Than we use recursion to loop trough the all chars
Than we print each char individualy  */

let result = [];
let input;
function combination(someString) {
    let arrayOfchar = someString.split("");
    let char = "";
    // combination for one char with other chars
    for (let i = 0; i < arrayOfchar.length - 1; i++) {
        char += arrayOfchar[i];

        for (let j = (i + 1); j < arrayOfchar.length; j++) {
            let resultTopush = char + arrayOfchar[j];
            result.push(resultTopush);
        }
    }
    arrayOfchar.shift();
    let subString = arrayOfchar.join("");
    //recursion for the all chars
    if (arrayOfchar.length !== 0) {
        combination(subString);
    }
    // printing char individually 
    else {
        let char = input.split("");
        char.forEach(element => {
            result.push(element)
        });
    }
}

combination(input = "12345");
console.log(result);