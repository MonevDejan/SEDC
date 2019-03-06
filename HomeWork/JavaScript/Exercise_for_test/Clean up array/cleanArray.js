let initialArray = [NaN, 0, 15, false, -22, '', undefined, 47, null,0, { name: dejan, presime:monev}];
let initialArray1 =  [1, NaN, 2, [3, NaN, 5, [1,2]] ];


function cleanUpArray ( someArray )
{ 
    let newArray =[];
    if(Array.isArray(someArray))
    {
        for (const value of someArray) 
        {
            if (!Array.isArray(value))
            {
                if(value)
                { newArray.push(value); }
                else
                {
                    if(value === 0)
                    { newArray.push(value); }
                    else { continue;}
                }
            } 
            else 
            { newArray.push(cleanUpArray (value)); }   
        }
       return newArray;
    }
    else
    { return "please enter valid array"; }
}
