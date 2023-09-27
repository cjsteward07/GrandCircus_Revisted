// See https://aka.ms/new-console-template for more information

string userContinue = "y";

do
{
    Console.Clear();

    Console.WriteLine("Please choose a language from the menu below: ");

    Console.WriteLine("1.) English");
    Console.WriteLine("2.) Spanish");
    Console.WriteLine("3.) French");

    string userSelection = (Console.ReadLine());

    switch (userSelection)
    {
        case "1":
            Console.WriteLine("Hello World!");
            break;

        case "English":
            Console.WriteLine("Hello World");
            break;

        case "english":
            Console.WriteLine("Hello World");
            break;

        case "2":
            Console.WriteLine("Hola Mundo!");
            break;

        case "Spanish":
            Console.WriteLine("Hola Mundo!");
            break;

        case "spanish":
            Console.WriteLine("Hola Mundo!");
            break;

        case "3":
            Console.WriteLine("Bonjour le monde!");
            break;

        case "French":
            Console.WriteLine("Bonjour le monde!");
            break;

        case "french":
            Console.WriteLine("Bonjour le monde!");
            break;
    }

    Console.Write("Would you like to try again (y/n)?: ");
    userContinue = Console.ReadLine();

} while (userContinue == "y");

Console.WriteLine("Goodbye!");