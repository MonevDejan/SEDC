$( document ).on( "mousemove", function(eventObject) 
{
    let left = eventObject.pageX;
    let top = eventObject.pageY;

    $("#log" ).text( `From Left: ${left}, From Top: ${top}`);
});