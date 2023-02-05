using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quarters = {1,2,3,4};
            int[] sales = {100000, 150000, 200000, 225000};
            double[] intlMixPct = {.386, .413, .421, .457};
            string str1 = "TestStr";
            int val1 = 1234;
            decimal val2 = 1234.5678m;

            // Basic Formatting information
            Console.WriteLine("str1 = {0}", str1);

            // TODO: Specifying Numerical formatting
            // General format is {index[,alignment]:[format]}
            // Common types are N (Number), G (General), F (Fixed-point), 
            // E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
            // C (Currency in local format)
            Console.WriteLine("{0:G\n}\n {0:N}\n {0:F}\n {0:E}\n ", val1, val2);

            // TODO: Add a number after the format to specify precision
            Console.WriteLine("{0:G2\n}\n {0:N4}\n {0:F3}\n {0:E4}\n ", val1, val2);

            // TODO: Formatting with alignment and spacing

        }
    }
}
