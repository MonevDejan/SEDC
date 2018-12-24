function createArray (start, finish)
{
    if( start < finish )
    {
        let cycle = finish - start;
        let someArray = [];
    
        for (let i = 0; i <= cycle ; i++) 
        { someArray[i] = start + i; }

        return someArray;
    }
    else
    {
        let cycle = start - finish;
        let someArray = [];

        for (let i = 0; i <= cycle ; i++) 
        { someArray[i] = start - i; }

        return someArray;
    }
}

function handler ()
{
    let inputStart = $("#start").val();
    let inputFinish = $("#finish").val();

    let parseStart = parseInt(inputStart);
    let parseFinish = parseInt(inputFinish);
    let check = (parseStart && parseFinish);
    let checkZero = (parseFinish === 0) || (parseStart === 0);

    if (!check && !checkZero) { $("#number").text("Please insert valid integer numbers"); }
    else
    {
        let checkStart =  (inputStart.length === parseStart.toString().length);
        let checkFinish =  (inputFinish.length ===  parseFinish.toString().length);

        if(checkStart && checkFinish)
        {
            let array = createArray (parseStart, parseFinish);
            $("#number").text(array);
        }
        else
        { $("#number").text("Please insert valid integer numbers");}
    }
}

$("button").on("click", handler);