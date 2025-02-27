using System;

public async Task GetDataAsync() {
    var data = await GetDataFromAPI();
    // await -> pausa a execução do método até que a tarefa termine
    Console.WriteLine(data);
}

public class Program {
    public static void Main(string[] args) {
        
    }
}