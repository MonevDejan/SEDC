/* The logic is simple:
we put each word as element in array 
than we compare the lenght */

function longest(someString){

    let longestWord;
    let length = 0;
    let charAray = someString.split(" ");

    for(  i=0;  i < charAray.length;  i++){

        if(charAray[i].length > length){
            length = charAray[i].length;
            longestWord = charAray[i];
        }
    }
    return longestWord;
}

console.log( longest("Please locate where is the longest word"));