let price = {
    fuel: 50,
    repair: 60,
    crew: 80
}

class Ship {
    constructor(name, crew, fuel, hull, speed, img) {
        this.name = name;
        this.crew = crew;
        this.fuel = fuel;
        this.hull = hull;
        this.speed = speed;
        this.img = img;

        this.distance = 0;
        this.credits = 500;
        this.isWorking = false;
        this.isDamaged = false;
        this.dockedPlanet = null;

        this.maxHull = this.hull;
        this.maxFuel = this.fuel;
    }
    async start(planet) {
        if (!(planet instanceof Planet)) {
            console.log("That is not a planet!");
            return;
        };

        let fuelReserve = this.fuel - (planet.distance * 20)
        let malfunctionShip = (this.isDamaged) || (this.hull <= 0) || (this.crew <= 0);
        let planetDistance = (planet.distance * 1000) / this.speed;
        this.distance = planetDistance;
      
        if (this.dockedPlanet === planet.name) {
            console.log("You are on this planet");
            return;
        };

        if (malfunctionShip) {
            console.log("ship can't start because he is damaged, destroyed or ship has not crew members");
            return;
        }

        if (fuelReserve <= 0) {
            console.log("You dont have enough fuel to go to that planet");
            return;
        };

        makeButtonsInactive(allButtons);
        console.log('The ship has started traveling')

        setTimeout(() => {
            if (checkForGameOver(chosenShip)[0]) { 
                return; 
            };
            console.log('The ship has reached the planet!');
            this.dock(planet)
        }, planetDistance)

        await startEvent(chosenShip);

        this.fuel = fuelReserve;
        this.isWorking = true;
    }
    dock(planet) {
        setTimeout(function () {
            console.log('The ship docked this planets');
            makeButtonsActive(allButtons);
        }, 2000);

        this.dockedPlanet = planet.name;
        this.isWorking = false;
        let nameOfship = this.name;
        planet.shipsDocked.push(nameOfship);
    }
}

class Planet {
    constructor(name, size, population, distance, development, img) {
        this.name = name;
        this.size = size;
        this.population = population;
        this.distance = distance;
        this.development = development;
        this.img = img;

        this.shipsDocked = [];
    }
    getMarketPrice(initialPrice) {
        let firstSubstruct = (this.development * initialPrice);
        let secondSubstruct = (this.population / this.size);

        let planetPrice = (firstSubstruct - Math.floor(secondSubstruct));
        return planetPrice;
    }
    repair(ship) {
        if (!(ship instanceof Ship)) {
            console.log("That is not a ship!");
            return;
        };
        if (ship.dockedPlanet !== this.name) {
            console.log("you are not on this planet to get repair");
            return;
        };

        if (ship.maxHull === ship.hull) {
            console.log("your hull is at max value and you cant repair it");
            return;
        };

        let priceOfPlanet = this.getMarketPrice(price.repair);
        let leftCredits = ship.credits - priceOfPlanet;

        if (leftCredits < 0) {
            console.log("You dont have enough credits for repair")
            return;
        }
        else {
            ship.hull = ship.maxHull;
            ship.isDamaged = false;
            ship.credits = leftCredits;
        }
        console.log("Your ship has been repaired")
    }
    refuel(ship) {
        if (!(ship instanceof Ship)) {
            console.log("That is not a ship!");
            return;
        };
        if (ship.dockedPlanet !== this.name) {
            console.log("you are not on this planet to get refuel");
            return;
        };

        if (ship.maxFuel === ship.fuel) {
            console.log("your fuel is at max value and you cant refuel it");
            return;
        };

        let priceOfPlanet = this.getMarketPrice(price.fuel);
        let leftCredits = ship.credits - priceOfPlanet;

        if (leftCredits < 0) {
            console.log("You dont have enough credits for refuel")
            return;
        }
        else {
            ship.fuel = ship.maxFuel;
            ship.credits = leftCredits;
        }
        console.log("Your ship has been refueled")
    }
    hireCrewMember(ship) {
        if (!(ship instanceof Ship)) {
            console.log("That is not a ship!");
            return;
        };
        if (ship.dockedPlanet !== this.name) {
            console.log("you are not on this planet to get crew member");
            return;
        };

        let priceOfPlanet = this.getMarketPrice(price.fuel);
        let leftCredits = ship.credits - priceOfPlanet;

        if (leftCredits < 0) {
            console.log("You dont have enough credits to buy crew")
            return;
        }
        else {
            ship.crew += 1;
            ship.credits = leftCredits;
        }
        console.log("Your have 1 more member in the crew")

    }
}

class SpaceEvent {
    constructor(name, description, crewModifier, fuelModifier, hullmodifier) {
        this.name = name;
        this.description = description;
        this.crewModifier = crewModifier;
        this.fuelModifier = fuelModifier;
        this.hullmodifier = hullmodifier;
    }
}

let events = [
    new SpaceEvent("Fuel Leak", "Due to low maintenance of the ship, the fuel tank leaked. The leak was patched, but we lost some fuel.", 0, -50, 0),
    new SpaceEvent("Pirates!", "Space pirates attacked the ship! We escaped, but our hull took some damage!", 0, -20, -150),
    new SpaceEvent("Unknown substance", "An unknown substance was found on the cargo ship. A crew member touched it and died on the spot.", -1, 0, 0),
    new SpaceEvent("Asteroid field", "We entered an asteroid field. It was hard, but our captain managed to go out of it.", 0, -30, -100),
    new SpaceEvent("Fire on deck", "The main system overheated and fire broke from one of the panels. The crew quickly extinguished it.", 0, 0, -70),
    new SpaceEvent("Bad stop", "You stop at a nearby station for a pit-stop. They give you repair supplies.", 0, -50, +50),
    new SpaceEvent("Captains Birthday", "It's the captain's birthday. Everybody got drunk. Nobody remembers what happened the last 12 hours.", -1, -60, -100),
    new SpaceEvent("Space Shark", "Your ship is attacked by a space shark. After killing it, you watch a tutorial on how to turn shark blood in to fuel.", 0, +80, -120),
    new SpaceEvent("Alien in need", "An alien is stranded on it's broken ship. It took some time and effort but you save him and board him on your ship.", 1, -50, -50),
    new SpaceEvent("Hail the federation", "A federation cruiser hails you. They help you with supplies and fuel.", 0, +100, +100),
    new SpaceEvent("Destroyed Transport Ship", "You encounter a destroyed transport ship. It's dangerous, but you try salvaging its fuel tank.", 0, +150, -80),
    new SpaceEvent("Angry Spider", "An angry spider appears on the deck. The captain stomps on it. Everything is fine", 0, 0, 0)
];

