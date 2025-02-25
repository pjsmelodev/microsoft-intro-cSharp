using System;

public class Animal {
    public virtual void MakeSound() {
        Console.WriteLine("Some generic animal sound.");
    }
}

public class Dog : Animal {
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal {
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Program {
    static void Main(string[] args) {  // 🔹 Método Main dentro de uma classe
        Dog dog = new Dog();
        dog.MakeSound();  // Output: Woof!

        Cat cat = new Cat();
        cat.MakeSound();  // Output: Meow!
    }
}
