// Step 4: Handling User Input
public class UserInput {
    public static void GreetUser() {
        Console.WriteLine("Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name + "!");

    }

    public static void Main(string[] args) {
        GreetUser();
    }
}