// See https://aka.ms/new-console-template for more information

string userLoop;
bool userBool = false;
bool boolToReturn = false;

do
{
    //exercise 2
    Console.Write("Hello, please enter a number: ");
    int userNumber = int.Parse(Console.ReadLine());
    int userNumberPlusOne = userNumber + 1;
    Console.WriteLine($"\nyour new number is {userNumberPlusOne}");

    //exercise 3
    Console.Write("\nPlease enter a number: ");
    float userInput = float.Parse(Console.ReadLine());
    float newFloat = userInput + .5f;
    Console.WriteLine($"\nYour new floating number is {newFloat}");

    //exercise 4
    Console.Write("\nPlease enter a number: ");
    float firstInput = float.Parse(Console.ReadLine());
    Console.Write("Please enter a second number: ");
    float secondInput = float.Parse(Console.ReadLine());
    float inputTotal = firstInput + secondInput;
    Console.WriteLine($"\nThe total of your numbers '{firstInput}' and '{secondInput}' is {inputTotal}");

    //exercise 5
    Console.Write("\nPlease enter a number: ");
    float firstUserInput = float.Parse(Console.ReadLine());
    Console.Write("Please enter a second number: ");
    float secondUserInput = float.Parse(Console.ReadLine());
    float userInputMultiplied = firstUserInput * secondUserInput;
    Console.WriteLine($"\nThe multiplied total of your numbers '{firstUserInput}' and '{secondUserInput}' is {userInputMultiplied}");

    //exercise 5.1
    try
    {
        Console.Write("\nPlease enter a number: ");
        int userFirstInput = int.Parse(Console.ReadLine());
        Console.Write("Please enter another number: ");
        int userSecondInput = int.Parse(Console.ReadLine());
        int userInputDivided = userFirstInput / userSecondInput;
        Console.Write($"\n'{userFirstInput}' divided by '{userSecondInput}' is {userInputDivided}");
    }
    catch (FormatException)
    {
        //A Format Exception is thrown when a non-int is entered as an input. This could be handled with adding input verification
        Console.WriteLine("FormatException caught. Creating a method to verify user input could resolve this issue");
    }

    //exercise 5.2
    
    Console.Write("\nPlease enter a boolean (example: 'True' or 'False'): ");
    userBool = bool.Parse(Console.ReadLine());
    if (userBool == false)
    {
        boolToReturn = true;
    }
    else if (userBool == true)
    {
        boolToReturn = false;
    }
    Console.WriteLine($"\nThe return boolean would be {boolToReturn} since you entered {userBool}");
    Console.Write("Would you like to run again (y/n)?: ");
    userLoop = Console.ReadLine();

} while( userLoop == "Yes" || userLoop == "yes" || userLoop == "Y" || userLoop == "y" );

Console.WriteLine("Goodbye!");
