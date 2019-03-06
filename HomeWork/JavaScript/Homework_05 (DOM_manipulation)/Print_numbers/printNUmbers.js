function fulfillmentAnArray (lenghtOfarry)
{
    let arrayOfnumbers = [];
    for (let index = 0; index < lenghtOfarry; index++)
    {
        let elementInArry = parseInt(prompt("Insert the value of elements (only numbers)"));
        if(!isNaN(elementInArry))
        { arrayOfnumbers[index] = elementInArry; }
    }
    return arrayOfnumbers;
}

function creatingList(value)
{   
    let array = value;
    let list = document.createElement("ul");    // creating a list node   
    // creating the list body
    for (let index = 0; index < array.length; index++) 
    {   
        let listItem = document.createElement("li");                
        let text = document.createTextNode(array[index]);  
        listItem.appendChild(text);                                
        list.appendChild(listItem);
    }
    // inserting list in the DOM
    let button = document.querySelector("button");
    document.body.insertBefore(list, button);
}

function concatinatingElementrsFromArray(value)
{
    let string = value.join("+");
    return string;
}

function sumOfArray(value)
{
    let sum = 0;
    for (let i = 0; i < value.length; i++) {
        sum += value[i];
    }
    return sum;
}

function createParagraph(value)
{
    let array = value;
    let p = document.createElement("p");
    let text = document.createTextNode(`The sum is ${sumOfArray(array)}. Values are ${concatinatingElementrsFromArray(array)}`);
    p.appendChild(text);
    let button = document.querySelector("button");
    document.body.insertBefore(p, button);
}

function printingNubersInList()
{
    let numberOfelements = parseInt(prompt("Please insert the number of elements"));
   
    if(!isNaN(numberOfelements) && (numberOfelements > -1))
    { 
        let array = fulfillmentAnArray(numberOfelements);
        creatingList(array);
        createParagraph(array);
    }
    else
    { 
        let p = document.createElement("p");
        p.innerText += "Invalid input";
        document.body.appendChild(p);
    }
}
