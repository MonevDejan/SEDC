let fields = ["FirstName","Lastname", "Email","Password","Submit" ];

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

function createButtonSubmit()
{
    let inputField = document.createElement("input");
    inputField.setAttribute("type", "button");
    inputField.setAttribute("value", "Submit");
    fieldset.appendChild(inputField);
    fieldset.innerHTML += "</br></br>";
}

function createButton()
{
    let button = document.createElement("button");
    let text = document.createTextNode("Click here to show the values");
    button.appendChild(text);
    button.addEventListener("click", createParagraph);
    document.body.appendChild(button);
}

function createParagraph ()
{
    let p = document.createElement("p");
    p.innerHTML = writeValues();
    document.body.appendChild(p);
}


function writeValues ()
{
    let string = "";
    for (let i = 0; i < fields.length -1; i++) 
    {
        let element = document.getElementById(`${fields[i]}`).value;
        string += `${fields[i]}: ${element}  </br>`;
    }
    return string;
}


 
function createAllElements()
{
    createInputAndLableForText(fields[0]);
    createInputAndLableForText(fields[1]);
    createInputAndLableForEmail(fields[2]);
    createInputAndLableForPassword(fields[3]);
    createButtonSubmit();
    createButton();
}
createAllElements();






 /*
<form>
    <fieldset>
        <label for="FirstName">Firstname:   </label>
        <input type="text" name="Firstname" id="FirstName"  />
         </br></br>
        <label for="Lastname">Lastname: </label>
        <input type="text" name="LastName" id="Lastname" />
         </br></br>
        <label for="Email">Email: &nbsp &nbsp &nbsp  </label>
        <input type="email" name="Email" id="Email" />
         </br></br>
        <label for="Password">Password: </label>
        <input type="password" name="Passwor" id="Password" />
         </br></br>
        <input type="button" value="Submit" /> </br></br>
    </fieldset>
</form> */