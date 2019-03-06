let h1 = document.querySelector("h1");
h1.innerText = "Very cool stuff";

let paragraphWithClass = document.querySelectorAll("p.paragraph");
paragraphWithClass[0].innerText = "Good exercise";

let secondp = document.querySelector("div.anotherDiv").firstElementChild;
secondp.innerText = "It is easy after you read about it :)"

document.querySelector("text").innerText = "It's about selecting elements and the right chose";

let header1 = document.querySelector("#escaping\\\\characters");
header1.innerText = "It is changed";
header1.nextElementSibling.innerText = "And this also";





// let proba = Array.isArray(h1);

// {
//     let firstdiv = document.getElementsByTagName("div")[0];
//     let h1 = firstdiv.getElementsByTagName("h1");
//     h1[0].innerText = "very cool page";
    
//     h1[0].setAttribute("style", "border: 1px solid blue;");
//     h1[0].setAttribute("style", "border: 1px solid yellow");
//     h1[0].style.color = "blue";
// }

// document.getElementById("myTitle").style.color = "red";
// document.body.appendChild(heading)

// {
//     let h1 = document.getElementById("myTitle");
//     h1.innerText = "Not so cool anymore :( ";
//     h1.nextElementSibling.innerText = "It is hard";
    
//     let p = document.getElementsByTagName("div");
//     console.log(p);
    
//     p[1].firstElementChild.innerText = "Hards as math in Chinese language!";
//     p[1].lastElementChild.innerText = "It's about selecting elements and the right chose ";
    
//     p[2].firstElementChild.innerText = "This should not be changed";
//     p[2].lastElementChild.innerText= "We should change this";
// }