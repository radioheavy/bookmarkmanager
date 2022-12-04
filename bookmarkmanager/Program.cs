using System;
using System.Collections.Generic;

namespace BookmarkManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty dictionary to store bookmarks
            Dictionary<string, string> bookmarks = new Dictionary<string, string>();

            while (true)
            {
                // Print menu options
                Console.WriteLine("Bookmark Manager\n");
                Console.WriteLine("1. Add bookmark");
                Console.WriteLine("2. View bookmark");
                Console.WriteLine("3. Delete bookmark");
                Console.WriteLine("4. Quit\n");

                Console.Write("Enter your choice: ");

                // Get the user's menu choice
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    // Add bookmark
                    Console.Write("Enter bookmark name: ");
                    string bookmarkName = Console.ReadLine();
                    Console.Write("Enter bookmark URL: ");
                    string bookmarkURL = Console.ReadLine();

                    bookmarks.Add(bookmarkName, bookmarkURL);
                }
                else if (choice == 2)
                {
                    // View bookmark
                    Console.Write("Enter bookmark name: ");
                    string bookmarkName = Console.ReadLine();

                    if (bookmarks.ContainsKey(bookmarkName))
                    {
                        Console.WriteLine(bookmarks[bookmarkName]);
                    }
                    else
                    {
                        Console.WriteLine("Bookmark not found");
                    }
                }
                else if (choice == 3)
                {
                    // Delete bookmark
                    Console.Write("Enter bookmark name: ");
                    string bookmarkName = Console.ReadLine();

                    if (bookmarks.ContainsKey(bookmarkName))
                    {
                        bookmarks.Remove(bookmarkName);
                        Console.WriteLine("Bookmark deleted");
                    }
                    else
                    {
                        Console.WriteLine("Bookmark not found");
                    }
                }
                else if (choice == 4)
                {
                    // Quit
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }
}