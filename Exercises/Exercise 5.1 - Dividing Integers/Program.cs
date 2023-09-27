// See https://aka.ms/new-console-template for more information

try
{
    Console.Write("Please enter a number: ");
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


