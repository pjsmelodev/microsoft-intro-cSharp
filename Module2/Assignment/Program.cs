// Step 1: Creating a Simple Calculator
public class Calculator {
    public static int number1, number2;

    public static int Add() {
        return number1 + number2;
    }

// Step 2: Executing the Calculator Program
    public static void Main(string[] args) {
        number1 = 10;
        number2 = -3;

        Console.WriteLine(Add());
    }
}