function numberOfDigits (number)  
{   if( number === 0)
    {
        counter +=1;
        return counter;
    }
    else
    {
        if(number < 0) {number *= -1;} 
        let counter = 0;
        while (number !== 0) 
        {
            number = Math.floor(number / 10)
            counter +=1;
        }
        return counter;
    }
}

function even_odd (number)
{
    if(number & 1) { return "odd";}
    else { return  "even";}
}

function positive_negative (number)
{
    if (number < 0) {return "Negative";}
    else {return "Positive";}
}

function creatingObject(number)
{
    let someObject = 
    {
        numberName: number,
        numDigits:  numberOfDigits (number),
        isEven: even_odd (number),
        isPositive: positive_negative (number),
        information: function ()
        {
            let statistic = `The number ${this.numberName} 
            is a ${this.numDigits} digit number, 
            it's ${this.isEven} and 
            it's a ${this.isPositive} number.`;
            return statistic;
        }
    }
    return someObject;
}

$("button").on("click", handler);

function handler ()
{
    let inputValue = $("#input").val();
    let parseValue = parseInt(inputValue);
    if(!parseValue && (parseValue !== 0)) { $("#number").text("Please insert valid integer number"); }
    else
    {
        if(inputValue.length  === parseValue.toString().length )
        {
            let objectNumber = creatingObject(parseValue);
            $("#number").text(objectNumber.information());
        }
        else
        { $("#number").text("Please insert valid integer number");}
    }
}
