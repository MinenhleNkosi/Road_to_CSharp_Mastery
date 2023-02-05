using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some basic value type variables
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            // Declare a string - it's a collection of characters
            string str = "a string";

            // Declare an implicit variable
            var x = 10;
            var z = "Hello!";

            // TODO: Declare an array of values
            int[] values = {1, 2, 3, 4, 5};
            string[] valuesStr = {"one", "two", "three", "four", "five"};
            char[] valuesChar = {'a', 'b', 'c', 'd', 'e'};

            // TODO: Print the values using a Formatting String
            
            for (int ii = 0;  ii < values.Length; ii++)
            {
                Console.WriteLine(String.Format($"Integers: {values[ii].ToString()}\n Strings: {valuesStr[ii].ToString()}\n Characters: {valuesChar[ii].ToString()}\n"));
                
            }

            //Try the above using LINQ
            var testLINQ = values.Select(_ => _);
            foreach (var j in testLINQ)
            {
                Console.WriteLine($"Linq results for Integers: {j}");
            }

            // TODO: "null" means "no value"
            object obj = null;
            Console.WriteLine(obj);

            // TODO: Implicit conversion between types
            double explct = x;
            Console.WriteLine(explct); 

            // TODO: Explicit conversions
            double explict = (int)x;
            Console.WriteLine(explict); 
        }
    }
}
