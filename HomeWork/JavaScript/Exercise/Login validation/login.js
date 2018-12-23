let userData = [
    {
      email: 'knorr@live.com',
      password: 'ksGuQbzYPpW'
    },
    {
      email: 'rddesign@msn.com',
      password: '9Q6urHqy'
    },
    {
      email: 'chaffar@yahoo.ca',
      password: '4xaz2pyk'
    },
    {
      email: 'fatelk@mac.com',
      password: 'TAePJSb2ACX'
    },
    {
      email: 'luebke@me.com',
      password: 'EyFY8uhX'
    },
    {
      email: 'amichalo@mac.com',
      password: 'c7muQ6bxcA9QJKS'
    },
    {
      email: 'mallanmba@yahoo.ca',
      password: 'NqCGLmGtcFU'
    },
    {
      email: 'isaacson@att.net',
      password: 'PMjRGUug7Ff73Kt'
    },
    {
      email: 'aracne@aol.com',
      password: 'sBJU7JJR7Qx6f55'
    },
    {
      email: 'boser@comcast.net',
      password: 'DMXQRNj7BHZ'
    },
    {
      email: 'gtaylor@verizon.net',
      password: 'AbefrKfkbxHbP3u'
    },
    {
      email: 'firstpr@comcast.net',
      password: 'PGWPUtcwP'
    },
    {
      email: 'sumdumass@sbcglobal.net',
      password: '2DrCpjkk9mm8bjW'
    },
    {
      email: 'campbell@yahoo.com',
      password: 'ZmYZgaDq6'
    },
    {
      email: 'wetter@me.com',
      password: 'ppTG3pGAe'
    },
    {
      email: 'british@verizon.net',
      password: '67SbpGYvPJ2'
    }
];



function validation ()
{
  checkImputs();
  handler (checkForEmail, checkForPass);
  numbersClicked ();

  clickCounterLogIn += 1;
  checkForEmail = false;
  checkForPass = false;
}

function checkImputs()
{
  let emailValue = $("#email").val();
  let pasValue = $("#pass").val();
  
  for (const iterator of userData) 
  {
    if(emailValue === iterator.email) {checkForEmail = true; }
    if(pasValue === iterator.password) {checkForPass = true; }
  }
}

function handler ( emailBollean, passBolean)
{
  if (!emailBollean) 
  { 
    $("#email").attr("placeholder", "Email is not valid");
    $("#email").val("");
  }
  if (!passBolean)
  {
     $("#pass").attr("placeholder", "Password is not valid"); 
     $("#pass").val("");
  }
  if(emailBollean && passBolean)
  { afterLogIn(); }
}

function afterLogIn ()
{
  $("#root").hide();
  $("<div id='welcome'></div>").insertBefore("script[crossorigin='anonymous'");
  $("<p>").text("Welcome!").css("font-size", "20px").appendTo("#welcome");
  $("<button id='logOut'> Log out </button>").appendTo("#welcome");
  $("#logOut").on("click", logOut);
}

function logOut ()
{
  $("#root").show();
  $("#welcome").remove();
  clickCounterLogIn = 0;
}

function numbersClicked ()
{

  let validUser = (checkForEmail && checkForPass );

  if( (clickCounterLogIn  >=2) && !validUser)  
  { 
    $("#loginBtn").off("click"); 
    $("<p>").text("You have entered incorect user 3 times. Please refresh your page")
    .css("color", "red")
    .insertBefore("button");
  }

}

let clickCounterLogIn = 0;
let checkForEmail = false;
let checkForPass = false;
let body = $("body").html();

$("#loginBtn").on("click", validation);