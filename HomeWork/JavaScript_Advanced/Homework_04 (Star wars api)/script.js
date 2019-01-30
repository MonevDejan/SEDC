(() => {
  const peopleUrl = 'https://swapi.co/api/people/';
  const planetsUrl = 'https://swapi.co/api/planets/';
  const people = [];
  const planets = [];

  function writePeopleInTable(someArray) {
    someArray.forEach(pageOfpeople => {
      let listOfpeople = pageOfpeople.results;
      listOfpeople.forEach(person => {
        insertRowContentForPerson(person);
      })
    });
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

  function writePlanetsInTable(someArray) {
    someArray.forEach(pageOfplanets => {
      let listOfplanets = pageOfplanets.results;
      listOfplanets.forEach(planets => {
        insertRowContentForPlanet(planets);
      })
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
    searchButton.style.display = "none";
    inputSearch.style.display = "none";
    table1People.style.display = "none";
    table2Planets.style.display = "none";
    logoPicture.style.display = "none";

  }

  function disableLinks () {
    peopleButton.classList.add("inactiveLink");
    planetsButton.classList.add("inactiveLink");
    homeButton.classList.add("inactiveLink");
  }

  function enableLinks () {
    peopleButton.classList.remove("inactiveLink");
    planetsButton.classList.remove("inactiveLink");
    homeButton.classList.remove("inactiveLink");
  }

  function callPeople() {

    // Sending request for star wars people
    function sendRequestForPeople(urlPeople) {

      fetch(urlPeople)
        .then(function (response) {
          return response.json();
        })
        .then(function (myJson) {

          //disabeling the link to prevent sending another request
          disableLinks ();

          //to show the animation while waiting
          animationGears.style.display = "";

          people.push(myJson);

          /* one request is returning only 10 planets 
          so we are using recursion to get the rest of the elements */
          if (myJson.next) { sendRequestForPeople(myJson.next); }

          // To hide the animation and enable the link
          else {
            animationGears.style.display = "none";
            enableLinks ();
            writePeopleInTable(people);
            table1People.style.display = "";
          }
        });
    }

    hideDomElements();
    if (people.length === 0) { sendRequestForPeople(peopleUrl); }
    else { table1People.style.display = ""; }
  }

  function callPlanets() {

    // Sending request for star wars planets
    function sendRequestForPlanets(urlPeople) {

      fetch(urlPeople)
        .then(function (response) {
          return response.json();
        })
        .then(function (myJson) {

          //disabeling the link to prevent sending another request
          disableLinks ();

          //to show the animation while waiting
          animationGears.style.display = "";

          planets.push(myJson);

          /* one request is returning only 10 planets 
          so we are using recursion to get the rest of the elements */
          if (myJson.next) { sendRequestForPlanets(myJson.next); }

          // To hide the animation and enable the link
          else {
            animationGears.style.display = "none";
            enableLinks ();
            writePlanetsInTable(planets);
            table2Planets.style.display = "";
          }
        });
    }

    hideDomElements();
    if (planets.length === 0) { sendRequestForPlanets(planetsUrl); }
    else { table2Planets.style.display = ""; }
  }

  function callHome() {
    hideDomElements();
    inputSearch.style.display = "";
    searchButton.style.display = "";
    logoPicture.style.display = "";
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

})();

