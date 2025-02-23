public class Calculator {
    public static int number1 = 5;
    public static int number2 = 10;

    public static int Add() {
        return number1 + number2;
    }

    public static void Main(string[] args) {
        int result = Add();

        Console.WriteLine("The sum: " + result);
    }
}