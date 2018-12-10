function writeDimension() 
{
    var width = outerWidth;
    var height = outerHeight;
    document.getElementById("p2").innerHTML = `Width is ${width}, height is ${height}`
}

function addAtributeToBody ()
{
   document.body.setAttribute("onload", "writeDimension()");
   document.body.setAttribute("onresize", "writeDimension()");
}

addAtributeToBody();