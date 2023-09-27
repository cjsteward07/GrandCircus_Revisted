// See https://aka.ms/new-console-template for more information

const float requiredHeight = 54;
float riderHeight;
string userContinue;
do
{
    Console.Clear();

    Console.WriteLine("Let's see if you're tall enough to ride the roller coaster");
    Console.Write("Please enter your height in inches: ");
    riderHeight = float.Parse(Console.ReadLine());


    if (riderHeight < requiredHeight)
    {
        float heightDifference = requiredHeight - riderHeight;
        Console.WriteLine($"\nI'm sorry, but you need to grow {heightDifference} more inches");
    }
    else if (riderHeight >= requiredHeight)
    {
        Console.WriteLine($"\nCongrats, you're height of {riderHeight} inches meets the requirement of {requiredHeight} inches. Enjoy the ride!");
    }

    Console.WriteLine("\nWould you like to try another height (y/n)?: ");
    userContinue = Console.ReadLine();

} while (userContinue == "y");