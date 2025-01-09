using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Let the user know what the program is about
        Console.WriteLine("Enter a list of numbers. Type 0 when you're finished.");

        // Create a list to store the numbers
        List<int> numbers = new List<int>();

        // Variable to hold the user's input
        int userInput;

        // Start a loop to gather numbers from the user
        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            // Add the number to the list, but skip 0
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

        } while (userInput != 0);

        // If the list is empty, there's nothing to calculate
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        // Calculate the sum of the numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Calculate the average (make sure to use a double for precision)
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the largest number
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

        // Stretch: Find the smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        // Only display the smallest positive number if one exists
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // Stretch: Sort the list and display it
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
