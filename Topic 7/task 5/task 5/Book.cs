using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal class Book
    {
        // private properties
        private string title;
        private string author;
        private int year;
    
        // constructor
        public Book(string t,string a,int y)
        {
            title = t;
            author = a;
            year = y;
        }

        // accessor method
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Year
        {
            set { year = value; }
            get { return year; }
        }

        public string Author
        {
            set { author = value; }
            get { return author; }
        }
    }
}
