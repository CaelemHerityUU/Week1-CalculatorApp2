// Variables names should be short yet meaningful.

//This integer variable stores the first number
//Ask the user to input the first number
Console.WriteLine("Type in the first number followed by the Enter Key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

//Variable stores the second number
//Ask the user to input the second number.
Console.WriteLine("Type the second number followed by the Enter Key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//The "result" is the addition of firstNumber and secondNumber
int result = firstNumber + secondNumber;

//Output the answer to the console
Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);