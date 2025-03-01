using System;
using System.Threading.Tasks;

// In the Program.cs file, create a class called Program.
public class Program {

    // Inside the Program class, create a method named DownloadDataAsync.
    // Use the async keyword to make the method asynchronous.
    public async Task DownloadDataAsync() {
        // Modify the DownloadDataAsync method to include a try-catch block.
        try {
            // Print a message before and after the delay to show when the method starts and ends.
            Console.WriteLine("Download 1 started...");
            // Inside the method, use await Task.Delay to simulate a delay.
            await Task.Delay(3000);
            // Print a message before and after the delay to show when the method starts and ends.
            Console.WriteLine("Download 1 complete.");
        } 
        catch (Exception ex) {
            Console.WriteLine($"Error in download 1: {ex.Message}");
        }
    }

    // Below the DownloadDataAsync method, create a second method named DownloadDataAsync2.
    public async Task DownloadDataAsync2() {
        try {
            Console.WriteLine("Download 2 started...");
            await Task.Delay(4000);

            // Simulate an error by adding code that throws an exception.
            //throw new Exception("Simulated error.");

            Console.WriteLine("Download 2 complete.");
        } 
        catch (Exception ex) {
            Console.WriteLine($"Error in download 2: {ex.Message}");
        }
    }

    // Below the DownloadDataAsync method, create a Main method.
    public static async Task Main(string[] args) {
        // In the Main method, create an instance of the Program class. 
        Program instance1 = new Program();

        // Call the DownloadDataAsync method using await.
        await instance1.DownloadDataAsync();
        await instance1.DownloadDataAsync2();
        
        // Update the Main method to use Task.WhenAll to run DownloadDataAsync and DownloadDataAsync2 in parallel.
        await Task.WhenAll(instance1.DownloadDataAsync(), instance1.DownloadDataAsync2());
        Console.WriteLine("All downloads completed.");
    }
}