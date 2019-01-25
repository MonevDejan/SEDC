const familyTree = [{
    name: "Oliver",
    lastname: "Stones",
    childrens: [
        {
            name: "Viktor",
            lastname: "Stones",
            childrens: []
        },
        {
            name: "Suzan",
            lastname: "Sloun",
            childrens: [
                {
                    name: "Oliver jr",
                    lastname: "Sloun",
                    childrens: [
                        {
                            name: "Alexandar",
                            lastname: "Sloun",
                            childrens: [
                                {
                                    name: "Suzie",
                                    lastname: "Sloun",
                                    childrens: []
                                }
                            ]
                        }
                    ]
                },
                {
                    name: "Alex",
                    lastname: "Sloun",
                    childrens: [
                        {
                            name: "Gabriel",
                            lastname: "Sloun",
                            childrens: [
                                {
                                    name: "Gabriela",
                                    lastname: "Sloun",
                                    childrens: []
                                }
                            ]
                        }
                    ]
                }
            ]
        }
    ]
}];     //51

// we declare this array if we have more than one person with same name
let personArray = [];


function findPersons (someArray, nameOfstring) {
	for (let element of someArray) {
		if(element.name === nameOfstring) {
			personArray.push(element);
		} //61

		if ( Array.isArray(element.childrens)) {
			findPersons(element.childrens, nameOfstring);
		}

	}
}

//70
function findDecendants (someArray) {

	for (let element of someArray) {
		console.log(element.name);

		if ( Array.isArray(element.childrens)) {
			findDecendants(element.childrens);
		}

	}
}

findPersons (familyTree, "Oliver jr");
findDecendants (personArray[0].childrens);


