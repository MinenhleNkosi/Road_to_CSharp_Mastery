using System;

namespace Basics
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            // Functions are used to group re-usable code together in a single
            // unit that can be customized with parameters.

            // TODO: Functions have a return type, name, and optional parameters
            string Jetro()
            {
                return "Sawbona";
            }

            // TODO: A function with no return value has a 'void' type
            int Mini(int number)
            {
                return 96 + number;
            }

            // TODO: Call first function
            Console.WriteLine(Jetro());

            // TODO: Call second function
            Console.WriteLine(Mini(1));
        }
    }
}



