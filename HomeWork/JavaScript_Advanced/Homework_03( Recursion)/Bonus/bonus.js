function findMissingElements (someArray) {
	
	for (let i = 0; i < someArray.length; i++) {
		
		let check = someArray.indexOf(someArray[0]+i);
		if(check === -1) {
			console.log(someArray[0]+i);
			
			let counter = 1;

			while (someArray.indexOf(someArray[0]+i+counter) === -1) {
				console.log(someArray[0]+i+counter);
				counter += 1;
			}


			let newArray = someArray.splice(someArray[0]+i -1);
			findMissingElements (newArray);
			break;
			
		} 
	}
}

let test = [1,2,6,7,9];

findMissingElements(test);