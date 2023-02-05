using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create new object instances using the "new" operator
            Book xyz = new Book("Jetro Cuba", "My Life", 350);
            Book two = new Book("One Two", "Numbers", 500);

            // TODO: Call a method on the object
            Console.WriteLine(xyz.GetSummary());
            Console.WriteLine(two.GetSummary());

            // TODO: try to set one of the properties -- 
            // this will result in an error

        }
    }
}
