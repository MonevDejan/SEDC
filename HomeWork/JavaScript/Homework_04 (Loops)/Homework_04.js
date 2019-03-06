function PutElementsInArry()
{ 
    let numberOfElements = prompt("Enter some number");
    let elements = parseFloat(numberOfElements);

    if (isNaN(elements)) 
    {  return 0; }     // return 0 is just to help us validate the code in easy way
    else 
    {  
        let list = [];
        for (let counter = 0; counter < elements ; counter++) 
        { list[counter] = counter+1; }
        return list;
    }
}

function WritingElementsFromArry()
{
    let someArray = PutElementsInArry();
    if (someArray === 0)                  // validation
    { document.getElementById("Problem1").innerHTML = "Incorect input!  Check your number"; }
    else
    {
        let stringForParagraph = "";
        let stringForConsole ="";
        let newLine = 1 ;
        for (let counter=1; counter <= someArray.length; counter++) 
        {
            if(counter === newLine * 4) // to make the check for new line
            {
                stringForParagraph += counter + "<br/>"; //because we are writing in paragraf <br/> is needed for new line
                newLine +=1;

                // This is just to show in console
                stringForConsole += counter;
                console.log(stringForConsole);
                stringForConsole = "";
            }
            else
            { 
                stringForParagraph += counter + " "; 
                stringForConsole += counter + " "; 
            }
        }
        //To show the last row in console
        let check = (someArray.length % 4) !== 0;
        if(check) { console.log(stringForConsole); }

        document.getElementById("Problem1").innerHTML = stringForParagraph;
    }  
}

function WritingDaysOfWeek()
{
    let arryOfDays = ["Monday", "Tuesday", "Wednesday","Thursday", "Friday", "Saturday", "Sunday"];
    let workingDays = ["Working", "Working", "Working", "Working", "Working", "Weekend","Weekend"];

    let stringForParagraph = "";
    let stringForConsole ="";

    for (let index = 0; index < arryOfDays.length; index++) 
    {
        stringForParagraph += arryOfDays[index] + ":" + workingDays[index] + "<br/>";

        //To show the last row in console
        stringForConsole  += arryOfDays[index] + ":" + workingDays[index];
        console.log(stringForConsole);
        stringForConsole = "";
    }
    document.getElementById("Problem2").innerHTML = stringForParagraph;
}

function CalculateCombination( n = prompt("Insert the number of elements N="), k = prompt("Insert number of combinaton K="))
{
    let setOfelements = parseFloat(n);
    let kombinations = parseFloat(k);
    let checkForNan = isNaN(setOfelements) || isNaN(kombinations);
    let invalidParameters = kombinations > setOfelements;   // n must be greater than k
    console.log(invalidParameters);
    //Validation
    if (checkForNan || invalidParameters) 
    {  document.getElementById("Problem3").innerHTML = "Incorect input! Check your number (n must be greater than k)";} 
    else 
    {
        /* The formula for combination is n!/k! * (n-k)!
         We can simplify this formula to increase the range of our function
         and only calculate faktoriel from k to n  */ 
        
        let valueOf_n = 1;
        let valueOf_nk = 1;

        for (let index = kombinations; index < setOfelements; index++)
        { valueOf_n*= (index+1); }

        for (let index = 0; index < (setOfelements - kombinations); index++)
        { valueOf_nk *= (index+1); }
        
        let combinations = valueOf_n/ valueOf_nk;
        console.log(valueOf_n);
        console.log(valueOf_nk);
        //check for infinity
        if(isFinite(combinations))
        { document.getElementById("Problem3").innerHTML = combinations; }
        else
        { document.getElementById("Problem3").innerHTML = "The number of combination is too great for javascript"; }
    }
}