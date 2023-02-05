using System;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int jumpCount = 10;
            string[] animals = {"goats", "cats", "pigs"};

            // TODO: create a StringBuilder
            StringBuilder sb = new StringBuilder();
            
            // TODO: print some basic stats about the StringBuilder
            Console.WriteLine($"Capacity: {sb.MaxCapacity}\n HashCode: {sb.GetHashCode}\n Type: {sb.GetType}\n Length: {sb.Length}"); 

            // TODO: Add some strings to the builder using Append
            var addingStrings = sb.Append("Jetro Cuba Minister MasterMind Bhasted");
            Console.WriteLine(addingStrings);

            // TODO: AppendLine can append a line ending
            Console.WriteLine(sb.AppendLine("\nNgenelela Bhasted"));

            // TODO: AppendFormat can be used to append formatted strings
            Console.WriteLine(sb.AppendFormat($"\nNgenelela MasterMind: {jumpCount}\n"));

            // TODO: AppendJoin can iterate over a set of values
            Console.WriteLine(sb.AppendJoin(",", animals));

            // TODO: Modify the content using Replace
            Console.WriteLine(sb.Replace("c", "h"));

            // TODO: Insert content at any index
            Console.WriteLine(sb.Insert(2, "Welele"));
            
            // TODO: Convert to a single string
            sb.ToString();
        }
    }
}
