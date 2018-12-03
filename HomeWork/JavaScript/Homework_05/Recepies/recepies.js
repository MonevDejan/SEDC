function fulfillmentAnArray (lenghtOfarry)
{
    let arrayOfnumbers = [];
    for (let index = 0; index < lenghtOfarry; index++)
    {
        let elementInArry = prompt("Insert the ingredients");
        arrayOfnumbers[index] = elementInArry; 
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

function creatingTable(value)
{
    let array = value;
    let table = document.createElement("table");
    let tableBody = document.createElement("tbody");
    
    for (let i = 0; i < array.length; i++) 
    {
        let tr = document.createElement("tr");
        let td = document.createElement("td");
        let text = document.createTextNode(array[i]);
        td.appendChild(text);
        tr.appendChild(td);
        tableBody.appendChild(tr);
    }
    table.appendChild(tableBody);
    table.setAttribute("border", "2px solid red)");

    let button = document.querySelector("button");
    document.body.insertBefore(table, button);

}

function printingList()
{
    let nameOfrecepie = prompt("Insert the name of the recepie");
    let numberOfingredients = parseInt(prompt("Insert the number of ingredients"));
    
    if(!isNaN(numberOfingredients))
    { 
        let array = fulfillmentAnArray(numberOfingredients);
        creatingList(array);
        creatingTable(array);
    }
    else
    { 
        let p = document.createElement("p");
        p.innerText += "Invalid input";
        document.body.appendChild(p);
    }
    document.title = nameOfrecepie;
    document.getElementById("recept").innerText = nameOfrecepie;
}

