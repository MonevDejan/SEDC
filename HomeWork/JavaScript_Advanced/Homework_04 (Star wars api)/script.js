(() => {
    const peopleUrl = 'https://swapi.co/api/people/';
    const planetsUrl = 'https://swapi.co/api/planets/';
    let nextPagePeople = "";
    let nextPagePlanets = "";
    let people = [];
    let planets = [];

    function writePeopleInTable(list) {
        tBodyPeople.textContent = "";
        list.forEach((person, index) => {
            insertRowContentForPerson(person, index);
        })
    }

    function insertRowContentForPerson(somePerson, id) {

        let row = tBodyPeople.insertRow();
        // this needs to be reworked because the api is missing for some persons
        row.setAttribute("id", `people${id + 1}`);
        row.addEventListener("click", getCurrentPerson)

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
        tBodyPlanets.textContent = "";
        list.forEach((planets, index) => {
            insertRowContentForPlanet(planets, index);
        });
    }

    function insertRowContentForPlanet(somePlanet, id) {

        let row = tBodyPlanets.insertRow();
        // this needs to be reworked because the api is missing for some planets
        // this is because the api first planet is put on the end
        if (id !== 60) {
            row.setAttribute("id", `planets${id + 2}`);
            row.addEventListener("click", getCurrentPlanet)
        }
        else {
            row.setAttribute("id", `planets${1}`);
            row.addEventListener("click", getCurrentPlanet)
        }


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
        morePeoplesResults.classList.add("display-none");
        morePlanetResults.classList.add("display-none");
        informationConteiner.classList.add("display-none");
    }

    function disableLink() {
        peopleButton.classList.add("inactiveLink");
        planetsButton.classList.add("inactiveLink");
        homeButton.classList.add("inactiveLink");
        searchButton.classList.add("inactiveLink");
        morePeoplesResults.classList.add("inactiveLink");
        morePlanetResults.classList.add("inactiveLink");
    }

    function enableLink() {
        peopleButton.classList.remove("inactiveLink");
        planetsButton.classList.remove("inactiveLink");
        homeButton.classList.remove("inactiveLink");
        searchButton.classList.remove("inactiveLink");
        morePeoplesResults.classList.remove("inactiveLink");
        morePlanetResults.classList.remove("inactiveLink");
    }

    function callHome() {
        hideDomElements();
        logoPicture.classList.remove("display-none");
        searchButton.classList.remove("display-none");
        inputSearch.classList.remove("display-none");
    }

    function callPeople() {

        hideDomElements();
        //to show the animation while waiting
        animationGears.classList.remove("display-none");
        //if there is no content, make a call from the api
        if (tBodyPeople.textContent === "") {
            sendRequestForPeople(peopleUrl);
            // add event to show more results
            morePeoplesResults.addEventListener("click", () => {
                if (nextPagePeople !== null) {
                    // making another call
                    sendRequestForPeople(nextPagePeople)
                }
            });
        }
        // if there is already successful call
        else {
            //to hide the animation 
            animationGears.classList.add("display-none");
            writePeopleInTable(people);
            // to show the table
            table1People.classList.remove("display-none");
            // to show or hide "show result" button
            if (nextPagePeople === null) { morePeoplesResults.classList.add("display-none"); }
            else { morePeoplesResults.classList.remove("display-none"); }
        }
    }

    function sendRequestForPeople(urlPeople) {
        disableLink();
        fetch(urlPeople)
            .then(response => response.json())
            .then(function (myJson) {
                // to save all results in array 
                for (const person of myJson.results) {
                    people.push(person);
                }
                // To hide the animation
                animationGears.classList.add("display-none");
                writePeopleInTable(people);
                //to display the table
                table1People.classList.remove("display-none");
                // assigning the string that needs to be passed to the event listener to show more results
                nextPagePeople = myJson.next;
                // to hide the button show more results if there is no next page
                if (nextPagePeople === null) { morePeoplesResults.classList.add("display-none"); }
                else { morePeoplesResults.classList.remove("display-none"); }
                enableLink();
            }).catch(err => console.log(err));
    }

    function callPlanets() {
        hideDomElements();
        //to show the animation while waiting
        animationGears.classList.remove("display-none");
        //if there is no content, make a call from the api
        if (tBodyPlanets.textContent === "") {
            sendRequestForPlanets(planetsUrl)
            // add event to show more results
            morePlanetResults.addEventListener("click", () => {
                if (nextPagePlanets !== null) {
                    // making another call
                    sendRequestForPlanets(nextPagePlanets)
                }
            });
        }
        // if there is already successful call
        else {
            //to hide the animation 
            animationGears.classList.add("display-none");
            writePlanetsInTable(planets);
            // to show the table
            table2Planets.classList.remove("display-none");
            // to show or hide "show result" button
            if (nextPagePlanets === null) { morePlanetResults.classList.add("display-none"); }
            else { morePlanetResults.classList.remove("display-none"); }
        }
    }

    function sendRequestForPlanets(urlPlanets) {

        disableLink();
        fetch(urlPlanets)
            .then(response => response.json())
            .then(function (myJson) {
                // to save all results in array 
                for (const planet of myJson.results) {
                    planets.push(planet);
                }
                // To hide the animation
                animationGears.classList.add("display-none");
                //celar the table and write in it
                tBodyPlanets.textContent = "";
                writePlanetsInTable(planets);
                //to display the table
                table2Planets.classList.remove("display-none");
                // assigning the string that needs to be passed to the event listener to show more results
                nextPagePlanets = myJson.next;
                // to hide the button show more results if there is no next page
                if (nextPagePlanets === null) { morePlanetResults.classList.add("display-none"); }
                else { morePlanetResults.classList.remove("display-none"); }
                enableLink();
            }).catch(err => console.log(err));
    }

    async function listFromSearch(search) {

        let resultSearch = [];

        async function searchFromApi(searchUrl) {
            // try {
            let prom = await fetch(searchUrl);
            let myJson = await prom.json();


            myJson.results.forEach(planet => resultSearch.push(planet));
            let nextPage = myJson.next;
            if (nextPage !== null) { await searchFromApi(nextPage) };
            // } catch (err) { console.log(err)}
        }
        await searchFromApi(search);

        return resultSearch;
    }

    async function searchResults() {

        hideDomElements();
        disableLink();
        animationGears.classList.remove("display-none");

        // using API for search
        let stringPeople = `https://swapi.co/api/people/?search=${inputSearch.value}`;
        let stringPlanets = `https://swapi.co/api/planets/?search=${inputSearch.value}`;
        // try {
        // saving the lists from the search
        let searchOfpeople = await listFromSearch(stringPeople);
        let searchOfPlanets = await listFromSearch(stringPlanets);

        writePeopleInTable(searchOfpeople);
        writePlanetsInTable(searchOfPlanets);

        //displaying the tables
        animationGears.classList.add("display-none");
        table1People.classList.remove("display-none");
        table2Planets.classList.remove("display-none");
        searchButton.classList.remove("display-none");
        inputSearch.classList.remove("display-none");

        enableLink();
        // } catch (err) { console.log(err)}
    }

    async function getCurrentPerson(event) {
        let string = event.currentTarget.getAttribute("id");
        let idForCall = string.slice(6);
        await showDetailsForPerson(idForCall)
    }

    async function showDetailsForPerson(id) {

        let url = `https://swapi.co/api/people/${id}`
        let prom = await fetch(url);
        let person = await prom.json();

        informationConteiner.textContent = "";
        listOfDetailsForPerson(person);
        informationConteiner.classList.remove("display-none");
    }

    function listOfDetailsForPerson(elementObject) {
        let ul = document.createElement("ul");

        // we are traversing to the properties up until "films"
        for (const property in elementObject) {

            let li = document.createElement("li");
            // films is an array and we need to do more work to display them
            if (property === "films") {
                li.textContent = `${property}:`;

                // to put all the movies in a list, and show them as one list item in the main list of property
                let listOFmovies = elementObject[property];
                let ulFilms = document.createElement("ul");

                listOFmovies.forEach(element => {

                    let liMovies = document.createElement("li");
                    liMovies.textContent = `${element}`;
                    ulFilms.append(liMovies);
                })
                li.append(ulFilms);
                ul.append(li);
                // to append them in the container and stop the cycle
                informationConteiner.append(ul);
                return;
            }
            // this is for all other properies
            else {
                li.textContent = `${property}: ${elementObject[property]}`;
                ul.append(li);
            }
        }
    }

    async function getCurrentPlanet(event) {

        let string = event.currentTarget.getAttribute("id");
        let idForCall = string.slice(7);
        await showDetailsForPlanets(idForCall)
    }

    async function showDetailsForPlanets(id) {

        let url = `https://swapi.co/api/planets/${id}`
        let prom = await fetch(url);
        let planet = await prom.json();

        informationConteiner.textContent = "";
        listOfDetailsForPlanets(planet);
        informationConteiner.classList.remove("display-none");
    }

    function listOfDetailsForPlanets(elementObject) {
        let ul = document.createElement("ul");

        // we are traversing to the properties up until "films"
        for (const property in elementObject) {

            let li = document.createElement("li");
            // films is an array and we need to do more work to display them
            if (property === "residents") {
                li.textContent = `${property}:`;

                // to put all the movies in a list, and show them as one list item in the main list of property
                let listOFresidents = elementObject[property];
                let ulResident = document.createElement("ul");

                listOFresidents.forEach(element => {

                    let liResident = document.createElement("li");
                    liResident.textContent = `${element}`;
                    ulResident.append(liResident);
                })
                li.append(ulResident);
                ul.append(li);
                // to append them in the container and stop the cycle
                informationConteiner.append(ul);
                return;
            }
            // this is for all other properies
            else {
                li.textContent = `${property}: ${elementObject[property]}`;
                ul.append(li);
            }
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
    let morePeoplesResults = document.getElementById("morePeoplesResults");
    let morePlanetResults = document.getElementById("morePlanetResults");
    let informationConteiner = document.getElementById("informationConteiner");

    peopleButton.addEventListener("click", callPeople);
    planetsButton.addEventListener("click", callPlanets);
    homeButton.addEventListener("click", callHome);
    searchButton.addEventListener("click", searchResults);



})();