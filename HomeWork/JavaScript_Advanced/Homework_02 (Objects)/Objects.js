
function Person(firstName, lastName, dateOfBirth, placeOfBirth) {
    this.firstName = arguments[0];
    this.lastName = lastName;
    this.dateOfBirth = dateOfBirth;
    this.placeOfBirth = arguments[3];
    this.age = NaN;
}

Person.prototype.details = function () { return `${this.firstName} ${this.lastName}, ${this.placeOfBirth}`; };
Person.prototype.calculateAge = function () {

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

let family = {
    numberOfMembers: 0,
    members: [],

    set: function (element) {
        this.members.push(element);
        this.numberOfMembers ++;
    },

    get: function () {
        return this.members;
    },

    calculateAverage: function(){
        let sum = 0;
        this.members.forEach(function(item){
            sum += item.age;
        });
        return sum / this.members.length;
    },

    calculateSum: function(){
        let sum = 0;
        this.members.forEach(function(item){
            sum += item.age;
        });
        return sum;
    },
}


let dejan = new Person("Dejan", "Monev", "Januray 26 1991", "Valandovo");
let marko = new Person("Marko", "Toshev", "Januray 23 1993", "Valandovo");

family.set(dejan);
family.set(marko);

console.log(dejan.calculateAge());
console.log(marko.calculateAge());

console.log(family.calculateAverage());
console.log(family.calculateSum());

