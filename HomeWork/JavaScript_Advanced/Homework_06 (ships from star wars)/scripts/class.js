class Starships {
	constructor({ name, pilot, fuelTankCapacity, currentLocation }) {
		this.name = name;
		this.pilot = pilot;
		this.fuelTankCapacity = fuelTankCapacity;
		this.currentLocation = currentLocation;
	}
	startEngine() {
		console.log(`${this.name} started the engine`);
	}
	takeOff() {
		console.log(`${this.name} took off`);
	}
	land() {
		console.log(`${this.name} has landed`);
	}

}

class FighterShips extends Starships {

	constructor({ weapons, shield, numberOfKills, name, pilot, fuelTankCapacity, currentLocation }) {
		super({ name, pilot, fuelTankCapacity, currentLocation });
		this.weapons = weapons;
		this.shield = shield;
		this.numberOfKills = numberOfKills;
		this.shipType = `Fighter`;
	}
	shoot_weapon1() {
		console.log(`${this.name} shoot wepon 1`);
	}
	shoot_weapon2() {
		console.log(`${this.name} shoot wepon 2`);
	}
	shoot_weaponN() {
		console.log(`${this.name} shoot wepon n`);
	}

}

class CargoShip extends Starships {
	constructor({ cargoCapacity, tradingRoute, loadingCranes, name, pilot, fuelTankCapacity, currentLocation }) {
		super({ name, pilot, fuelTankCapacity, currentLocation });
		this.cargoCapacity = cargoCapacity;
		this.tradingRoute = tradingRoute;
		this.loadingCranes = loadingCranes;
		this.shipType = `Cargo`;
	}
	load() {
		console.log(`${this.name} load cargo`);
	}
	unload() {
		console.log(`${this.name} sunload cargo`);
	}

}

class MiningShip extends Starships {
	constructor({ miningTools, miningTypes, miningStorage, name, pilot, fuelTankCapacity, currentLocation }) {
		super({ name, pilot, fuelTankCapacity, currentLocation });
		this.miningTools = miningTools;
		this.miningTypes = miningTypes;
		this.miningStorage = miningStorage;
		this.shipType = `Mining`;
	}
	harvest() {
		console.log(`${this.name} start harvest`);
	}
	storageTemperature() {
		console.log(`${this.name} set temperature`);
	}
}
