using OperatorExercise;
//excersize1
var a = 17;
var b = 4;
var quotent = a / b;
var remainder = a % b;
Console.WriteLine($"{a}/{b} is {quotent} remainder {remainder}");

//excersise2
Console.WriteLine("what is the radius of your circle");
var userInput = double.Parse(Console.ReadLine());
var answer = Operators.AreaOfCircle(userInput);
Console.WriteLine($"The area of a circle with a radius of {userInput} is {answer}");

