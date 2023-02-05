using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some strings for the exercises
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string[] strs = {"one", "two", "three", "four"};

            // TODO: Length of a string 
            Console.WriteLine($"String Length of str1 = {str1.Length}");
            Console.WriteLine($"String Length of str1 = {str2.Length}");
            Console.WriteLine($"String Length of str1 = {str3.Length}");
            Console.WriteLine($"String Length of str1 = {strs.Length}");

            // TODO: Access individual characters
            

            // TODO: iterate over a string like any other sequence of values
            for (var i = 0; i < str1.Length; i++)
            {
                Console.WriteLine($"str1 character{i} = {str1[i]}");
            }

            foreach (var i in strs)
            {
                Console.WriteLine(i);
            }

            // TODO: String Concatenation         
            string results = String.Concat(str3);
            Console.WriteLine(results);

            // TODO: Joining strings together with Join
            outstr = String.Join(",", str1);
            Console.WriteLine(outstr);

            // TODO: String Comparison
            // Compare will perform an ordinal comparison and return:
            // < 0 : first string comes before second in sort order
            // 0 : first and second strings are same position in sort order
            // > 0 : first string comes after the second in sort order
            Console.WriteLine(str1.CompareTo(str2));

            // TODO: Equals just returns a regular Boolean
            Console.WriteLine(str1.Equals(str3));

            // TODO: String Searching

        }
    }
}
