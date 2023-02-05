using System;

namespace RefAndOutParams {
    class Program {
        // TODO: Ordinary value arguments cannot be modified by the function
        // because they are a copy of the original value.
        static void TestFunc1(int arg1) {

            Console.WriteLine($"{arg1}");
        }

        // TODO: The "out" keyword means that the parameter returns a value and is not
        // used to supply data to the function.
        static void ByValue(int a, int b, out int division, out int minus)
        {
            Console.WriteLine(division = a / b);
            Console.WriteLine(minus = b - a);

        }

        // TODO: Arguments that are passed by reference can be modified
        // by the function and reflected back to the caller.
        static void ByReference(string name, string surname, ref string nameSurname, ref string surnameName)
        {
            Console.WriteLine(nameSurname = name + " " + surname);
            Console.WriteLine(surnameName = surname + " " + name);
        }


        static void Main(string[] args) {
            int val1 = 10;
            int val2 = 20;
            string first = "Jetro";
            string second = "Cuba";

            Program values = new Program();

            // Functions don't normally modify value arguments
            TestFunc1(val1);
            Console.WriteLine($"{val1}");

            // TODO: Using the "ref" keyword, arguments can be passed by reference
            // which allows the function to modify them
            string nameSurname = "";
            string surnameName = "";
            ByReference(first, second, ref nameSurname, ref surnameName);


            // TODO: The "out" keyword can be used to indicate that an argument
            // is intended to return a value and is not an input.
            int division;
            int minus;
            ByValue(val1, val2, out division, out minus);

        }
    }
}
