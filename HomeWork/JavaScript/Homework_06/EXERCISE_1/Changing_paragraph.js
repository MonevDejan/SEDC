// <link href="style.css" rel="stylesheet"/> 

function addLinkElementWithStyle()
{
    let link = document.createElement("link");
    link.setAttribute("href", "style.css");
    link.setAttribute("rel", "stylesheet");
    document.head.appendChild(link);
}

function createButtonWitheEvent()
{
    let button = document.createElement("button");
    let text = document.createTextNode("Click here");
    button.append(text);
    document.body.appendChild(button);  
    button.addEventListener("click", addLinkElementWithStyle);
}

 createButtonWitheEvent();



// let dugme = document.getElementById("one");
// dugme.innerText = "Click me";
// dugme.addEventListener("click", addLinkElementWithStyle);


