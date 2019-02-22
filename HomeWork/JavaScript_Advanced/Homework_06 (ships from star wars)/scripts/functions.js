const hideAll = () => {
    $('.types').removeClass('hidden');
    $('.builder').addClass('hidden');
    $('#fighter').addClass('hidden');
    $('#cargo').addClass('hidden');
    $('#miner').addClass('hidden');
}
const showFighter = () => {
    $('.types').addClass('hidden');
    $('.builder').removeClass('hidden');
    $('#fighter').removeClass('hidden');
}
const showCargo = () => {
    $('.types').addClass('hidden');
    $('.builder').removeClass('hidden');
    $('#cargo').removeClass('hidden');
}
const showMiner = () => {
    $('.types').addClass('hidden');
    $('.builder').removeClass('hidden');
    $('#miner').removeClass('hidden');
}

const readInputs = () => {
    let obj = {};
    obj.name = $('#name').val();
    obj.pilot = $('#pilot').val();
    obj.fuelTankCapacity = $('#tank').val();
    obj.currentLocation = $('#currentLoc').val();
    obj.weapons = $('#weapons').val();
    obj.shield = $('#shield').val();
    obj.numberOfKills = $('#kills').val();
    obj.cargoCapacity = $('#cargoCap').val();
    obj.tradingRoute = $('#tradeRoute').val();
    obj.loadingCranes = $('#cranes').val();
    obj.miningTools = $('#mineTools').val();
    obj.miningTypes = $('#mineTypes').val();
    obj.miningStorage = $('#oreCap').val();
    return obj;
}

const getType = () => {
    const types = $('.shipType').toArray();
    for (const type of types) {
        if (!$(type).hasClass('hidden')) {
            return $(type).attr('id');
        }
    }
}

function checkValues() {

    let name = $('#name').val();
    let pilot = $('#pilot').val();
    let fuelTankCapacity = $('#tank').val();
    let currentLocation = $('#currentLoc').val();

    let checkOne = (name !== "") && (pilot !== "") && (fuelTankCapacity !== "") && (currentLocation !== "");
    if (!checkOne) { return false; }

    let divNotHidden = document.querySelectorAll("div .shipType:not(.hidden)");
    let inputs = divNotHidden[0].querySelectorAll("input");

    for (const input of inputs) {
        if (input.value === "") { return false; }
    }
    return true;
}

function createDivforCard() {
    let div = document.createElement("div");
    div.setAttribute("class", "card");
    div.setAttribute("style", "width: 18rem;");
    return div;
}

function displayShips() {
    createFighterShipsInHtml(fighters);
    createCargoShipsInHtml(cargos);
    createMiningShipsInHtml(miners);
}

function createFighterShipsInHtml(listOfFigters) {
    divFighter.innerHTML = "";
    for (const elementShip of listOfFigters) {

        //create div outside from innerHTML element to be able to select the buttons
        let div = createDivforCard();
        // create card using innerHTML
        let cardToBuild = `
            <img src="./img/fighter.jpg" class="card-img-top" alt="starship_fighter">
            <ul class="list-group list-group-flush">
                <li class="list-group-item"> Name: ${elementShip.name} </li>
                <li class="list-group-item"> Pilot: ${elementShip.pilot}</li>
                <li class="list-group-item">Fuel Tank:${elementShip.fuelTankCapacity} </li>
                <li class="list-group-item">Stationed:${elementShip.currentLocation}</li>
                <li class="list-group-item">Weapons: ${elementShip.weapons}</li>
                <li class="list-group-item">Shield: ${elementShip.shield}</li>
                <li class="list-group-item">Kills: ${elementShip.numberOfKills}</li>
            </ul>
            <div class="card-body">

                <button type="button" class="btn btn-primary btn-sm btn-block">Start engine</button>
                <button type="button" class="btn btn-primary btn-sm btn-block">Take Off</button>
                <button type="button" class="btn btn-primary btn-sm btn-block">Land</button>
                <button type="button" class="btn btn-primary btn-sm btn-block">Shoot wepon 1</button>
                <button type="button" class="btn btn-primary btn-sm btn-block">Shoot wepon 2</button>
                <button type="button" class="btn btn-primary btn-sm btn-block">Shoot random wepon </button>

            </div>
        `;

        div.innerHTML = cardToBuild;

        //add event to buttons that we created
        let buttons = div.querySelectorAll("button");
        buttons[0].addEventListener("click", () => { elementShip.startEngine() });
        buttons[1].addEventListener("click", () => { elementShip.takeOff() });
        buttons[2].addEventListener("click", () => { elementShip.land() });
        buttons[3].addEventListener("click", () => { elementShip.shoot_weapon1() });
        buttons[4].addEventListener("click", () => { elementShip.shoot_weapon2() });
        buttons[5].addEventListener("click", () => { elementShip.shoot_weaponN() });

        divFighter.append(div);
        divFighter.append(document.createElement("br"));
    }
}

function createCargoShipsInHtml(listOfCargos) {
    divCargo.innerHTML = "";
    for (const elementShip of listOfCargos) {

        //create div outside from innerHTML element to be able to select the buttons
        let div = createDivforCard();
        // create card using innerHTML
        let cardToBuild = `
            <img src="./img/cargo.jpg" class="card-img-top" alt="starship_cargo">
            <ul class="list-group list-group-flush">
                <li class="list-group-item"> Name: ${elementShip.name} </li>
                <li class="list-group-item"> Pilot: ${elementShip.pilot}</li>
                <li class="list-group-item">Fuel Tank:${elementShip.fuelTankCapacity} </li>
                <li class="list-group-item">Stationed:${elementShip.currentLocation}</li>
                <li class="list-group-item">Cargo Capacity: ${elementShip.cargoCapacity}</li>
                <li class="list-group-item">Trading Route: ${elementShip.tradingRoute}</li>
                <li class="list-group-item">Loading Cranes: ${elementShip.loadingCranes}</li>
            </ul>
            <div class="card-body">
                <button type="button" class="btn btn-primary btn-sm btn-block">Start engine</button>
                <button type="button" class="btn btn-primary btn-sm btn-block">Take Off</button>
                <button type="button" class="btn btn-primary btn-sm btn-block">Land</button>
                <button type="button" class="btn btn-primary btn-sm btn-block">Load</button>
                <button type="button" class="btn btn-primary btn-sm btn-block">Unload</button>
            </div>
        `
        div.innerHTML = cardToBuild;

        //add event to buttons that we created
        let buttons = div.querySelectorAll("button");
        buttons[0].addEventListener("click", () => { elementShip.startEngine() });
        buttons[1].addEventListener("click", () => { elementShip.takeOff() });
        buttons[2].addEventListener("click", () => { elementShip.land() });
        buttons[3].addEventListener("click", () => { elementShip.load() });
        buttons[4].addEventListener("click", () => { elementShip.unload() });

        divCargo.append(div);
        divCargo.append(document.createElement("br"));
    }
}

function createMiningShipsInHtml(listOfMiners) {
    divMining.innerHTML = "";
    for (const elementShip of listOfMiners) {

        //create div outside from innerHTML element to be able to select the buttons
        let div = createDivforCard();
        // create card using innerHTML
        let cardToBuild = `
            <img src="./img/mining.jpg" class="card-img-top" alt="starship_miner">
            <ul class="list-group list-group-flush">
                <li class="list-group-item"> Name: ${elementShip.name} </li>
                <li class="list-group-item"> Pilot: ${elementShip.pilot}</li>
                <li class="list-group-item">Fuel Tank:${elementShip.fuelTankCapacity} </li>
                <li class="list-group-item">Stationed:${elementShip.currentLocation}</li>
                <li class="list-group-item">Mining Tools: ${elementShip.miningTools}</li>
                <li class="list-group-item">Mining Types: ${elementShip.miningTypes}</li>
                <li class="list-group-item">Ore Storage cap: ${elementShip.miningStorage}</li>
            </ul>
            <div class="card-body">
                <button type="button" class="btn btn-primary btn-sm btn-block">Start engine</button>
                <button type="button" class="btn btn-primary btn-sm btn-block">Take Off</button>
                <button type="button" class="btn btn-primary btn-sm btn-block">Land</button>
                <button type="button" class="btn btn-primary btn-sm btn-block">Harvest</button>
                <button type="button" class="btn btn-primary btn-sm btn-block">Storage temperature</button>
            </div>
        `
        div.innerHTML = cardToBuild;

        //add event to buttons that we created
        let buttons = div.querySelectorAll("button");
        buttons[0].addEventListener("click", () => { elementShip.startEngine() });
        buttons[1].addEventListener("click", () => { elementShip.takeOff() });
        buttons[2].addEventListener("click", () => { elementShip.land() });
        buttons[3].addEventListener("click", () => { elementShip.harvest() });
        buttons[4].addEventListener("click", () => { elementShip.storageTemperature() });

        divMining.append(div);
        divMining.append(document.createElement("br"));
    }
}
