// See https://aka.ms/new-console-template for more information

Console.Write("Please enter a number: ");

float userInput = float.Parse(Console.ReadLine());

float newFloat = userInput + .5f;

Console.WriteLine($"\nYour new floating number is {newFloat}");
