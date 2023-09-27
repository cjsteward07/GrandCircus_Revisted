// See https://aka.ms/new-console-template for more information

bool boolToReturn = false;

Console.Write("Please enter a boolean (example: 'True' or 'False'): ");

bool userInput = bool.Parse(Console.ReadLine());

if (userInput == false)
{
    boolToReturn = true;
}
else if (userInput == true)
{
    boolToReturn = false;
}

Console.WriteLine($"\nThe return boolean would be {boolToReturn} since you entered {userInput}");
