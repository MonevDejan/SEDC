let distance = parseFloat(prompt("Insert the distance in km"));

let car = {   
    model: "volkswagenGolf",
    color: "blue",
    year: 1996,
    fuelType: "diesel",
    fuelConsumptiion: 0.065,
    requiredFuelForKM: function (km) 
    { return (km*this.fuelConsumptiion); } 
}

if (!isNaN(distance))
{
    if (distance < 0) 
    { document.getElementById("paragraph").innerHTML = "Your input should be greater than 0"; }
    else
    { document.getElementById("paragraph").innerHTML = `The car will travel ${car.requiredFuelForKM(distance)} km`; } 
}
else
{ document.getElementById("paragraph").innerHTML = "Your input is not a number"; }