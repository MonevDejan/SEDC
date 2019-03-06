$("<div>").css({"float": "left", "width" : "400px", "height" : "400px", "background-color": "blue"})
.insertBefore("script");

$("div").mouseenter(handler);

function handler()
{
    let floatLeft = "float: left; width: 400px; height: 400px; background-color: blue;";
    let floatRifgt ="float: right; width: 400px; height: 400px; background-color: blue;";

    if($("div").attr("style") === "float: left; width: 400px; height: 400px; background-color: blue;" )
    { $("div").attr("style", floatRifgt); }
    else
    {$("div").attr("style", floatLeft); }
}