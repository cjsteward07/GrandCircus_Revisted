﻿// See https://aka.ms/new-console-template for more information

string userContinue = "y";

do
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"{i} ");
    }

    Console.WriteLine("\nWould you like to run again (y/n)?");
    userContinue = Console.ReadLine();

} while (userContinue == "y");
