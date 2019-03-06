$(() =>
{

function createButtonWithOnclicEvent(buttonName, eventFunction)
{
    let addButton= $("<button>");
    addButton.text(buttonName);
    addButton.on("click", eventFunction);
    return addButton;
}

function addInputField()
{
    $("<label>").attr("for", `Symptom_${counterForSimptom}`)
    .text(`Symptom ${counterForSimptom}  `)
    .appendTo("#Symptom");

    $("<input>").attr({"type": "text", "name" : `Symptom ${counterForSimptom}`,"id": `Symptom_${counterForSimptom}`})
    .appendTo("#Symptom");
    $("<br/>").appendTo("#Symptom");
    counterForSimptom +=1;
}

function deleteSymptom()
{
    // delete one input and label
    if (counterForSimptom !== 1) 
    {
        $("div br:last").remove();
        $("div input:last").remove();
        $("div label:last").remove();
        counterForSimptom -=1;
    }
}

function saveValues()
{
    // save button is used to create or edit object

    //create new object
    if(isNaN(indexOfDecease))
    {
        let name = $("#name");
        // check if the input is empty
        if(!name.val()) 
        { 
            name.attr("placeholder", "Please enter name");
            return;
        }
        name.attr("placeholder", "");

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
    $(`#name`).val("");

    for (let i = 0; i < counterForSimptom-1; i++) 
    {
        let id = `#Symptom_${i+1}`;
        $(`${id}`).val("");
        $(`${id}`).attr("placeholder", "");
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
                if (!document.getElementById(`Symptom_${i+1}`)) { addInputField();}
                document.getElementById(`Symptom_${i+1}`).value = arrayOfSymptoms[i];
            } 

            // if there are more input fields, remove their value
            if (counterForSimptom-1 > arrayOfSymptoms.length)
            {
                for (let  i= arrayOfSymptoms.length+1;  i < counterForSimptom; i++) 
                { document.getElementById(`Symptom_${i}`).value = ""; }
            } 
        });

        let deleteButton = createButtonWithOnclicEvent("Delete", () => 
        {
           mainObjectArray.splice(indexOfmain, 1); // removes object from the main array
           dysplayDecease ();
        });

        deleteButton.appendTo(lastCell);
        editButton.appendTo(lastCell);
    }
}

function cycleSymptoms ()
{
     
    let helpArray = [];
    for (let i = 0; i < counterForSimptom-1; i++) 
    {
        let id = `#Symptom_${i+1}`;
        let symptom = $(`${id}`);


        // if some of the inputs are empty add placeholder
        if(!symptom.val()) 
        {
            symptom.attr("placeholder", "Please enter name");
            checkForEmptyInput =1;
        }
        helpArray[i] = symptom.val();
    }
    return helpArray;
}

function assignValuesInOnject (nameOfobject, someArray)
{
    let name = $("#name");
    nameOfobject.nameOfDecease = name.val();
    nameOfobject.symptomArry = someArray;

    for (let i = 0; i < counterForSimptom-1; i++) 
    {
        let id = `#Symptom_${i+1}`;
        let symptom = $(`${id}`);;
        symptom.attr("placeholder", "");
    }

}

function exportValues () 
{
  let valuesFromTable = JSON.stringify(mainObjectArray);
  $("#inmportexport").val(valuesFromTable);
}

function importValues () 
{
  let externalDocument = $("#inmportexport").val();
  let helpArray1 = JSON.parse(externalDocument);
  mainObjectArray = mainObjectArray.concat(helpArray1);
  dysplayDecease();
  $("#inmportexport").val("");
}

let mainObjectArray =[];
let counterForSimptom = 1;
let indexOfDecease = NaN;
let checkForEmptyInput = null;

// create buttons with event listener on click
// let hr = document.getElementsByTagName("hr")[0];

// document.body.insertBefore(createButtonWithOnclicEvent("Add simptom", addInputField), hr);
// document.body.insertBefore(createButtonWithOnclicEvent("Delete symptom", deleteSymptom), hr);
// document.body.insertBefore(createButtonWithOnclicEvent("Discard", discardValues), hr);
// document.body.insertBefore(createButtonWithOnclicEvent("Save", saveValues), hr);

$(createButtonWithOnclicEvent("Add simptom", addInputField)).insertBefore("hr");
$(createButtonWithOnclicEvent("Delete symptom", deleteSymptom)).insertBefore("hr");
$(createButtonWithOnclicEvent("Discard", discardValues)).insertBefore("hr");
$(createButtonWithOnclicEvent("Save", saveValues)).insertBefore("hr");

 let textArea = document.getElementsByTagName("textarea")[0];

// document.body.insertBefore(createButtonWithOnclicEvent("Export", exportValues), textArea );
// document.body.insertBefore(createButtonWithOnclicEvent("Import", importValues), textArea);

$(createButtonWithOnclicEvent("Export", exportValues)).insertBefore("textarea");
$(createButtonWithOnclicEvent("Import", importValues)).insertBefore("textarea");

// let breakLine = document.createElement("br");
// document.body.insertBefore(breakLine, textArea);
$("<br/>").insertBefore("textarea");
})