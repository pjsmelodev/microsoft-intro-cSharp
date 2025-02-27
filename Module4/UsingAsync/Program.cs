using System;
using System.Threading.Tasks;

class Program
{
    public async Task DownloadDataAsync()
    {
        try {
            Console.WriteLine("Download started...");
            await Task.Delay(5000);
            Console.WriteLine("Download completed.");
        } catch (Exception ex) {
            Console.WriteLine("An error accurred: " + ex);
        }
    }

    public async Task DownloadDataAsync2() {
        try {
            Console.WriteLine("Download 2 started...");
            await Task.Delay(10000);
            Console.WriteLine("Download 2 completed.");
        } catch (Exception ex) {
            Console.WriteLine("An error occurred: " + ex);
        }
    }

    public static async Task Main(string[] args)
    {
        Program program = new Program(); 
        Task task1 = program.DownloadDataAsync();
        Task task2 = program.DownloadDataAsync2();

        try {
            await Task.WhenAll(task1, task2);
            // se isto for comentado o programa não vai esperar que as tasks com await terminem e assim que chegar ao final do código, se elas não tiverem terminado, o programa termina
            Console.WriteLine("All downloads complete.");
        } catch (Exception ex) {
            Console.WriteLine("A global error occurred: " +  ex);
        }
    }
}
