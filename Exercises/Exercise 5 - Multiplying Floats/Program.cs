// See https://aka.ms/new-console-template for more information

Console.Write("Please enter a number: ");
float firstUserInput = float.Parse(Console.ReadLine());

Console.Write("Please enter a second number: ");
float secondUserInput = float.Parse(Console.ReadLine());

float userInputMultiplied = firstUserInput * secondUserInput;

Console.WriteLine($"\n The multiplied total of your numbers '{firstUserInput}' and '{secondUserInput}' is {userInputMultiplied}");