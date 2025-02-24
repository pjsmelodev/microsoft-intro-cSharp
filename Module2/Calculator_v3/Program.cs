public class Calculator {
    public static int number1 = 13;
    public static int number2 = -2;

    public static int Add() {
        return number1 + number2;
    }

    public static void Main(string[] args) {
        int result = Add();
        Console.WriteLine(result);
    }
}