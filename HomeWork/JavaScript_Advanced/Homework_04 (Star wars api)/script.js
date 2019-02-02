// (() => {
const peopleUrl = 'https://swapi.co/api/people/';
const planetsUrl = 'https://swapi.co/api/planets/';
const people = [];
const planets = [];

function writePeopleInTable(list) {
  list.forEach(person => {
    insertRowContentForPerson(person);
  })
}

function insertRowContentForPerson(somePerson) {

  let row = tBodyPeople.insertRow();

  let name = row.insertCell();
  name.textContent = somePerson.name;

  let gender = row.insertCell();
  gender.textContent = somePerson.gender;

  let birthYear = row.insertCell();
  birthYear.textContent = somePerson.birth_year;

  let height = row.insertCell();
  height.textContent = somePerson.height;

  let mass = row.insertCell();
  mass.textContent = somePerson.mass;
}

function writePlanetsInTable(list) {
  list.forEach(planets => {
    insertRowContentForPlanet(planets);
  });
}

function insertRowContentForPlanet(somePlanet) {

  let row = tBodyPlanets.insertRow();

  let name = row.insertCell();
  name.textContent = somePlanet.name;

  let diameter = row.insertCell();
  diameter.textContent = somePlanet.diameter;

  let climate = row.insertCell();
  climate.textContent = somePlanet.climate;

  let terrain = row.insertCell();
  terrain.textContent = somePlanet.terrain;

  let rotationPeriod = row.insertCell();
  rotationPeriod.textContent = somePlanet.rotation_period;

  let population = row.insertCell();
  population.textContent = somePlanet.population;

}

function hideDomElements() {

  table1People.style.display = "none";
  table2Planets.style.display = "none";
  logoPicture.style.display = "none";
  searchButton.style.display = "none";
  inputSearch.style.display = "none";
}

function callPeople() {

  // Sending request for star wars people
  function sendRequestForPeople(urlPeople) {

    disableLink(peopleButton);
    fetch(urlPeople)
      .then(response => response.json())
      .then(function (myJson) {

        for (const person of myJson.results) {
          people.push(person);
        }

        /* one request is returning only 10 planets 
        so we are using recursion to get the rest of the elements */
        if (myJson.next) { sendRequestForPeople(myJson.next); }

        // To hide the animation
        else {
          animationGears.style.display = "none";
          writePeopleInTable(people);
          table1People.style.display = "";
          enableLink(peopleButton);
        }
      });
  }
  //to show the animation while waiting
  animationGears.style.display = "";
  hideDomElements();
  searchButton.style.display = "";
  inputSearch.style.display = "";
  if (people.length === 0) { sendRequestForPeople(peopleUrl); }
  else {
    animationGears.style.display = "none";
    table1People.style.display = "";
  }
}

function callPlanets() {

  // Sending request for star wars planets
  function sendRequestForPlanets(urlPeople) {

    disableLink(planetsButton);
    fetch(urlPeople)
      .then(response => response.json())
      .then(function (myJson) {

        for (const planet of myJson.results) {
          planets.push(planet);
        }

        /* one request is returning only 10 planets 
        so we are using recursion to get the rest of the elements */
        if (myJson.next) { sendRequestForPlanets(myJson.next); }

        // To hide the animation and enable the link
        else {
          animationGears.style.display = "none";
          enableLink(planetsButton);
          writePlanetsInTable(planets);
          table2Planets.style.display = "";
        }
      });
  }
  //to show the animation while waiting
  animationGears.style.display = "";
  hideDomElements();
  searchButton.style.display = "";
  inputSearch.style.display = "";
  if (planets.length === 0) {
    sendRequestForPlanets(planetsUrl);
  }
  else {
    animationGears.style.display = "none";
    table2Planets.style.display = "";
  }
}

function callHome() {
  hideDomElements();
  logoPicture.style.display = "";
}

function disableLink(button) {
  button.classList.add("inactiveLink");
}

function enableLink(button) {
  button.classList.remove("inactiveLink");
}

// assigning all DOM elements that we need in a variable
let homeButton = document.getElementById("goHome");
let peopleButton = document.getElementById("getPeople");
let planetsButton = document.getElementById("getPlanets");
let searchButton = document.getElementById("search");
let inputSearch = document.querySelector("input.form-control");
let tBodyPeople = document.getElementById("bodyPeople");
let tBodyPlanets = document.getElementById("bodyPlanets");
let table1People = document.getElementById("table1");
let table2Planets = document.getElementById("table2");
let animationGears = document.getElementById("gears");
let logoPicture = document.getElementById("logo");

peopleButton.addEventListener("click", callPeople);
planetsButton.addEventListener("click", callPlanets);
homeButton.addEventListener("click", callHome);

// })();

function searchResults(list, string) {

  list.forEach(element => {

  });

}

function mapArray() {


}