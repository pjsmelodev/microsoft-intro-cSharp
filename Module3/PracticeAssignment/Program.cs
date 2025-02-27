using System;

// In the Person.cs file, define a class called Person that includes properties to represent a person's characteristics.
public class Person {
    // Create two properties: Name (a string) and Age (an integer).
    public string Name {get; set;}
    public int Age {get; set;}

    // Update the Person class by writing a method called Greet.
    public void Greet() {
        Console.WriteLine($"Hello, I'm {Name} and I'm {Age}.");
    }
}

public class Program {
    public static void Main(string[] args) {
        // Create two objects of the Person class.
        /*
        Person friend = new Person() ;
        Person familyMember = new Person();
        friend.Name = "José"; 
        friend.Age = 23;
        familyMember.Name = "António";
        familyMember.Age = 45;
        */
        Person friend = new Person { Name = "José", Age = 23 };
        Person familyMember = new Person { Name = "António", Age = 45 };
        Person stranger = new Person { Name = "Ana", Age = 25 };

        // Update the Main method to call the Greet method on each Person object to print a personalized greeting.
        friend.Greet();
        familyMember.Greet();

        // Update the Main method by creating a third Person object.
        /*
        Person stranger = new Person();
        stranger.Name = "Ana";
        stranger.Age = 25;
        */

        stranger.Greet();
        // SE A CLASSE TIVER PROPRIEDADES OBRIGATÓRIAS DEVO USAR UM CONSTRUTOR
    }
}