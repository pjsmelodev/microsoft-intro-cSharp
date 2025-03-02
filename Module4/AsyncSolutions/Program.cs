using System;

public class Product {
    public string Name { get; set; }

    public Product(string name) {
        Name = name;
    }
}

public class Program {
    public async Task<List<Product>> FetchProductsAsync() {
        await Task.Delay(2000);
        return new List<Product> {
            new Product("Eco Bag"),
            new Product("Resusable Straw")
        };
    }

    public async Task DisplayProductAsync() {
        List<Product> products = await FetchProductsAsync();
        foreach (Product product in products)
        {
            Console.WriteLine(product.Name);
        }
    }

    public static async Task Main(string[] args) {
        Program program = new Program();
        await program.DisplayProductAsync();
    }
}