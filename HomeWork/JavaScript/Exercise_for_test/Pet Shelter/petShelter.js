function Pets(name=0 , type=0, breed=0, preferredFood=0, age=0, isHealthy=true, owner=false ) 
{
  let checkValidation = (name && type && breed && preferredFood && age);

  if ((isHealthy === 0 ) || (isHealthy === "No" ) || (isHealthy === "NotHealthy") )
  { isHealthy = false; }
  else { isHealthy = true; }

  if(checkValidation)

  {
    this.name = name ;
    this.type = type;
    this.breed = breed;
    this.preferredFood = preferredFood;
    this.age  = age;
    this.isHealthy = isHealthy;
    this.owner  = owner;
    this.eat = function ()
    { 
      let statement = `The ${this.type} ${this.name} is eating ${this.preferredFood}`;
      return statement;
    },
  
    this.adopt = function (person)  {this.owner = person;};
    this.isAdopted = function ()
    { 
      if (this.owner) { return true; }
      else { return false;}
    }
  }
  else
  { console.log("You entered wrong values or you are missing values")};
}


function person(first, last, age) 
{
  //  needs validation for the parametres
  let object = 
  {
    firstName:  first,
    lastName:  last,
    age: age,
    pets: [],
    adopt: function(petType) 
    { 
      let ifFound = 0;
      for (let i = 0; i < animalShelter.length; i++) 
      {
        if (animalShelter[i].type === petType) 
        {
          this.pets.push(animalShelter[i]);
          animalShelter.splice(i, 1);
          ifFound +=1;
          break;
        }
      }

      if(!ifFound) {console.log("Pet shelter doesnt have that type of animal"); }
    },
    
    abandon: function (nameOfabandonedPet)
    { 
      // need validation if nameOfabandonedPet is string
      let ownersPets = this.pets;

      // needs another validation if the owner has more pets with the same name
      // abandone the first pet that is found with the same name
      let ifFound = 0;
      for (let i = 0; i < ownersPets.length; i++) 
      {
        if (ownersPets[i].name === nameOfabandonedPet) 
        {
          animalShelter.push(ownersPets[i]);
          ownersPets.splice(i, 1);
          ifFound +=1;
          break;
        }
      }
      if(!ifFound) {console.log("Pet shelter doesnt have that type of animal"); }
    }
  }
  
  return object;
}

let animalShelter = [];

let dog1 = new Pets("Sharko", "dog", "Affenpinscher", "socks", 2, true); 

let dog2 = new Pets("Dzeki", "dog", "Beagle", "newspapers", 6, "asadasd"); 

let dog3 = new Pets("Murgo", "dog", "Bichon Frise", "bred", 3, "No"); 

let dog4 = new Pets("Dzoni", "dog", "Bull Terrier", "Meat", 4); 

let dog5 = new Pets("Reks", "dog", "Dalmatian", "bones", 5); 

animalShelter.push(dog1);
animalShelter.push(dog2);
animalShelter.push(dog3);
animalShelter.push(dog4);
animalShelter.push(dog5);

let person1 = person ("Nikola", "Eftimov", 23);
let person2 = person ("Dimitar", "Spasov", 21);

