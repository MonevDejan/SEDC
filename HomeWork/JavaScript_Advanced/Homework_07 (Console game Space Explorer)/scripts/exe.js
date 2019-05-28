let crushinator = new Ship("Crushinator", 5, 540, 400, 0.2, "./img/Crushinator.png");
let SatarFighter = new Ship("StarFighter", 3, 380, 500, 0.5, "./img/StarFighter.png");
let scouter = new Ship("Scouter", 1, 300, 300, 0.9, "./img/Scouter.png");

let rubicon9 = new Planet("Rubicon9", 300000, 2000000, 4, 2, "./img/Rubicon9.png");
let r7 = new Planet("R7", 120000, 4000000, 7, 3, "./img/R7.png");
let magmus = new Planet("Magmus", 500000, 10000000, 6, 1, "./img/Magmus.png");
let dextriaey = new Planet("Dextriaey", 50000, 500000, 9, 3, "./img/Dextriaey.png");
let b181 = new Planet("B18-1", 250000, 4000000, 12, 2, "./img/B18-1.png");

let listOfShips = [crushinator, SatarFighter, scouter];
let listOfPlanets = [rubicon9, r7, magmus, dextriaey, b181];

let shipContainer = document.getElementById("shipContainer");
let planetContainer = document.getElementById("planetContainer");
let newGameContainer = document.getElementById("newGame");

let divShips = document.getElementsByClassName("ship-types")[0];
let divPlanets = document.getElementsByClassName("planets")[0];

let chosenShip;

let buttonStarNewGame = newGameContainer.getElementsByTagName("button")[0];
buttonStarNewGame.addEventListener("click", () => {
    hideContainers();
    shipContainer.classList.remove("display-none");
})

createShips(listOfShips);
createPlanets(listOfPlanets);

let allButtons = document.getElementsByTagName("button");