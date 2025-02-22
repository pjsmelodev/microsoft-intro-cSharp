public class Calculator {
    public static int number1;
    public static int number2;

    public static int Add() {
        return number1 + number2;
}

    static void Main(string[] args) {
        number1 = 5;
        number2 = 10;

        int result = Add();
        Console.WriteLine("Sum: " + result);
}
}

