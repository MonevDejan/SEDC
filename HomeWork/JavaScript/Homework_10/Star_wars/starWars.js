let arrayOfobjects = [];

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
            },

            error: function (response) 
            {  
                console.log("The request failed");
                console.log(response.responsetext);
            }
        })
    }
});


