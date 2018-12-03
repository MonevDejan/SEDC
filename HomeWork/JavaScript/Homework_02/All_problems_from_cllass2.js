function FortuneTeller() 
{
    let children = prompt("Please enter any number"); 
    let partner =  prompt("Please enter name");
    let location =  prompt("Please enter you favorite location");
    let job =  prompt("Please enter youd dream job title");
    let string = `"You will be a ${job} in ${location}, and married to ${partner} with ${children} kids."`;
    document.getElementById("Problem4").innerHTML = string;
}


function whichComesFirst ()
{
    let firstBook = prompt("Please enter the name of the first book"); 
    let secondBook  =  prompt("Please enter the name of the second book");
    let checkForNull = (firstBook === null) || (firstBook === null);
    
    if (checkForNull)
    {document.getElementById("Problem5").innerHTML = "Please enter valid name"; } 
    else 
    {   
        let checkForZeroString = (firstBook.length === 0) || (secondBook.length === 0);
        if (checkForZeroString) 
        {document.getElementById("Problem5").innerHTML = "Please enter valid name"; }

        else 
        {
            if (firstBook.length >= secondBook.length)  // We need to check which string is longer
            {
                for (let i = 0; i < firstBook.length; i++) 
                {
                    if (firstBook[i] === secondBook[i])    // if they are equal, check if it is the same bname. If not, continue
                    {
                        if (i ===  (firstBook.length -1)) 
                        { document.getElementById("Problem5").innerHTML = "The books have a same name";}
                        else
                        { continue; } 
                    } 
                    else
                    {   
                        if (firstBook[i] > secondBook[i]) 
                        { document.getElementById("Problem5").innerHTML = "The second book goes first";}   // it is in reverse order because b has higher value than a
                        else {document.getElementById("Problem5").innerHTML = "The first book goes first";}
                    }                
                }
            } 
            else 
            {
                for (let i = 0; i < secondBook.length; i++) 
                {
                    if (firstBook[i] === secondBook[i]) 
                    {
                        continue;
                    } 
                    else
                    {   
                        if (firstBook[i] > secondBook[i]) 
                        { document.getElementById("Problem5").innerHTML = "The first book goes first"; } 
                        else { document.getElementById("Problem5").innerHTML ="The second book goes first"; }
                    }
                }
            }
        } 
    }
}


function maxOfThree()
{
    let number1 = prompt("Please enter the first number"); 
    let number2 = prompt("Please enter the second number");
    let number3 = prompt("Please enter you third number");
    let maxNumber = Math.max(number1, number2, number3);
    document.getElementById("Problem6").innerHTML = `The maximum number is ${maxNumber}`;
}