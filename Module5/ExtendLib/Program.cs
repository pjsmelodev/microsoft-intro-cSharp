using System;
using System.Collections.Generic;

class LibraryManager
{
    static void Main()
    {
        List<string> books = new List<string>();
        Dictionary<string, int> borrowedBooks = new Dictionary<string, int>();
        const int maxBooks = 5;
        const int maxBorrowedBooks = 3;

        while (true)
        {
            Console.WriteLine("Would you like to add, remove, borrow, return, checkin, or exit? (add/remove/borrow/return/checkin/exit)");
            string action = Console.ReadLine().ToLower();

            if (action == "add")
            {
                if (books.Count >= maxBooks)
                {
                    Console.WriteLine("The library is full. No more books can be added.");
                }
                else
                {
                    Console.WriteLine("Enter the title of the book to add:");
                    string newBook = Console.ReadLine();
                    books.Add(newBook);
                }
            }
            else if (action == "remove")
            {
                if (books.Count == 0)
                {
                    Console.WriteLine("The library is empty. No books to remove.");
                }
                else
                {
                    Console.WriteLine("Enter the title of the book to remove:");
                    string removeBook = Console.ReadLine();
                    if (books.Remove(removeBook))
                    {
                        Console.WriteLine("Book removed.");
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                }
            }
            else if (action == "borrow")
            {
                Console.WriteLine("Enter your name:");
                string userName = Console.ReadLine();
                if (borrowedBooks.ContainsKey(userName) && borrowedBooks[userName] >= maxBorrowedBooks)
                {
                    Console.WriteLine("You have reached the maximum number of borrowed books.");
                }
                else
                {
                    Console.WriteLine("Enter the title of the book to borrow:");
                    string borrowBook = Console.ReadLine();
                    if (books.Contains(borrowBook))
                    {
                        books.Remove(borrowBook);
                        if (borrowedBooks.ContainsKey(userName))
                        {
                            borrowedBooks[userName]++;
                        }
                        else
                        {
                            borrowedBooks[userName] = 1;
                        }
                        Console.WriteLine("Book borrowed.");
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                }
            }
            else if (action == "return")
            {
                Console.WriteLine("Enter your name:");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter the title of the book to return:");
                string returnBook = Console.ReadLine();
                if (borrowedBooks.ContainsKey(userName) && borrowedBooks[userName] > 0)
                {
                    books.Add(returnBook);
                    borrowedBooks[userName]--;
                    Console.WriteLine("Book returned.");
                }
                else
                {
                    Console.WriteLine("You have not borrowed this book.");
                }
            }
            else if (action == "checkin")
            {
                Console.WriteLine("Enter the title of the book to check in:");
                string checkinBook = Console.ReadLine();
                if (!books.Contains(checkinBook))
                {
                    books.Add(checkinBook);
                    Console.WriteLine("Book checked in.");
                }
                else
                {
                    Console.WriteLine("The book is already in the library.");
                }
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', 'borrow', 'return', 'checkin', or 'exit'.");
            }

            // Display the list of books
            Console.WriteLine("Available books:");
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            // Display borrowed books
            Console.WriteLine("Borrowed books:");
            foreach (var entry in borrowedBooks)
            {
                Console.WriteLine($"{entry.Key} has borrowed {entry.Value} books.");
            }

            // Search for a book
            Console.WriteLine("Would you like to search for a book? (yes/no)");
            string searchAction = Console.ReadLine().ToLower();
            if (searchAction == "yes")
            {
                Console.WriteLine("Enter the title of the book to search for:");
                string searchBook = Console.ReadLine();
                if (books.Contains(searchBook))
                {
                    Console.WriteLine("The book is available in the library.");
                }
                else
                {
                    Console.WriteLine("The book is not available in the library.");
                }
            }
        }
    }
}
