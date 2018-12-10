
function createAnimalObject(name, kind, say)
{
    if (name === null || name === "" ) {name ="Sharko" }
    if (kind === null || kind === "" ) {kind ="kuce" }
    if (say === null ||  say  === "" ) {say ="Ne lae po domasni" }

    let parametars = 
    {
        name: name,
        kind: kind,
        say: say,
        speak: function() { document.getElementById("paragraph").innerText = `The ${this.name} says, ${this.say}` }
    }
    return parametars;
}


let name = prompt("Name of the animal");
let kind = prompt("Kind of the animal");
let say = prompt("What animal says?");


let animal = createAnimalObject(name, kind, say);
animal.speak();


