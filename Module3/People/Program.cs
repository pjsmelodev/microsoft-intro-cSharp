using System;

public class Person {
    // Properties
    public string Name {get; set;}
    public int Age {get; set;}

    // Methods
    public void Greet(string name, int age) {
        Name = name;
        Age = age;
        Console.WriteLine($"Hi {Name}! You're {Age}, right?");
    }
}

public class Program {
    public static void Main(string[] args) {
        Person friend = new Person();
        friend.Name = "José";
        friend.Age = 55;

        Person colleague = new Person();
        colleague.Name = "Aristides";
        colleague.Age = 103;

        friend.Greet(friend.Name, friend.Age);
        colleague.Greet(colleague.Name, colleague.Age);
    }
}