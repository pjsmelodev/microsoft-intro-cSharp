// Step 4: Implementing Interfaces
public interface IAnimal {
    void Eat();
}


// Step 2: Creating a Base Class and Derived Classes
public class Animal : IAnimal {
    // Define a base class Animal with a virtual method MakeSound.
    public virtual void MakeSound() {
        Console.WriteLine("Some sound.");
    }

    public virtual void Eat() {
        Console.WriteLine("Generic animal eating stuff.");
    }
}

public class Dog : Animal {
    public override void MakeSound()
    {
        Console.WriteLine("Bark.");
    }

    public override void Eat() {
        Console.WriteLine("Dog is eating stuff.");
    }
}

public class Cat : Animal {
    public override void MakeSound()
    {
        Console.WriteLine("Meow.");
    }

    public override void Eat() {
        Console.WriteLine("Cat is eating stuff.");
    }
}

public class Program {
    public static void Main(string[] args) {
        Animal GenericAnimal = new Animal();
        Dog MrFluffy = new Dog();
        Cat MrsPurrs = new Cat();

        GenericAnimal.MakeSound();
        MrFluffy.MakeSound();
        MrsPurrs.MakeSound();

        Console.WriteLine("\n\n\n");

        GenericAnimal.Eat();
        MrFluffy.Eat();
        MrsPurrs.Eat();

        Console.WriteLine("\n\n\n");

        List<Animal> animals = new List<Animal>();
        animals.Add(new Animal());
        animals.Add(new Dog());
        animals.Add(new Cat());

        foreach (Animal animal in animals) {
            animal.MakeSound();
        }
    }
}