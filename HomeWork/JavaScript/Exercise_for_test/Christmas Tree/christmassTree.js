function christmassTreeBody (someNumber)
{   
    $("#number").text("");
    if(someNumber < 0) { someNumber *=-1;}
    let treeRow = [];
    let wide = someNumber*2 -1;

    for (let index = 0; index < wide ; index++) { treeRow[index] = "&nbsp;"; }

    for (let i = 1; i <= someNumber; i++) 
    {
        for (let j = (someNumber -i) ; j < (someNumber -1) + i; j++) 
        { treeRow[j] = "*"; }

        $("#number").append("<br/>");
        $("#number").append(treeRow.join(""));
    }
    for (let index = 0; index < wide ; index++) { treeRow[index] = "&nbsp;"; }

    treeRow[someNumber-1] = "*";
    $("#number").append("<br/>");
    $("#number").append(treeRow.join(""));
    $("#number").append("<br/>");
    $("#number").append(treeRow.join(""));
    
}

function handler ()
{
    let inputValue = $("#input").val();
    let parseValue = parseInt(inputValue);
    if(!parseValue) { $("#number").text("Please insert valid integer number"); }
    else
    {
        if(inputValue.length  === parseValue.toString().length )
        {
            christmassTreeBody (parseValue);
        }
        else
        { $("#number").text("Please insert valid integer number");}
    }
}

$("button").on("click", handler);