 

let fields = ["FirstName","Lastname", "Email","Password","Submit" ];
 
let form = document.createElement("form");
let fieldset = document.createElement("fieldset");
form.appendChild(fieldset);
document.body.appendChild(form);

// Note that there will be confilct if some of the id are ===
function createInputAndLableForText(Field_name)
{
    let fieldsetNode = document.querySelector("fieldset");
    let element =Field_name;

    let label = document.createElement("label");
    label.setAttribute("for", `${element}`);
    let textNode = document.createTextNode(`${element}  `);
    label.appendChild(textNode);
    fieldsetNode.appendChild(label);

    let inputField = document.createElement("input");
    inputField.setAttribute("type", "text");
    inputField.setAttribute("name", element);
    inputField.setAttribute("id", element);
    fieldset.appendChild(inputField);
    fieldset.innerHTML += "</br></br>";
}

function createInputAndLableForEmail(Field_name)
{
    let fieldsetNode = document.querySelector("fieldset");
    let element =Field_name;

    let label = document.createElement("label");
    label.setAttribute("for", `${element}`);
    let textNode = document.createTextNode(`${element}  `);
    label.appendChild(textNode);
    fieldsetNode.appendChild(label);

    let inputField = document.createElement("input");
    inputField.setAttribute("type", "Email");
    inputField.setAttribute("name", element);
    inputField.setAttribute("id", element);
    fieldset.appendChild(inputField);
    fieldset.innerHTML += "</br></br>";
}

function createInputAndLableForPassword(Field_name)
{
    let fieldsetNode = document.querySelector("fieldset");
    let element =Field_name;

    let label = document.createElement("label");
    label.setAttribute("for", `${element}`);
    let textNode = document.createTextNode(`${element}  `);
    label.appendChild(textNode);
    fieldsetNode.appendChild(label);

    let inputField = document.createElement("input");
    inputField.setAttribute("type", "password");
    inputField.setAttribute("name", element);
    inputField.setAttribute("id", element);
    fieldset.appendChild(inputField);
    fieldset.innerHTML += "</br></br>";
}

function createButton()
{
    let fieldsetNode = document.querySelector("fieldset");
    let inputField = document.createElement("input");
    inputField.setAttribute("type", "button");
    inputField.setAttribute("value", "Submit");
    fieldset.appendChild(inputField);
    fieldset.innerHTML += "</br></br>";
}
 
function createAllFields ()
{
    createInputAndLableForText(fields[0]);
    createInputAndLableForText(fields[1]);
    createInputAndLableForEmail(fields[2]);
    createInputAndLableForPassword(fields[3]);
    createButton();
}

createAllFields();




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