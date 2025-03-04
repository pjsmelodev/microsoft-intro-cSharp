using System;

class Program
{
    static void Main()
    {
        string[] books = new string[5]; // Array para armazenar até 5 livros
        while (true)
        {
            Console.WriteLine("\nChoose an action: add, remove, list, or exit");
            string action = Console.ReadLine().Trim().ToLower();

            switch (action)
            {
                case "add":
                    AddBook(books);
                    break;
                case "remove":
                    RemoveBook(books);
                    break;
                case "list":
                    ListBooks(books);
                    break;
                case "exit":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid action. Please enter 'add', 'remove', 'list', or 'exit'.");
                    break;
            }
        }
    }

    static void AddBook(string[] books)
    {
        Console.Write("Enter the book title: ");
        string newBook = Console.ReadLine().Trim();

        for (int i = 0; i < books.Length; i++)
        {
            if (string.IsNullOrEmpty(books[i]))
            {
                books[i] = newBook;
                Console.WriteLine($"Book '{newBook}' added successfully.");
                return;
            }
        }
        Console.WriteLine("Library is full. No more books can be added.");
    }

    static void RemoveBook(string[] books)
    {
        Console.Write("Enter the title of the book to remove: ");
        string bookToRemove = Console.ReadLine().Trim();

        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] != null && books[i].Equals(bookToRemove, StringComparison.OrdinalIgnoreCase))
            {
                books[i] = null;
                Console.WriteLine($"Book '{bookToRemove}' removed successfully.");
                return;
            }
        }
        Console.WriteLine("Book not found in the library.");
    }

    static void ListBooks(string[] books)
    {
        Console.WriteLine("\nBooks in the library:");
        bool hasBooks = false;
        for (int i = 0; i < books.Length; i++)
        {
            if (!string.IsNullOrEmpty(books[i]))
            {
                Console.WriteLine($"- {books[i]}");
                hasBooks = true;
            }
        }
        if (!hasBooks)
        {
            Console.WriteLine("No books in the library.");
        }
    }
}
