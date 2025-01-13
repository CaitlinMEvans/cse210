using System;

public class Fraction
{
    // Private attributes for numerator and denominator
    private int _numerator;
    private int _denominator;

    // Default constructor: Initializes to 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with one parameter (numerator only, denominator defaults to 1)
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor with two parameters
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getter for numerator
    public int GetNumerator() => _numerator;

    // Setter for numerator
    public void SetNumerator(int numerator) => _numerator = numerator;

    // Getter for denominator
    public int GetDenominator() => _denominator;

    // Setter for denominator
    public void SetDenominator(int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _denominator = denominator;
    }

    // Returns the fraction as a string (e.g., "3/4")
    public string GetFractionString() => $"{_numerator}/{_denominator}";

    // Returns the decimal value of the fraction (e.g., 0.75 for "3/4")
    public double GetDecimalValue() => (double)_numerator / _denominator;
}