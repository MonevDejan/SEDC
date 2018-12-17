
function createButtonWithOnclicEvent(buttonName, eventFunction)
{
    let addButton= document.createElement("button");
    addButton.innerText = buttonName;
    addButton.addEventListener("click", eventFunction);
    return addButton;
}

function addInputField()
{
    // create label and input with id for SEO
    let container = document.getElementById("Symptom");
    let label = document.createElement("label");
    label.setAttribute("for", `Symptom ${counterForSimptom}`);
    let textNode = document.createTextNode(`Symptom ${counterForSimptom}  `);
    label.appendChild(textNode);
    container.appendChild(label);

    let inputField = document.createElement("input");
    inputField.setAttribute("type", "text");
    inputField.setAttribute("name", `Symptom ${counterForSimptom}`);
    inputField.setAttribute("id", `Symptom ${counterForSimptom}`);
    container.appendChild(inputField);
    let br = document.createElement("br");
    container.appendChild(br);
    counterForSimptom +=1;
}

function deleteSymptom()
{
    // delete one input and label
    if (counterForSimptom !== 1) 
    {
        let container = document.getElementById("Symptom");
        container.lastChild.remove(); // removes <br/>
        container.lastChild.remove(); // removes input field
        container.lastChild.remove(); // removes label
        counterForSimptom -=1;
    }
}

function saveValues()
{
    // save button is used to create or edit object

    //create new object
    if(isNaN(indexOfDecease))
    {
        let name = document.getElementById("name")
        // check if the input is empty
        if(!name.value) 
        { 
            name.setAttribute("placeholder", "Please enter name")
            return;
        }
        name.setAttribute("placeholder", "");

        let createobject = {};
        let helpArray = cycleSymptoms();
    
        if (!checkForEmptyInput) 
        { 
            assignValuesInOnject (createobject, helpArray);
            mainObjectArray.push(createobject);
            dysplayDecease();
            checkForEmptyInput = null;
        }
        else
        {
            checkForEmptyInput = null; 
            return;
        }
    }

    // edit object
    else
    {
        let helpArray = cycleSymptoms();
       
        if (!checkForEmptyInput) 
        { 
            assignValuesInOnject (mainObjectArray[indexOfDecease], helpArray);
            dysplayDecease();
            checkForEmptyInput = null; 
            indexOfDecease = NaN;
        }
        else
        {
            checkForEmptyInput = null; 
            return;
        }
    }
}

function discardValues()
{
    // remove all the input values 

    document.getElementById("name").value = ""

    for (let i = 0; i < counterForSimptom-1; i++) 
    {
        let id = `Symptom ${i+1}`;
        document.getElementById(id).value = "";
        document.getElementById(id).setAttribute("placeholder", "");
    }
}

function dysplayDecease ()
{
    let tbody = document.getElementById("tbody");
    tbody.innerText = "";

    // create rows and cell for every input
    // in the last cell create edit and delete button 
    for (let indexOfmain = 0; indexOfmain  < mainObjectArray.length; indexOfmain ++)
    {
        let row = tbody.insertRow();
        let itemNumber = row.insertCell();
        itemNumber.innerText = indexOfmain+1;

        let nameOfDecease = row.insertCell(); 
        nameOfDecease.innerText = mainObjectArray[indexOfmain].nameOfDecease;

        let arrayOfSymptoms = mainObjectArray[indexOfmain].symptomArry; 
        
        for (let indexOfsymptom = 0; indexOfsymptom < arrayOfSymptoms.length; indexOfsymptom++) 
        {
            let td = row.insertCell();
            td.innerText = arrayOfSymptoms[indexOfsymptom];
        }
        let lastCell = row.insertCell();
        let editButton = createButtonWithOnclicEvent("Edit", () => 
        {
            indexOfDecease = indexOfmain;
            let decease = mainObjectArray[indexOfmain];
            document.getElementById("name").value = decease.nameOfDecease;
            let arrayOfSymptoms = decease.symptomArry;

            for (let i = 0; i < arrayOfSymptoms.length; i++)
            {
                // if there isnt enough input fields, we need to create them
                if (!document.getElementById(`Symptom ${i+1}`)) { addInputField();}
                document.getElementById(`Symptom ${i+1}`).value = arrayOfSymptoms[i];
            } 

            // if there are more input fields, remove their value
            if (counterForSimptom-1 > arrayOfSymptoms.length)
            {
                for (let  i= arrayOfSymptoms.length+1;  i < counterForSimptom; i++) 
                { document.getElementById(`Symptom ${i}`).value = ""; }
            } 
        });

        let deleteButton = createButtonWithOnclicEvent("Delete", () => 
        {
           mainObjectArray.splice(indexOfmain, 1); // removes object from the main array
           dysplayDecease ();
        });

        lastCell.appendChild(editButton);
        lastCell.appendChild(deleteButton);
    }
}

function cycleSymptoms ()
{
     
    let helpArray = [];
    for (let i = 0; i < counterForSimptom-1; i++) 
    {
        let id = `Symptom ${i+1}`;
        let symptom = document.getElementById(id);
        // if some of the inputs are empty add placeholder
        if(!symptom.value) 
        {
            symptom.setAttribute("placeholder", "Please enter name");
            checkForEmptyInput =1;
        }
        helpArray[i] = symptom.value;
    }
    return helpArray;
}

function assignValuesInOnject (nameOfobject, someArray)
{
    let name = document.getElementById("name");
    nameOfobject.nameOfDecease = name.value;
    nameOfobject.symptomArry = someArray;

    for (let i = 0; i < counterForSimptom-1; i++) 
    {
        let id = `Symptom ${i+1}`;
        let symptom = document.getElementById(id);
        symptom.setAttribute("placeholder", "");
    }

}

function exportValues () 
{
  let text = document.getElementById("inmport/export");
  let valuesFromTable = JSON.stringify(mainObjectArray);
  text.value = valuesFromTable;
}

function importValues () 
{
  let text = document.getElementById("inmport/export");
  let externalDocument = text.value;
  let helpArray1 = JSON.parse(externalDocument);
  mainObjectArray = mainObjectArray.concat(helpArray1);
  dysplayDecease();
  text.value = "";
}

let mainObjectArray =[];
let counterForSimptom = 1;
let indexOfDecease = NaN;
let checkForEmptyInput = null;

// create buttons with event listener on click
let hr = document.getElementsByTagName("hr")[0];

document.body.insertBefore(createButtonWithOnclicEvent("Add simptom", addInputField), hr);
document.body.insertBefore(createButtonWithOnclicEvent("Delete symptom", deleteSymptom), hr);
document.body.insertBefore(createButtonWithOnclicEvent("Discard", discardValues), hr);
document.body.insertBefore(createButtonWithOnclicEvent("Save", saveValues), hr);

let textArea = document.getElementsByTagName("textarea")[0];

document.body.insertBefore(createButtonWithOnclicEvent("Export", exportValues), textArea );
document.body.insertBefore(createButtonWithOnclicEvent("Import", importValues), textArea);

let breakLine = document.createElement("br");
document.body.insertBefore(breakLine, textArea);
