function Pets(name , type, breed, age, isHealthy, owner ) 
{
    this.name = name ;
    this.type = type;
    this.breed = breed;
    this.age  = age;
    this.isHealthy = isHealthy;
    this.owner  = owner;
    this.eat = function (){ "The {typse of the pet} {name of the pet} is eating {the food that this pet eats}"};
    this.adopt = function (){" a method that takes a person and sets that person as the pet's owner."};
    this.isAdopted = function (){" - a method that returns true or false depending of whether the pet has a owner"};

  }

  function person(first, last, age, adopt) 
  {
    let object = 
    {
      firstName:  first,
      lastName:  last,
      age: age,
      adopt:  adopt
    }
    
    return object;
  }