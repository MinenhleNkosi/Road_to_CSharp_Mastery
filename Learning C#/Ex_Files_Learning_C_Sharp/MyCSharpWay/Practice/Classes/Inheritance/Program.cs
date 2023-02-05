using System;

namespace Inheritance
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Create some publications
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825, 39.95m);
            Magazine m1 = new Magazine("Time", "Time USA, LLC", 75, 4.95m);

            Console.WriteLine($"The name of the book is {b1.Name} by {b1.Author}, with {b1.PageCount} and costs {b1.Price}");
            Console.WriteLine($"The name of the book is {m1.Name} by {m1.Publisher}, with {m1.PageCount} and costs {m1.Price}");

            // Property validation logic will prevent an empty name
            b1.Name = "Jetro";

            // Call the override functions
            Console.WriteLine(b1.BookInformation());
            Console.WriteLine(b1.Price);
            Console.WriteLine(m1.BookInformation());
            Console.WriteLine(m1.Price);
        }
    }
}
