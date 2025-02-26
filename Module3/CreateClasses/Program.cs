using System;

public class Person {
    public string Name {get; set;}
    public int Age {get; set;}

    //public Person() {}
    // É preciso criar um constructor se quiser instanciar a classe sem parâmetros (linha 20)

    public Person(string name, int age) {
        Name = name;
        Age = age;
    }

    public void DisplayInfo() {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public static void Main(string[] args) {
        Person person = new Person("Paulo", 39);
        /*
        Person person = new Person();
        person.Name = "Paulo";
        person.Age = 39;
        */
        person.DisplayInfo();

        Person neighbor = new Person("José", 53);
        neighbor.DisplayInfo();
        neighbor.Age = 52;
        neighbor.DisplayInfo();
    }
}