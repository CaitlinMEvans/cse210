using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the DisplayWelcome function to greet the user
        DisplayWelcome();

        // Get the user's name by calling PromptUserName and save the result
        string userName = PromptUserName();

        // Get the user's favorite number by calling PromptUserNumber and save the result
        int userNumber = PromptUserNumber();

        // Calculate the square of the number by calling SquareNumber
        int squaredNumber = SquareNumber(userNumber);

        // Display the result using DisplayResult
        DisplayResult(userName, squaredNumber);
    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt the user for their favorite number and return it as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to calculate and return the square of a given number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the user's name and the squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
