function reverse_a_number(someNumber)
{
	someNumber += "";
	return someNumber.split("").reverse().join("");
}
console.log(reverse_a_number(12345));