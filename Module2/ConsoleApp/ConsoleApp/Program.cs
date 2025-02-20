/*
// Method to divide two numbers with error handling
using System;
public class Program
{
public static double DivideNumbers(double numerator, double denominator)
{
    if (denominator == 0)
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
        return double.NaN; // Return "Not a Number" to indicate an error
    }
    
    double result = numerator / denominator;
    return result;
}

public static void Main()
{
    // Attempt to divide 10 by 0
    double result = DivideNumbers(10, 0);
    Console.WriteLine("The result is: " + result);
}
}
*/

/*
using System;
public class Program
{
// Method to calculate the average of an array with error handling
public static double CalculateAverage(int[] numbers)
{
    if (numbers.Length == 0)
    {
        Console.WriteLine("Error: Cannot calculate the average of an empty array.");
        return double.NaN; // Return "Not a Number" to indicate an error
    }

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return (double)sum / numbers.Length;
}

public static void Main()
{
    int[] numbers = {}; // Empty array
    double average = CalculateAverage(numbers);
    Console.WriteLine("The average is: " + average);
}
}
*/

using System;
public class Program
{
    public static int FindMax(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    public static void Main()
    {
        int[] myNumbers = { -5, -10, -3, -8, -2 };
        int maxNumber = FindMax(myNumbers);
        Console.WriteLine("The maximum number is: " + maxNumber);
    }
}