// See https://aka.ms/new-console-template for more information


string userContinue;
int triangleHeight = 10;
do
{
    Console.Clear();

    for (int i = 0; i < triangleHeight; i++)
    {
        for (int n = 0; n <= i; n++)
        {
            Console.Write("*");
        }

        Console.Write("\n");
    }

    Console.WriteLine("\nWould you like to continue(y/n)?: ");
    userContinue = Console.ReadLine();

} while (userContinue == "y");
