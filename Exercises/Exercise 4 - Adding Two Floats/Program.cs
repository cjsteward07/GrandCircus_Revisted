// See https://aka.ms/new-console-template for more information

Console.Write("Please enter a number: ");
float firstInput = float.Parse(Console.ReadLine());

Console.Write("Please enter a second number: ");
float secondInput = float.Parse(Console.ReadLine());

float inputTotal = firstInput + secondInput;

Console.WriteLine($"\nThe total of your numbers '{firstInput}' and '{secondInput}' is {inputTotal}");

