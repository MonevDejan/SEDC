/* This code has the following logic:
    1. Input a number from console
    2. Puting digits in array
    3. Writing function that write number to word that uses 2digts as input
    4. Writing functon that write number to word  that uses 3digts as input 
    5. Put the 3digit function in a loop and give 3 values to the function
    6. Showing the result
*/

// we need all of this element 
let oneTo19 = ["еден", "два", "три", "четири", "пет", "шест","седум", 
"осум", "девет", "десет", "единаесет", "дванаесет", 
"тринаесет", "четиринаесет","петнаесет", "шеснаесет",
"седумнаесет", "осумнаесет", "деветнаесет",]

let decade = ["дваесет", "триесет", "четириесет", "педесет", "шеесет", "седумдесет", "осумдесет", "деведесет"];
let hundrets = ["сто", "двестотини" , "тристотини", "четиристотини", "петстотини", "шестотини", "седумстотини", "осумстотини", "деветстотини" ]

// element with index[0] and index[1] are just empty string to match the counter in the code below
let cardinal = ["", "","илјада","милион", "билион", "трилион", "квадрилион"];
let suffixCardinal = ["", "", "илјади","милиони","билиони","трилиони","квадрилиони"]; 

let number;  // global scope

// Put the digits from number in array
function DigitsInArry (number)  
{    
    let arryOfdigits = [];
    while (number !== 0) 
    {
        let units = number % 10;
        arryOfdigits.unshift(units);
        number = Math.floor(number / 10)
    }
    return arryOfdigits;
}

 //writnig number to words for 2 digit number
function naming2digitnumber(a , b)  
{
    let string ="";
    let wholenumber = (a*10)+b;

    // if the number is smaler than 20, we have the values in array oneTo19
    if(wholenumber <20)            
    { 
        if(number < 20)    //number is number that we entered
        {
            string += oneTo19[wholenumber-1];
            return string;
        }
        else
        {
            string += "и " + oneTo19[wholenumber-1];  // adding "и " 
            return string;
        }
    }
    else
    {
        if(b === 0 )              
        {
            if(number < 100)    //number is number that we entered
            {
            string += decade[a-2];
            return string;
            }
            else
            {
                string +=" и " + decade[a-2];
                return string;
            }
        }
        else
        {
            string += decade[a-2] + " и " + oneTo19[b-1]; // connecting the strings together 
            return string;
        }
    } 
}

//writnig number to words for 2 digit number with slight modification for iljada
function naming2digitnumberForiljadi(a , b)   
{
    let string ="";
    let wholenumber = (a*10)+b;

    if(wholenumber <20)
    { 
        // this is the only diference from the function above
        switch (b)               
        {
            case 1:  return string+="една";
            case 2:  return string+="две";
            default: { string = oneTo19[wholenumber-1]; return string;}
        }
    }
    else
    {
        if(b === 0 )
        {
            if(number < 100)    //number is number that we entered
            {
            string += decade[a-2];
            return string;
            }
            else
            {
                string +="и " + decade[a-2]; //adding "и " 
                return string;
            }
        }
        else
        {
            string += decade[a-2] + " и " + oneTo19[b-1];
            return string;
        }
    } 
}

//writnig number to words for 3 digit number useing the 2digit function for 
function naming3digitnumber(x , y, z) 
{
    let string ="";
    // if there is no number, just return the empty string
    if(x+y+z === 0)        
    { return string; }
    else
    {
        // this check is to see if the number is only hundrets
        if((y === 0) && (z === 0))    
        {
            if(number < 1000)
            {
                string += hundrets[x-1];
                return string;
            }
            else
            {
                string += " и " + hundrets[x-1]; //adding "и " 
                return string;
            }
        }
        else
        {
            // this check is to see if the number is only decades
            if(x === 0 )      
            {
                string += naming2digitnumber(y,z);
                return string;
            }
            else
            {
                string += hundrets[x-1] +" " + naming2digitnumber(y,z);
                return string;
            }
        }
    }
}

//writnig number to words for 3 digit number useing the 2digit function for iljada
function naming3digitnumberForIljadi(x , y, z) 
{
    let string ="";

    if(x+y+z === 0)
    { return string; }
    else
    {
        if((y === 0) && (z === 0))
        {
             if(number < 1000)
            {
                string += hundrets[x-1];
                return string;
            }
            else
            {
                string += " и " + hundrets[x-1];
                return string;
            }
        }
        else
        {
            if(x === 0 )
            {
                string += naming2digitnumberForiljadi(y,z);
                return string; 
            }
            else
            {
                if((y < 2) || (z === 0))
                {
                    string += hundrets[x-1] + " и " + naming2digitnumberForiljadi(y,z);
                    return string;
                }
                else
                {
                    string += hundrets[x-1] + " " + naming2digitnumberForiljadi(y,z);
                    return string;
                }
            }
        }
    }
}

function NumberToWords()
{
    let r = prompt("insert your number");
    number = parseInt(r);
    
    // To check if the input is number or string   
    if(isNaN(number))        
    {   document.getElementById("number").innerHTML = "Incorect input!  Check your number";}
    else
    {
        let numberToWords = "";
        let array= DigitsInArry(number);

        /*  Because we are giving 3 values in funciton naming3digitnumber,
            we need to be sure that those values are numbers.
            With this code we  simply add 0 in fornt of the number */
        switch (array.length % 3)               
        {
            case 0: break;
            case 1: array.unshift(0,0); break;
            case 2: array.unshift(0); break;
        }
        
        let numberOfcycle = array.length / 3;    
        let counterForIljada = array.length / 3;
    
        for (let index = 0; index < numberOfcycle; index++) 
        {
            // Taking the digits from the array
            let first_digit = array.shift();
            let second_digit = array.shift();
            let third_digit = array.shift();
            
            /*  Becase of the difrent nature of  "iljada" and "iljadi" we need to write the same code twice
                with slight diffrence in which function is called */

            // Code for iljadi   
            if(counterForIljada === 2)
            {   
                if(third_digit === 1)
                {
                    numberToWords +=  naming3digitnumberForIljadi (first_digit, second_digit, third_digit)+ " "; // return te representation to words form 3digit number
                    if(first_digit + second_digit + third_digit !== 0)   // if there is 000 dont add cardinal
                    {numberToWords += cardinal[numberOfcycle-index]+ " ";}  // adding the cardinal
                }
                else
                {
                    numberToWords +=  naming3digitnumberForIljadi (first_digit, second_digit, third_digit)+ " ";
                    if(first_digit + second_digit + third_digit !== 0)
                    { numberToWords += suffixCardinal[numberOfcycle-index]+ " ";} 
                }
            }
            // Code for iljada
            else
            {
                if(third_digit === 1)
                {
                    numberToWords += naming3digitnumber (first_digit, second_digit, third_digit)+ " ";
                    if(first_digit + second_digit + third_digit !== 0)
                    { numberToWords += cardinal[numberOfcycle-index]+ " ";} 
                }
                else
                {
                    numberToWords += naming3digitnumber (first_digit, second_digit, third_digit)+ " ";
                    if(first_digit + second_digit + third_digit !== 0)
                    {numberToWords += suffixCardinal[numberOfcycle-index]+ " ";} 
                }
            }
            counterForIljada -=1;
        }
        // this check is if the number is zero (0)
        if(numberToWords !== "")
        {
            // we need to erase the " и " in fornt of the code :D
            let checkForI = numberToWords.slice(0,3);
            let checkForII = numberToWords.slice(0,2);
            if(checkForI === " и ")
            { document.getElementById("number").innerHTML = `You imput ${number} and the word representation is <br/> ${numberToWords.slice(3)}`;} 
            if( checkForII === "и " )
            { document.getElementById("number").innerHTML = `You imput ${number} and the word representation is <br/> ${numberToWords.slice(2)}`;}
            else
            {document.getElementById("number").innerHTML = `You imput ${number} and the word representation is <br/> ${numberToWords}`; }
        } 
        else
        {document.getElementById("number").innerHTML = `You imput ${number} and the word representation is <br/> нула`;}
    }
} 
//9 007 199 254 740 991      9007199254740991
//1 101 101 101 101 101      1101101101101101