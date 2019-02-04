// (() => {
const peopleUrl = 'https://swapi.co/api/people/';
const planetsUrl = 'https://swapi.co/api/planets/';
const people = [];
const planets = [];


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
        // To hide the animation
        animationGears.classList.add("display-none");
        writePeopleInTable(people);
        table1People.classList.remove("display-none");
        enableLink(peopleButton);
      });
  }

  hideDomElements();
  //to show the animation while waiting
  animationGears.classList.remove("display-none");
  if (people.length === 0) { sendRequestForPeople(peopleUrl); }
  else {
    animationGears.classList.add("display-none");
    tBodyPeople.innerHTML = "";
    writePeopleInTable(people);
    table1People.classList.remove("display-none");
    moreResults.classList.remove("display-none");
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
        // To hide the animation and enable the link
        animationGears.classList.add("display-none");
        enableLink(planetsButton);
        writePlanetsInTable(planets);
        table2Planets.classList.remove("display-none");
      });
  }

  hideDomElements();
  //to show the animation while waiting
  animationGears.classList.remove("display-none");
  if (planets.length === 0) {
    sendRequestForPlanets(planetsUrl);
  }
  else {
    animationGears.classList.add("display-none");
    tBodyPlanets.innerHTML = "";
    writePlanetsInTable(planets);
    table2Planets.classList.remove("display-none");
  }
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
let moreResults = document.getElementById("moreResults");

peopleButton.addEventListener("click", callPeople);
planetsButton.addEventListener("click", callPlanets);
homeButton.addEventListener("click", callHome);
searchButton.addEventListener("click", searchResults);


function searchResults() {

  let stringPeople = `https://swapi.co/api/people/?search=${inputSearch.value}`;
  let stringPlanets = `https://swapi.co/api/planets/?search=${inputSearch.value}`;

  function searchForString(searchUrl) {

    // disableLink(peopleButton);
    fetch(searchUrl)
      .then(response => response.json())
      .then(function (myJson) {

      });
  }




}

function mapArray() {


}

// })();