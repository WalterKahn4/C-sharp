using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Book
    {
        // Constructor

        public Book() 
        {
            Console.WriteLine("Creating Book");
        }

        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public string title;
        public string author;
        public int pages;


    }
}
