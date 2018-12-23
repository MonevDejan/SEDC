$("<div>").addClass("container").insertBefore("script[src='hide-show_div.js']");

function createDivWithClass (nameOfclass)
{ $("<div>").addClass(nameOfclass).text("Here is some random text").appendTo(".container"); }

function createButton(buttonName)
{ $("<button>").text(buttonName).insertBefore("script[src='hide-show_div.js']"); }

function toggle ()
{
    if($("button").text() === "Hide Div")
    { 
        $("button").text("Show Div");
        $(".firstDiv").fadeOut(500);
        $(".secondDiv").fadeOut(1000);
        $(".thirdDiv").fadeOut(1500);
    }

    else
    { 
        $("button").text("Hide Div");
        $(".firstDiv").fadeIn(500);
        $(".secondDiv").fadeIn(1000);
        $(".thirdDiv").fadeIn(1500);
    }
}

createDivWithClass ("firstDiv");
createDivWithClass ("secondDiv");
createDivWithClass ("thirdDiv");
createButton("Hide Div");
$("button").on("click", toggle);

