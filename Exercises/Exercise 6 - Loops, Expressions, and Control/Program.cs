// See https://aka.ms/new-console-template for more information

//do while loops will always run once because it doesn't read the while condition until after the do block is processed.
//variables used as the while condition need to be declared outside of the loops otherwhise the variable will get re-initialized. Remember scope

string userInput;

do
{
    Console.WriteLine("Hello, World!");
    Console.Write("Would you like to continue (y/n)?: ");
    userInput = Console.ReadLine();

} while (userInput == "Yes" || userInput == "yes" || userInput == "Y" || userInput == "y");
