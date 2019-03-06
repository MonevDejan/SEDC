$("#first_name").focusin( function () 
{ $("label[for='first_name']").removeAttr("hidden"); });

$("#first_name").focusout( function () 
{ $("label[for='first_name']").attr("hidden", "hidden"); });

$("#second_name").focusin( function () 
{ $("label[for='second_name']").removeAttr("hidden"); });

$("#second_name").focusout( function () 
{ $("label[for='second_name']").attr("hidden", "hidden"); });