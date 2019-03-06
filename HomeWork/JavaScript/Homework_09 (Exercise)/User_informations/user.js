$("button").on("click", getInputValues);

function getInputValues ()
{
    if(!checkForEmptyInputs()) 
    { $("#check").text("Please insert all the inputs");}
    else
    { 
        createRowWithValues();
        $("#check").text("");
    }
}

function checkForEmptyInputs ()
{
    let check;
    for (let i = 4; i <= 4*4; i += 4) // inputs are 4*n child in html
    {
       if ($(`div input:nth-child(${i})`).val()  === "" ) 
       {check = false; break;}
       else { check = true}
    }
    return check;
}

function createRowWithValues ()
{
    let row = $("<tr>");
    for (let  i = 4; i <= 4*4; i += 4) 
    {
        let tdValue = $(`div input:nth-child(${i})`).val();
        $("<td>").text(`${tdValue}`).appendTo(row);
    }
    row.appendTo("tbody");
}