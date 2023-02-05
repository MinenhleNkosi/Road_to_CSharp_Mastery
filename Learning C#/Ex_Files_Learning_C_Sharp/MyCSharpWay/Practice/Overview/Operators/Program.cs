using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables to excercise the operators
            int x=10, y=5;
            int add = x + y;
            int sub = x - y;
            int mult = x * y;
            int div = x / y;

            string a="abcd", b="efgh";

            // TODO: Basic math operators are +, -, /, *
            Console.WriteLine($"----- Basic Math -----\n\n Addition: {add}\n Subtraction: {sub}\n Multiplication: {mult}\n Division: {div}\n");


            // TODO: Increment / decrement operators
            x++;
            y--;
            Console.WriteLine($"----- Shorthand -----\n\n Increment: {x}\n Decrement: {y--}\n");


            // TODO: Operators can be shorthand: a = a + b
            a += b;
            Console.WriteLine($"----- Operators Shorthand -----\n Shorthand of (a = a + b;) is (a += b;) : {a}\n");

            // TODO: Logical operators &&, ||
            Console.WriteLine($"----- Logic Operators -----\n AND operator: {x > y && y < x}\n OR operator: {x < y || y > x}");


            // null-coalescing operators
            string str = null;
            // TODO: the ?? operator uses left operand if not null, or right one if it is
            var results = str ?? "str has no value";
            Console.WriteLine(results);

            
            // TODO: the ??= operator assigns the right operand if the left one is null
            // it replaces the code:
            // if (variable is null) {
            //    variable = somevalue;
            // }
            var results2 = str ??= "umagoda";
            Console.WriteLine(results2);

        }
    }
}
