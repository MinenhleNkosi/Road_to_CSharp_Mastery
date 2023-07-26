using System;

namespace Defining
{
    // classes have a name, unique within the namespace
    public class Book
    {
        // TODO: classes have member variables, or "fields" to hold data
        int _count = 0;
        string _genre = "";
        string _bookName = "";
        string _author = "";


        // TODO: classes have one or more constructors
        public Book(int count, string genre, string bookName, string author)
        {
            _count = count;
            _genre = genre;
            _bookName = bookName;
            _author = author;
        }

        public Book()
        {
            
        }


        // TODO: methods are used to operate on the class and data
        public void SayHi()
        {
            Console.WriteLine("Yebo Sanbona");
        }


    }
}
