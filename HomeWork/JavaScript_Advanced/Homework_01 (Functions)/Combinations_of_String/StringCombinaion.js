/* The following logic is use:
We first print all the chars from string
Then we use combination for one char with others 
Than we loop the combination function for each char */

function passValue (someString)
{   
    //declare a function that finds all combination for one char
    // had some fun with the scope and closure:))
    function combination(){
        let char = "";
        for (let i = 0; i < arrayOfchar.length-1; i++) {
            char += arrayOfchar[i];
    
            for (let j = (i+1); j < arrayOfchar.length; j++) {
                let resultTopush = char+arrayOfchar[j];
                result.push(resultTopush);
            }
        }
    }

    let result = [];
    let arrayOfchar = someString.split("");

    // with this we print all the char separatly 
    arrayOfchar.forEach(element => { 
        result.push(element);  
    });
        
    // we find combination fro every char
    while (arrayOfchar.length !== 0){
        combination();
        arrayOfchar.shift();
    }
    return result;
}

console.log(passValue ("1234"));