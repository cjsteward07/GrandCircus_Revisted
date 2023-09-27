// See https://aka.ms/new-console-template for more information

string userLoop;
do
{
    Console.Clear();

    Console.WriteLine("Echo String Exercise");

    Console.Write("Please enter a word: ");
    string userText = Console.ReadLine();

    Console.Write("\nYou have entered: ");
    Console.WriteLine(userText);

    Console.Write("Would you like to continue (y/n)?: ");
    userLoop = Console.ReadLine();

} while (userLoop == "Yes" || userLoop == "yes" || userLoop == "Y" || userLoop == "y");

Console.WriteLine("Goodbye!");