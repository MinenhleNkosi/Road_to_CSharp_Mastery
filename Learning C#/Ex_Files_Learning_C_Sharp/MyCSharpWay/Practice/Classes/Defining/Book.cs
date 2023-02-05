using System;

namespace Defining
{
    // classes have a name, unique within the namespace
    public class Book
    {
        // TODO: classes have member variables, or "fields" to hold data
        string author;
        string title;
        int pages;

        // TODO: classes have one or more constructors
        public Book(string _author, string _title, int _pages)
        {
            author = _author;
            title = _title;
            pages = _pages;
        }

        // TODO: methods are used to operate on the class and data
        public string GetSummary()
        {
            return $"Author: {author}, Title: {title} and Pages per book: {pages}";
        }

    }
}
