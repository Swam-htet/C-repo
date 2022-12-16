using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Book
    {
        // private properties of Book class
        private string title;
        private string authorName;
        private string isbn;
        private string genre;

        // accesser methods of each private properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        
    }
}
