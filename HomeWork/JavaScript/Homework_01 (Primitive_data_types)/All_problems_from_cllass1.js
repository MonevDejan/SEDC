/* Problem 1: */
function feetToMeters()
{   let feetLenght = prompt("Enter the number of feet");

    /*This is validation if the users input is a number.  
    First we need to check if he pressed cancel. 
    Second we need to checl if he enters only "spaces" 
    Last check is if the string can be converted to number*/
    if ((feetLenght === null)) 
    {
        document.getElementById("problem1").innerHTML = `Invalid number!`;
    } 
    else 
    {   feetLenght = feetLenght.trim();
        if ((feetLenght.length === 0)) 
        {
            document.getElementById("problem1").innerHTML = `Invalid number!`;
        } 
        else 
        {
            feetLenght = Number(feetLenght);
            if (!(isNaN(feetLenght))) 
            {   const conversionToMetters = 0.3048;
                let meters = feetLenght * conversionToMetters;
                document.getElementById("problem1").innerHTML = 
                `The lenght of feet ${feetLenght} is equal to  ${meters} meters`;
            } 
            else 
            {
                document.getElementById("problem1").innerHTML = `Invalid number!`;
            }
        }
    } 
}
/* Problem 2: */
function rectangleArea()
{   let width = prompt("Enter the width");
    let height= prompt("Enter the height");

    /*This is the same validation as the problem1  */
    if ((width === null) || height === null ) 
    {
        document.getElementById("problem2").innerHTML = `Invalid numbers!`;
    } 
    else 
    {   
        width = width.trim();
        height = height.trim();
        if ((height.length === 0) || (width.length === 0)) 
        {
            document.getElementById("problem2").innerHTML = `Invalid numbers!`;
        } 
        else 
        {   width = Number(width);
            height= Number(height);

            if (!(isNaN(width)) && !(isNaN(height))) 
            { 
                let area = width * height;
                document.getElementById("problem2").innerHTML = 
                `The area of  ${width} and ${height} is equal to ${area}`;
            } 
            else 
            {
                document.getElementById("problem2").innerHTML = `Invalid numbers!`;
            }
        }
    } 
}
/* Problem 3: */
function circleArea()
{   let radius = prompt("Enter the value of radius");

     /*This is the same validation as the problem1  */
    if ((radius === null)) 
    {
        document.getElementById("problem3").innerHTML = `Invalid number!`;
    } 
    else 
    {   radius = radius.trim();
        if ((radius.length === 0)) 
        {
            document.getElementById("problem3").innerHTML = `Invalid number!`;
        } 
        else 
        {
            radius = Number(radius);
            if (!(isNaN(radius))) 
            {   const pi = 3.14;
                let area = radius*radius*pi;
                document.getElementById("problem3").innerHTML = 
                `The are of circle with radius ${radius} is equal to  ${area}`;
            } 
            else 
            {
                document.getElementById("problem1").innerHTML = `Invalid number!`;
            }
        }
    } 
}


let phonePrice = 119.95;
const taxRate = 1.05; // This is 5% tax rate
let numberOfPhones = 30;
let price;
price = phonePrice * taxRate * numberOfPhones;
document.getElementById("problem4").innerHTML = `Solution 4: The price is ${price}`;
console.log(`The price is ${price}`);  