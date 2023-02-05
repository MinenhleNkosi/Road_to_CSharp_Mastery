using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables
            string make = "Mercedes-Benz";
            string model = "G Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            // TODO: Output information using formatting
            Console.WriteLine("Brand is: {0}\n Model is: {1}\n Year is: {2}\n Miles is: {3}\n Price is: {4}", make, model, year, miles, price);

            // TODO: Using string interpolation
            Console.WriteLine($"Brand is: {make}\n Model is: {model}\n Year is: {year}\n Miles is: {miles}\n Price is: {price}");

            // TODO: With inline expressions

        }
    }
}
