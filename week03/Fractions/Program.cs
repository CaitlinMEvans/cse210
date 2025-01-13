using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Fractions Project.");
        Console.WriteLine("Welcome to the Fraction Program!");
        Console.WriteLine("Let's explore how we can create and use fractions.");

        // Example 1: Using the default constructor (1/1)
        Console.WriteLine("\nExample 1: Using the default constructor.");
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction: {fraction1.GetFractionString()}");
        Console.WriteLine($"Decimal value: {fraction1.GetDecimalValue()}");

        // Example 2: Using the one-parameter constructor (numerator only, denominator is 1)
        Console.WriteLine("\nExample 2: Using the one-parameter constructor.");
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"Fraction: {fraction2.GetFractionString()}");
        Console.WriteLine($"Decimal value: {fraction2.GetDecimalValue()}");

        // Example 3: Using the two-parameter constructor (numerator and denominator)
        Console.WriteLine("\nExample 3: Using the two-parameter constructor.");
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction: {fraction3.GetFractionString()}");
        Console.WriteLine($"Decimal value: {fraction3.GetDecimalValue()}");

        // Example 4: Modifying numerator and denominator using setters
        Console.WriteLine("\nExample 4: Modifying the numerator and denominator.");
        Fraction fraction4 = new Fraction(); // Start with default (1/1)
        fraction4.SetNumerator(1);           // Update numerator to 1
        fraction4.SetDenominator(3);        // Update denominator to 3
        Console.WriteLine($"Fraction: {fraction4.GetFractionString()}");
        Console.WriteLine($"Decimal value: {fraction4.GetDecimalValue()}");

        // Example 5: Demonstrating validation for denominator (preventing zero)
        Console.WriteLine("\nExample 5: Preventing an invalid denominator.");
        try
        {
            fraction4.SetDenominator(0); // Attempt to set denominator to zero (should fail)
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine("\nThank you for exploring fractions with me!");
    }
}