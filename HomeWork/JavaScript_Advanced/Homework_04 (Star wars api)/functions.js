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
    animationGears.classList.add("display-none");
    table1People.classList.add("display-none");
    table2Planets.classList.add("display-none");
    logoPicture.classList.add("display-none");
    searchButton.classList.add("display-none");
    inputSearch.classList.add("display-none");
    moreResults.classList.add("display-none");
}

function disableLink(button) {
    button.classList.add("inactiveLink");
}

function enableLink(button) {
    button.classList.remove("inactiveLink");
}

function callHome() {
    hideDomElements();
    logoPicture.classList.remove("display-none");
    searchButton.classList.remove("display-none");
    inputSearch.classList.remove("display-none");
}