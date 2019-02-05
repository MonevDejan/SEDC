// (() => {
const peopleUrl = 'https://swapi.co/api/people/';
const planetsUrl = 'https://swapi.co/api/planets/';
let nextPagePeople = "";
let nextPagePlanets = "";

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






// })();