function Person ( {name,lastName, dateOfBirth, hometown } ){
	this.name = name;
	this.lastName = lastName;
	this.dateOfBirth = dateOfBirth;
	this.hometown = hometown;
}

Person.prototype.sayFullName = function () { 
	console.log(`my full name is ${this.name} ${this.lastName }`);
}

Person.prototype.age = function () {

    let bornDate = new Date(this.dateOfBirth);
    let currentDate = new Date();
    let difference = currentDate - bornDate;
    const convertToDay = 1 * (24 * 60 * 60 * 1000);

    let year = difference / (convertToDay * 365.2425);
    let month = (year - Math.floor(year)) * 12;
    let day =((month - Math.floor(month)) / 12) * 365.2425;

    this.age = Math.floor(year);
    return `You are ${ Math.floor(day)} days, ${Math.floor(month)} months and ${Math.floor(year)} years old`;
}


function Trainer (elementObj ) {

	Person.call(this, elementObj );

	let { course, yearsOfTeaching} = elementObj;

	this.course = course;
	this.yearsOfTeaching = yearsOfTeaching;

}

Trainer.prototype = Object.create(Person.prototype);

Trainer.prototype.workingExperience = function () { 
	console.log(`I have ${this.yearsOfTeaching} years of experience`);
}

Array.prototype.getSumOfNumbers = function () {

	let result = 0;
	if(this.length === 0) { return "list is empty";	}

	for (let value of this) {
		if(typeof value === "number") {
			result += value;
		}
	
	}
	return result;
	
}

Object.prototype.getKeysAndVals = function () {
	let keys = (Object.keys(this));
 	let values = [];
	for (let property of keys) {
		values.push(this[property]);
	}
	return [keys,values];

}

let obj1 = {

	name: "Dejan",
	lastName: "Monev",
	dateOfBirth: "January 26 1991",
	hometown: "Valandovo",
	course: "Weleder",
	yearsOfTeaching: "5"
}


let dejan = new Person(obj1);
let arr = [1, '3', { num: 7 }, 8, 'FunFunFunction', 10, () => `I'm a number`, 33];
console.log(arr.getSumOfNumbers());