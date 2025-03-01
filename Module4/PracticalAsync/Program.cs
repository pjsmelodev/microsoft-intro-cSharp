using System;
using System.Threading.Tasks;
using System.Collections.Generic;

public class Program
{
    // Classe Product dentro do Program (poderia ser separada, mas funciona assim)
    public class Product
    {
        public string Name { get; set; }

        public Product(string name)
        {
            Name = name;
        }
    }

    // Método assíncrono para buscar produtos
    public async Task<List<Product>> FetchProductsAsync()
    {
        try
        {
            await Task.Delay(2000); // Simula um atraso de 2 segundos

            return new List<Product>
            {
                new Product("Eco Bag"),
                new Product("Reusable Straw")
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching products: {ex.Message}");
            return new List<Product>(); // Retorna uma lista vazia para evitar erros
        }
    }

    // Simula a busca de reviews (precisava ser implementado)
    public async Task<List<string>> FetchReviewAsync()
    {
        try
        {
            await Task.Delay(1000); // Simula um atraso de 1 segundo
            return new List<string> { "Great product!", "Very useful!" };
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching reviews: {ex.Message}");
            return new List<string>(); // Retorna lista vazia em caso de erro
        }
    }

    // Exibe os produtos obtidos
    public async Task DisplayProductsAsync()
    {
        var products = await FetchProductsAsync();

        foreach (var product in products)
        {
            Console.WriteLine(product.Name);
        }
    }

    // Busca produtos e reviews ao mesmo tempo
    public async Task FetchDataAsync()
    {
        var productTask = FetchProductsAsync();
        var reviewTask = FetchReviewAsync();
        await Task.WhenAll(productTask, reviewTask);

        // Exibir os resultados após a busca paralela
        var products = await productTask;
        var reviews = await reviewTask;

        Console.WriteLine("\nProducts:");
        foreach (var product in products)
        {
            Console.WriteLine($"- {product.Name}");
        }

        Console.WriteLine("\nReviews:");
        foreach (var review in reviews)
        {
            Console.WriteLine($"- {review}");
        }
    }

    // Método principal da aplicação
    public static async Task Main(string[] args)
    {
        Program instance = new Program();
        await instance.FetchDataAsync();
    }
}
