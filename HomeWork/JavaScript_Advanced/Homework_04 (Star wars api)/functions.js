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

function createDivWithButton() {
    let div = document.createElement("div");
    let button = document.createElement("button");
    button.textContent = "Show more results";
    button.addEventListener("click")
    div.append(button);
}
function callPeople() {

    hideDomElements();
    //to show the animation while waiting
    animationGears.classList.remove("display-none");
    if (tBodyPeople.textContent === "") {
        sendRequestForPeople(peopleUrl);
        moreResults.classList.remove("display-none");
        moreResults.addEventListener("click", () => {
            if (nextPage !== null) {
                sendRequestForPeople(nextPage) 
            } 
            else {
                moreResults.classList.add("display-none");
            }
        });

    }
    else {
        animationGears.classList.add("display-none");
        tBodyPeople.innerHTML = "";
        writePeopleInTable(people);
        table1People.classList.remove("display-none");
        moreResults.classList.remove("display-none");
    }
}

function sendRequestForPeople(urlPeople) {
    disableLink(peopleButton);
    fetch(urlPeople)
        .then(response => response.json())
        .then(function (myJson) {

            let people = [];
            for (const person of myJson.results) {
                people.push(person);
            }
            // To hide the animation
            animationGears.classList.add("display-none");
            writePeopleInTable(people);
            table1People.classList.remove("display-none");
            enableLink(peopleButton);
            // assigning the new call
            nextPage = myJson.next;
        });
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