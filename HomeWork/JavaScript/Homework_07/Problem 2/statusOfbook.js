function createBookObject(title, author, status)   // how to set status to work only with 2 values???
{
    if (title === null || title=== "" ) {title ="unKnown" }
    if (author === null || author === "" ) {author ="unKnown" }
    if (status === null ||  status  === "" ) {status = false }
    else { status = true};
    
    let parametars = 
    {
        title: title,
        author: author,
        status: status,
        readingStatus: function() 
        { 
            if (this.status) { document.getElementById("paragraph").innerText = `Already read ${this.title} by ${this.author}`}
            else { document.getElementById("paragraph").innerText = `You still need to read ${this.title} by ${this.author}.`}
        }
    }
    return parametars;
}


let title = prompt("Title of book");
let author = prompt("Author of book");
let status = prompt("Status of book");


let book= createBookObject(title, author, status);
book.readingStatus();


