// See https://aka.ms/new-console-template for more information

string userContinue;

do
{
    Console.Write("Please enter an integer: ");
    int userNumber = int.Parse(Console.ReadLine());

    for(int i = 1; i <= userNumber; i++)
    {
        Console.Write(i * i * i);
        Console.Write(" ");
    }

    Console.Write("\nWould you like to continue (y/n)?: ");
    userContinue = Console.ReadLine();

} while (userContinue == "y");
