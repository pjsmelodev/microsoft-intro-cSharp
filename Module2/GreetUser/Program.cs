﻿using System;

public class UserInput {
    public static void GreetUser() {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name + "!");
    }

    public static void Main(string[] args) {
        GreetUser();
    }
}