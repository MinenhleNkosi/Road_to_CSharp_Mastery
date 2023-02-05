using System;

namespace MultiValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Tuples are grouped values added in C# 7
            var tupl2 = ("jetro", "cuba", 32, 2023);

            // TODO: Tuple values are mutable
            tupl2.Item3 = 25;
            tupl2.Item1 = "Yetro";

            // TODO: Functions can work with tuples
            int Fnctn(int one, int two)
            {
                return (one * two);
            }
            int tupl1 = Fnctn(2, 4);
            Console.WriteLine(tupl1);
        }

        // TODO: Functions can return multiple values using tuples
        static (int, int, int, int) Functn(int one, int two, int three, int four)
        {
            return (one + two, one * two, three / four, four - three);
        }

    }
}
