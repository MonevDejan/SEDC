let initialArray = [NaN, 0, 15, false, -22, '', undefined, 47, null, 0, { name: "dejan", secondname: "monev" }, function random () {}];
let initialArray1 = [1, NaN, 2, [3, NaN, 5, [1, 2]]];

function cleanUpArray(someArray) {
    let newArray = [];
    if (Array.isArray(someArray)) {

        for (const value of someArray) {

            if (Array.isArray(value)) {
                newArray.push(cleanUpArray(value));
            }

            else {

                if (value) { newArray.push(value); }
                else {
                    if (value === 0 || value === false) { newArray.push(value); }
                    else { continue; }
                }
            }
        }

        return newArray;
    }
    else { return "please enter valid array"; }
}

console.log(cleanUpArray(initialArray));