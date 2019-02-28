function createDivforCard() {
    let div = document.createElement("div");
    div.setAttribute("class", "card");
    div.setAttribute("style", "width: 14rem;");
    return div;
}

function createShips(listShips) {
    divShips.textContent = "";
    for (const ship of listShips) {

        //create div outside from innerHTML element to be able to select the buttons
        let div = createDivforCard();
        // create card using innerHTML
        let cardToBuild = `
             <div class="bacground_card_ship">
                <img src="${ship.img}" class="card-img-top" alt="Starship_${ship.name}">
            </div>
            <div class="card-body">
                <h5 class="card-title">${ship.name}</h5>
                <p class="card-text"> Start your journey across the sea of space
                with one of the best ships ${ship.name}.
                </p>
                <ul class="list-group list-group-flush">
                    <li class="list-group-item">Crew members: ${ship.crew} </li>
                    <li class="list-group-item">Fuel: ${ship.fuel} </li>
                    <li class="list-group-item">Hull: ${ship.hull} </li>
                    <li class="list-group-item"> Speed: ${ship.speed} </li>
                </ul>

                <button type="button" class="btn btn-primary">Take off with ${ship.name}</button>
            </div>`;

        div.innerHTML = cardToBuild;
        let button = div.getElementsByTagName("button")[0];
        button.addEventListener("click", () => {
            chosenShip = ship;
            hideContainers();
            planetContainer.classList.remove("display-none");
        })
        divShips.append(div);
    }
}

function createPlanets(listPlanets) {
    divPlanets.textContent = "";
    for (const planet of listPlanets) {

        //create div outside from innerHTML element to be able to select the buttons
        let div = createDivforCard();
        div.setAttribute("class", "card bacground_card_planet");
        // create card using innerHTML
        let cardToBuild = `
        <img src="${planet.img}" class="card-img-top" alt="Planet ${planet.name}">
        <ul class="list-group list-group-flush">
            <li class="list-group-item">Name: ${planet.name} </li>
            <li class="list-group-item">Size: ${planet.size}</li>
            <li class="list-group-item">Population: ${planet.population} </li>
            <li class="list-group-item">Distance: ${planet.distance}</li>
            <li class="list-group-item">Development: ${planet.development}</li>
        </ul>
        <div class="card-body">
            <button type="button" class="btn btn-primary btn-sm btn-block">Repair</button>
            <button type="button" class="btn btn-primary btn-sm btn-block">Refuel</button>
            <button type="button" class="btn btn-primary btn-sm btn-block">Hire Crew Member</button>
            <button type="button" class="btn btn-primary btn-sm btn-block">Ship Stats</button>
            <button type="button" class="btn btn-primary btn-sm btn-block">Go to</button>
        </div>`;

        div.innerHTML = cardToBuild;
        // selectiong buttons from the new created div
        let buttons = div.getElementsByTagName("button");
        //assigning eventlistener to the buttons from planet
        buttons[0].addEventListener("click", () => { planet.repair(chosenShip) });
        buttons[1].addEventListener("click", () => { planet.refuel(chosenShip) });
        buttons[2].addEventListener("click", () => { planet.hireCrewMember(chosenShip) });
        buttons[3].addEventListener("click", () => { shipStatus(chosenShip) });
        //this eventlistener is from the ship
        buttons[4].addEventListener("click", () => { chosenShip.start(planet) });

        divPlanets.append(div);
    }
}

function generateEvents(timeDistance, listOfEvents) {

    argumentTime = Math.floor(timeDistance) / 1000;

    let arrayOfEvents = [];
    if (argumentTime < 8) {
        for (let i = 0; i < 1; i++) {
            arrayOfEvents.push(listOfEvents[Math.floor(Math.random() * 12)]);
        }
    }
    else if (argumentTime < 18) {
        for (let i = 0; i < 2; i++) {
            arrayOfEvents.push(listOfEvents[Math.floor(Math.random() * 12)]);
        }
    }
    else if (argumentTime <= 26) {
        for (let i = 0; i < 3; i++) {
            arrayOfEvents.push(listOfEvents[Math.floor(Math.random() * 12)]);
        }
    }
    else {
        for (let i = 0; i < 4; i++) {
            arrayOfEvents.push(listOfEvents[Math.floor(Math.random() * 12)]);
        }
    }
    return arrayOfEvents;
}

async function startEvent(elementShip) {
    if (!(elementShip instanceof Ship)) {
        console.log("That is not a ship!");
        return;
    };

    let eventsToHappen = generateEvents(elementShip.distance, events);
    await activeEvent(eventsToHappen, 200, elementShip);
}

async function activeEvent(listEvent, timeDelay, ship) {
    // using recursion to conect the events
    if (listEvent.length !== 0) {
        let event = listEvent[listEvent.length - 1]
        await setTimeout(function () {
            console.log(event.name);
            console.log(event.description);
            if (event.crewModifier !== 0) {
                ship.crew += event.crewModifier;
                console.log(`Crew ${event.crewModifier}`);
            }
            if (event.fuelModifier !== 0) {
                ship.fuel += event.fuelModifier;
                console.log(`Fuel ${event.fuelModifier}`);
            }
            if (event.hullmodifier !== 0) {
                ship.hull += event.hullmodifier;
                console.log(`Hull ${event.hullmodifier}`);
            }

            let [gameEnd, message] = checkForGameOver(chosenShip);
            if (gameEnd) {
                hideContainers();
                newGameContainer.classList.remove("display-none");
                makeButtonsActive(allButtons);
                return console.log(message);
            };

            listEvent.pop();
            activeEvent(listEvent, 4000, ship);
        }, timeDelay);
    }
}

function checkForGameOver(elementObject) {
    let gameEnd = false;
    let message = "";
    if (elementObject.crew <= 0) {
        message = "You lost all the crew members! Game Over";
        gameEnd = true;
    }
    if (elementObject.fuel <= 0) {
        message = "There is no more fuel and doom of your ship is inevitable... Game Over";
        gameEnd = true;
    }
    if (elementObject.hull <= 0) {
        message = "Your hull is totaly destroyed and it is beyond repair.  Game Over";
        gameEnd = true;
    }
    return [gameEnd, message];
}

function shipStatus(elementObject) {
    console.log("Ship Status:");
    console.log(`Crew members: ${elementObject.crew}`);
    console.log(`Fuel: ${elementObject.fuel}`);
    console.log(`Hull: ${elementObject.hull}`);
    console.log(`Credits: ${elementObject.credits}`);
}

function makeButtonsInactive(listButtons) {
    for (const button of listButtons) {
        button.classList.add("inactiveLink");
    }

}

function makeButtonsActive(listButtons) {
    for (const button of listButtons) {
        button.classList.remove("inactiveLink");
    }
}

function hideContainers() {
    shipContainer.classList.add("display-none");
    planetContainer.classList.add("display-none");
    newGameContainer.classList.add("display-none");
}