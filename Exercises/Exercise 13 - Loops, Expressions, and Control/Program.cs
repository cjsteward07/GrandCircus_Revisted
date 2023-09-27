// See https://aka.ms/new-console-template for more information

string userContinue;
do
{
    Console.Clear();
    Console.Write("Please enter an integer: ");

    int userInteger = int.Parse(Console.ReadLine());

    for (int i = -1; i < userInteger; userInteger--)
    {
        Console.Write($"{userInteger} ");
    }

    Console.WriteLine("\nWould you like to run again (y/n)?");
    userContinue = Console.ReadLine();

} while (userContinue == "y");

Console.WriteLine("Goodbye!");