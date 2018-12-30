let arrayOfobjects = [];

// experimenting  with JS 

// making the request synchronous
/*window.onload =  function () 
{
    for (let i = 1; i < 4; i++)
    {
        let xhr = new XMLHttpRequest();
        xhr.open('GET',  `https://swapi.co/api/people/${i}`, false);
        xhr.send();
        arrayOfobjects.push(resultParsed);

        console.log(resultParsed); 
        console.log(xhr.readyState)
        console.log(xhr.status)
        let resultParsed = JSON.parse(xhr.response);
        $("#request").removeAttr("disabled");
    }
}; */


//making the request Asynchronous
/* window.onload =  function () 
{
    for (let i = 1; i < 4; i++)
    {
        let xhr = new XMLHttpRequest();
        xhr.open('GET',  `https://swapi.co/api/people/${i}`);
        xhr.send();

        xhr.onload = function () 
        {
          if (xhr.status >= 200 && xhr.status < 300) 
          {
            console.log('The request succeeded!');
            let resultParsed = JSON.parse(xhr.response);
            arrayOfobjects.push(resultParsed);
            //there is a bug if the third response is significantly faster then the other
            if (i === 3) {$("#request").removeAttr("disabled");}
          } 
          else 
          {
            console.log('The request failed!');
            console.log(xhr.responseText);
            //there is a bug if the third response is significantly faster then the other
            if (i === 3) {$("#request").removeAttr("disabled");}
          }
        };
    }
};  */

$(() =>
{
    for (let i = 1; i < 4; i++) 
    {
        $.ajax(
        {
            url: `https://swapi.co/api/people/${i}`,
            success: function (response) 
            {  
                console.log("The request is ok");
                arrayOfobjects.push(response);
                //there is a bug if the third response is significantly faster then the other
                if(i === 3) {$("#request").removeAttr("disabled");}
            },

            error: function (response) 
            {  
                console.log("The request failed");
                console.log(response.responsetext);
                  //there is a bug if the third response is significantly faster then the other
                if(i === 3) {$("#request").removeAttr("disabled");}
            }
        })
        
    }
});


$("#request").one("click",eventHandler);

function eventHandler ()
{
    printNames ()
    printMassAndHeight ()
}
function printNames ()
{
    for (const element of arrayOfobjects) 
    {
        $(`<li> ${element.name} </li>`).appendTo("#list");
    }
}

function printMassAndHeight ()
{
    let highest =  {
        height: 0,
        mass: 0
    }; 
    let heaviest = 
    {
        height: 0,
        mass: 0
    };
    
    for (const element of arrayOfobjects) 
    {
        //need check if the difrent persons has the same height
        if ( parseInt(element.height) > highest.height) {highest = element; }
        //need check if the difrent persons has the same mass
        if(parseInt(element.mass) > heaviest.mass ) {heaviest = element; }
    }
    let hString = `The person ${highest.name} is the highest! (${highest.height}); `
    let mString = `The person ${heaviest.name} is the heaviest! (${heaviest.mass})`

    $("#data").text(hString + mString );
}