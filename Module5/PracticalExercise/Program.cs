using System;

class Program
{
    static void Main()
    {
        // Step 1: Create Variables for Books
        string[] books = new string[5];

        while (true)
        {
            // Step 5: Loop Indefinitely
            Console.WriteLine("Choose an action: add, remove, display, or exit");
            string action = Console.ReadLine().ToLower();

            if (action == "add")
            {
                // Step 2: Add a Book
                Console.WriteLine("Enter the title of the book to add:");
                string newBook = Console.ReadLine();

                bool added = false;
                for (int i = 0; i < books.Length; i++)
                {
                    if (string.IsNullOrEmpty(books[i]))
                    {
                        books[i] = newBook;
                        added = true;
                        Console.WriteLine("Book added successfully.");
                        break;
                    }
                }

                if (!added)
                {
                    Console.WriteLine("No more space to add new books.");
                }
            }
            else if (action == "remove")
            {
                // Step 3: Remove a Book
                Console.WriteLine("Enter the title of the book to remove:");
                string removeBook = Console.ReadLine();

                bool removed = false;
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i] == removeBook)
                    {
                        books[i] = null;
                        removed = true;
                        Console.WriteLine("Book removed successfully.");
                        break;
                    }
                }

                if (!removed)
                {
                    Console.WriteLine("Book not found.");
                }
            }
            else if (action == "display")
            {
                // Step 4: Display the List of Books
                Console.WriteLine("Books currently in the library:");
                foreach (string book in books)
                {
                    if (!string.IsNullOrEmpty(book))
                    {
                        Console.WriteLine(book);
                    }
                }
            }
            else if (action == "exit")
            {
                // Exit the program
                break;
            }
            else
            {
                // Step 6: Handle Invalid Inputs
                Console.WriteLine("Invalid action. Please choose add, remove, display, or exit.");
            }
        }
    }
}