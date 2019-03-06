let fields = ["FirstName","Lastname", "Email","Password"];

let script = document.querySelector("script");
let form = document.createElement("form");
form.setAttribute("action", " ");
form.setAttribute("method", "post");
let fieldset = document.createElement("fieldset");
form.appendChild(fieldset);
document.body.insertBefore(form, script);

// Note that there will be confilct if some of the id are ===
function createInputAndLableForText(Field_name)
{
    let element =Field_name;

    let label = document.createElement("label");
    label.setAttribute("for", `${element}`);
    let textNode = document.createTextNode(`${element}  `);
    label.appendChild(textNode);
    fieldset.appendChild (label);

    let inputField = document.createElement("input");
    inputField.setAttribute("type", "text");
    inputField.setAttribute("name", element);
    inputField.setAttribute("id", element);
    fieldset.appendChild(inputField);
    fieldset.innerHTML += "</br></br>";
}

function createInputAndLableForEmail(Field_name)
{
    let element =Field_name;

    let label = document.createElement("label");
    label.setAttribute("for", `${element}`);
    let textNode = document.createTextNode(`${element}  `);
    label.appendChild(textNode);
    fieldset.appendChild(label);

    let inputField = document.createElement("input");
    inputField.setAttribute("type", "Email");
    inputField.setAttribute("name", element);
    inputField.setAttribute("id", element);
    fieldset.appendChild(inputField);
    fieldset.innerHTML += "</br></br>";
}

function createInputAndLableForPassword(Field_name)
{
    let element =Field_name;

    let label = document.createElement("label");
    label.setAttribute("for", `${element}`);
    let textNode = document.createTextNode(`${element}  `);
    label.appendChild(textNode);
    fieldset.appendChild(label);

    let inputField = document.createElement("input");
    inputField.setAttribute("type", "password");
    inputField.setAttribute("name", element);
    inputField.setAttribute("id", element);
    fieldset.appendChild(inputField);
    fieldset.innerHTML += "</br></br>";
}

function createButtonWithEventListener()
{
    let button = document.createElement("button");
    let text = document.createTextNode("Click here to print values in table");
    button.appendChild(text);
    button.addEventListener("click", valuesInTable);
    document.body.appendChild(button);
}
function createTable()
{
    let table = document.createElement("table");
    let tablebody = document.createElement("tbody");
    table.appendChild(tablebody);
    // table.setAttribute("border-collapse", "collapse");
    document.body.insertBefore(table, script);
}
function valuesInTable()
{
    let tablebody = document.querySelector("tbody");
    tablebody.innerText = "";
    for (let index = 0; index < fields.length; index++)
    {
        let element = document.getElementById(`${fields[index]}`).value;
        let trow = document.createElement("tr");
        let tdata = `<td  style="border: 1px solid black">${fields[index]}</td> <td style="border: 1px solid black">${element} </td> `
        trow.innerHTML = tdata;
        tablebody.appendChild(trow);
    }
}
function createAllElements()
{
    createInputAndLableForText(fields[0]);
    createInputAndLableForText(fields[1]);
    createInputAndLableForEmail(fields[2]);
    createInputAndLableForPassword(fields[3]);
    createButtonWithEventListener();
    createTable();
}
createAllElements();
