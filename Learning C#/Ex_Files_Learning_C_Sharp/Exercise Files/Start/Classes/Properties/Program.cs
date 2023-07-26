using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Book object
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            // Access a couple of properties
            Console.WriteLine(b1.GetAuthor("Jetro"));
            Console.WriteLine(b1.GetName("Incwadiiii"));
            Console.WriteLine(b1.GetTheCount(56));
            Console.WriteLine(b1.author);

            // Set the ISBN and Price properties
            b1.ISBN = "100140447938";
            b1.Price = 24.95m;
            Console.WriteLine(b1.ISBN);
            Console.WriteLine(b1.Price);

            // Change the Name and Pagecount
            b1.name = "Crime and Punishment";
            b1.pageCount = 652;
            Console.WriteLine(b1.author);
            Console.WriteLine(b1.name);
            Console.WriteLine(b1.pageCount);
        }
    }
}
