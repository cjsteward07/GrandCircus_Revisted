// See https://aka.ms/new-console-template for more information

const int triangleHeight = 10;
string userContinue;

do
{
    for (int i = 0; i < triangleHeight; i++)
    {

        for (int n = 0; n <= 1 * i; n++)
            Console.Write("*");
        Console.Write("\n");
    }




    Console.Write("Would you like to continue (y/n)?: ");
    userContinue = Console.ReadLine();

} while (userContinue == "y");
