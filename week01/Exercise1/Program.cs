using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise1 Project.");
        // Prompt the user to provide their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // PRompt the user to provide their last name 
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Display their formatted name
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}