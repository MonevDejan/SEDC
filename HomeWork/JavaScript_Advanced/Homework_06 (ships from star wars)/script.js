class Starships {
	constructor(name, pilot, fuel_tank_capacity, current_location, type_of_starship) {
		this.name = name;
		this.pilot = pilot;
		this.fuel_tank_capacity = fuel_tank_capacity;
		this.current_location = current_location;
		this.type_of_starship = type_of_starship;
	}
	startEngine() {
		return "jump trough space"
	}
	takeOff() {
		return "takeOff"
	}
	land() {
		return "land"
	}

}

class Fighter extends Starships {

	constructor(weapons, shield, number_of_kills, name, pilot, fuel_tank_capacity, current_location, type_of_starship) {
		super(name, pilot, fuel_tank_capacity, current_location, type_of_starship);
		this.weapons = weapons;
		this.shield = shield;
		this.number_of_kills = number_of_kills;

	}
	shoot_weapon1() {
		return "shoot wepon 1"
	}
	shoot_weapon2() {
		return "shoot wepon 2"
	}
	shoot_weaponN() {
		return "shoot wepon n"
	}

}

class CargoShipt extends Starships {
	constructor(capacity, trading_route, loading_cranes, name, pilot, fuel_tank_capacity, current_location, type_of_starship) {
		super(name, pilot, fuel_tank_capacity, current_location, type_of_starship);
		this.capacity = capacity;
		this.trading_route = trading_route;
		this.loading_cranes = loading_cranes;
	}
	load() {
		return "load cargo"
	}
	unload() {
		return "sunload cargo"
	}

}

class MiningShip extends Starships {
	constructor(mining_tools, mining_types, mining_storage_capacity, name, pilot, fuel_tank_capacity, current_location, type_of_starship) {
		super(name, pilot, fuel_tank_capacity, current_location, type_of_starship);
		this.mining_tools = mining_tools;
		this.mining_types = mining_types;
		this.mining_storage_capacity = mining_storage_capacity;
	}
	harvest() {
		return "harves"
	}
	storageTemperature() {
		return "set to room temperature"
	}
}



let firstList = document.getElementById("first");
let secondList = document.getElementById("second");
let thirdList= document.getElementById("third");



let miningShip = new  MiningShip (true, "drilss", 300000, "dead-end", "robot", 3,"pandora", "flying one");
let CargoShip = new  CargoShipt (300000,"skopje-valandovo", 3,"transporter", "robot", 4, "pandora", "flying_one");
let FighterShip = new  Fighter (true, true, 45636435,"killer", "human", 1, "pandora", "fighter");

function writeInList(elementObject, listToWrite) { 

	for (const key in elementObject) {
		let li = document.createElement("li");
		li.textContent = `${key} : ${elementObject[key]}`
		listToWrite.append(li);
	}
}

writeInList(miningShip,firstList);
writeInList(CargoShip,secondList);
writeInList(FighterShip,thirdList);