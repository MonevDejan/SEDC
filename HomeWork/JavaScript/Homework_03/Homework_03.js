function SpecificRange (minvalue = prompt("Insert minvalue"), maxvalue = prompt("Insert maxvalue"))
{
    let min = parseFloat(minvalue);
    let max = parseFloat(maxvalue);
    // Formula for generating random number in specific range
    let value = Math.random() *(max-min) + min; 
    //Validation
    if (isNaN(value)) 
    {  document.getElementById("number").innerHTML = "Incorect input! Check your number";} 
    else 
    {  document.getElementById("number").innerHTML = value; }
}

function RangeFrom_1_100()
{
    let value = Math.random() *(100-1) + 1;
    document.getElementById("number").innerHTML = value;
}

function RangeFrom_1_1000()
{
    let value = Math.random() *(1000-1) + 1;
    document.getElementById("number").innerHTML = value;
}
function RangeFrom_18_26()
{
    let value = Math.random() *(26-18) + 18;
    document.getElementById("number").innerHTML = value;
}

/* This is just to meet the requirement: reuse the convet function

function SpecificRangeWithotPrompt (minvalue, maxvalue)
{
    let min = parseFloat(minvalue);
    let max = parseFloat(maxvalue);
    let value = Math.random() *(max-min) + min; 
    if (isNaN(value)) 
    {  return "Incorect input! Check your number";} 
    else 
    {  return value; }
}
function RangeFrom_1_100()
{    let value = SpecificRangeWithotPrompt(1,100)
    return value;
}
function RangeFrom_1_1000()
{    let value = SpecificRangeWithotPrompt(1,1000)
    return value;
}
function RangeFrom_18_26()
{    let value = SpecificRangeWithotPrompt(18,26)
    return value;
} */