function weightInChickens()
{
    let weight = parseFloat(prompt("Please enter your weight"));
    let result = weight * 2;
    let paragraph = document.getElementById("result");

    if(!isNaN(weight))
    { paragraph.innerText = `Your weight is ${weight}KG is equal to  ${result}Chickens`; }
    else
    {  paragraph.innerText = "Your input is not a number. Click the button again" }
}