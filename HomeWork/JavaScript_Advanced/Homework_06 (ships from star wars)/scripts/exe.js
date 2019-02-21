$(() => {
    $('.hideAll').on('click', hideAll);
    $('#fighterBuilder').on('click', showFighter);
    $('#cargoBuilder').on('click', showCargo);
    $('#minerBuilder').on('click', showMiner);
    $('#build').on('click', () => {
        let [ship, type] = getVals();
        buildShip(ship, type);
        console.log(`New ${type} ship has been created!`);
        displayShips();
        hideAll();
    });


})

const getVals = () => {
    let ship = readInputs();
    let type = getType();

    return [ship, type];
}

const buildShip = (ship, type) => {
    switch (type) {
        case 'fighter':
            fighters.push(new FighterShips(ship));
            break;
        case 'cargo':
            cargos.push(new CargoShip(ship));
            break;
        case 'miner':
            miners.push(new MiningShip(ship));
            break;
        default:
            break;
    }
}

let shipContainterChileds = document.querySelectorAll(".row div.col");
let divFighter = shipContainterChileds[0];
let divCargo = shipContainterChileds[1];
let divMining = shipContainterChileds[2];

let fighters = [];
let cargos = [];
let miners = [];

