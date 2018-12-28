$("#request").one("click", function () 
{
    $.ajax(
    {
        url: "https://api.openaq.org/v1/measurements?country=MK&city=Centar+Municipality&parameter=pm10&date_from=2018-12-20&date_to=2018-12-21",
        success: function (response) 
        { successHandler(response) },

        error: function (response) 
        { errorHandler(response) }
    })
});

function successHandler(response)
{
    console.log("The request is ok");
    writeInH1(getAverage(response));
}

function errorHandler(response)
{
    console.log("The request failed");
    console.log(response.responsetext);
}

function getAverage(parsedValue)
{
    let array = parsedValue.results;
    let pmAllValue = [];

    for (const element of array) 
    { pmAllValue.push(element.value); }
        
    let expresion = (sum, value) => sum + value;
    let sum = pmAllValue.reduce(expresion);

    let average = sum/pmAllValue.length;

    return Math.floor(average);
}

function writeInH1(someValue)
{ $("#header").text(`The average pm is ${someValue}`);  }
