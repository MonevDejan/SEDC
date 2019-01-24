// for easy access to modify the coins we create array
let coins = [25, 10, 5, 2, 1];


function amountOfcoins(number) {

    if (number === 0) return;

    for (let i = 0; i < coins.length; i++) {
        if (number >= coins[i]) {
            console.log(coins[i]);
            amountOfcoins(number - coins[i]);
            break;
        }
    }
}

amountOfcoins(46);