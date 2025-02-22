using System;

public class UserInput {
    static void GreetUser() {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");
    }

    static void Main() {
        GreetUser();
    }
}