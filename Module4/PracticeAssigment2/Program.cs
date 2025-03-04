using System;
using System.Threading.Tasks;

// In the Program.cs file, create a class called Program.
public class Program {

    // Inside the Program class, create a method called PerformLongOperationAsync.
    public async Task PerformLongOperationAsync() {

        // Modify the PerformLongOperationAsync method to include a try-catch block.
        try {
            // Use await Task.Delay to simulate a delay within the method.
            Console.WriteLine("Operation initiated:");
            await Task.Delay(2000);
            // Add a Console.WriteLine statement after the await in the PerformLongOperationAsync method.
            Console.WriteLine("Operation completed.");
        }
        catch (Exception ex) {
            Console.WriteLine($"Error performing long operation: {ex}");
            Console.WriteLine("Restarting operation...");
            await PerformLongOperationAsync();
        }
    }

    // Below the PerformLongOperationAsync method, create a Main method.
    public static async Task Main(string[] args) {
        
        // In the Main method, call the PerformLongOperationAsync method using Task.Run.
        Program task1 = new Program();

        await task1.PerformLongOperationAsync();
    }

}