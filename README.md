# SEDC
Class 1
Object has 4 property 
Indexers - can be used to mimic array ( its not logical to use indexers for iterable data type)
readonly - is different from const (it can be initilized with constructor or directly)
Struct - like a class but directly write to the memory ??

There are 5 constructors
	-Parametarless (if not specified created by default)
	-Instance (specifying propertyes in it)
	-Static constructor (for static classes or classes that has static propertyes)
		A typical use of static constructors is when the class is using a log file
		and the constructor is used to write entries to this file.
		static property can be assesed trouh internal method
	-Copy constructor (writen in the class)
	-Clone constructor (only in corner case scenarious )

Class 2
Abstract class - cant be instaced. It is only the plan for the deriving classes
		Properties can also be abstract witch means they need to be implemented in the 
		deriving class.

Interfaces - 	An interface can contain public members such as properties and 
		methods but these members must have no functionality. 

when calling : base() you dont need to specify the properties again in the body

Class3
Static class
	- Can not be instantiate
	- Can not be inherited
	- All methods and property must be static 
	- it uses direct memory and can be assesed from everywhere 
	- Can not inherited from other class (except object)
	- Can use static constructor
Extension methods 
	- An extension method is created by adding a static method to a static class
	- The first parameter is decorated with the keyword this (different from the this pointer)
Partial Class 
	- When working on large projects, spreading a class over separate files enables multiple 
		programmers to work on it at the same time.
	- When working with automatically generated source, code can be added to the class without having 
		to recreate the source file. Visual Studio uses this approach when it
 		creates Windows Forms, Web service wrapper code, and so on.
 		You can create code that uses these classes without having to modify the 
		file created by Visual Studio.
	- Need to satisfy all the norms like one class

Partial methods 
	- Must be declared in partial class
	- Must return void
	- Consists of two parts: the definition, and the implementation.

Nested class 
	- They behave the same way as the other classes.
	- Nested classes can have access to the private members of the outer classes.

StringBuilder - 

Class4 - workshop

Class5 

Generics 
	- It allow us to define a class
	- It usese place holder for the type. The Type is defined in run time
	- A generic class can be defined using angle brackets <>
	- They are mostly used for collection classes
params keyword
 	- specify a method parameter that takes a variable number of arguments
	- No additional parameters are permitted after the params keyword in a method declaration, 
	  	and only one params keyword is permitted in a method declaration.
	- The declared type of the params parameter must be a single-dimensional array
Delegates 	
	- used to pass methods as parametar (like in JavaScript)
	- Delegates are the basis for Events
	- Needs to be declared where classes are declared
	- Can have multiply functions in one delegate and if that delegate is invoked,
		all of the functions that he possese are invoked if they are void
		but if functions has return value only the last one is called
Events 
	- Event Handlers in the .NET Framework return void and take two parameters.
	- The first paramter is the source of the event; that is the publishing object.
	- The second parameter is an object derived from EventArgs.
	- Events are properties of the class publishing the event.
	- The keyword event controls how the event property is accessed by the subscribing classes.
	- events are created in 3 steps:
		1. Create delegate and event in the publisher (source og the event)
		2. Create protected method that invoke the event	
		3. Connect subscribers to the event (different classes)
		4. Invoke the event in some method in the sorce
Anonymous Methods 
	- Used for declaring delegates directly with code in block
	- depricated form lambda expression but has advantage over them because 
		they can be converted to delegates with a variety of signatures

Class 6

Func delegate 
	- Uses generic
	- Encapsulate (declare method) without need of class or explicitly declaring a custom delegate
	- We can use anonimoys methods or lambda expression to declare it or pass a ref to a method
	- Must have one parameter that is passed to it by value, and that it must return a value

Action delegate
	- Uses generic
	- Encapsulates a method that has a single parameter and does not return a value (void)
	- We can use anonimoys methods or lambda expression to declare it or pass a ref to a method

Lambda expression (arrow function)
	- It is delegate (that is declared as anonymous methods) that corresponds to Func and Action
	- All restrictions that apply to anonymous methods also apply to lambda expressions.
	- It is mostly used in 
		1. Passing the code that is to be executed to asynchronous methods, 
			such as Task.Run(Action).
		2.Writing LINQ query expressions
		3.Creating expression trees
Local functions

