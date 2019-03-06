let rows = parseInt(prompt("Insert the number of rows"));
let colums = parseInt(prompt("Insert the number of colums"));

let script = document.querySelector("script");
function createTable()
{
    let table = document.createElement("table");
    table.setAttribute("style", "border-collapse: collapse")
    let tablebody = document.createElement("tbody");
    table.appendChild(tablebody);
    document.body.insertBefore(table, script);
}
function valuesInTable(rows, colums)
{
    let tablebody = document.querySelector("tbody");
    tablebody.innerText = "";
    for (let countRows = 0; countRows < rows; countRows++)
    {
        let trow = document.createElement("tr");
        for (let countColums = 0; countColums< colums; countColums++) 
        {
            let td = document.createElement("td");
            td.innerHTML= `<sup> R${countRows+1},C${countColums+1} </sup>`;
            td.setAttribute("style", `border: 1px solid black; background-color:rgb( ${specificRange()},${specificRange()}, ${specificRange()});` );
            // td.setAttribute()
            trow.appendChild(td);
        }
        tablebody.appendChild(trow);
    }
}

function specificRange ()
{
    // Formula for generating random number. To avoid black color it is user from  100 to 225
    let value = Math.random() *(225-100) + 100; 
    return value;
}


if (!isNaN(rows )  &&  !isNaN(colums) )
{
    if (rows < 1 || colums < 1 ) 
    { document.getElementById("paragraph").innerHTML = "Your input should be greater than 0"; }
    else
    {
        createTable();
        valuesInTable(rows, colums);
    } 
}
else
{ document.getElementById("paragraph").innerHTML = "Your input is not a number"; }

