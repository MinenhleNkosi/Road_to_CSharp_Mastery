using System;

namespace Inheritance
{
    // TODO: Declare "Book" as a subclass of Publication.
    class Book : Publication
    {
        private string _author;
        private int _pagecount;
        private decimal _price;

        // use the base() keyword to initialize the base class.
        public Book(string name, string author, int pagecount, decimal price) : base(name, pagecount, price){
            _author = author;
        }

        public string Author { get; set; }

        // TODO: use the override keyword to override a base class method.
        public override string GetDescription()
        {
            return $"{Name} written by {Author}, has {PageCount} pages";
        }

    }
}