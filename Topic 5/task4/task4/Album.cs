using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Album
    {
        // private properties
        private string title;
        private string artist;
        private string genre;

        // accessor methods
        public string Title { get { return title; } set { title = value; } }
        public string Artist { get { return artist; } set { artist = value; } }
        public string Genre { get { return genre; } set { genre = value; } }

        // constructor
        public Album()
        {
            title = "Undefinied";
            artist = "Unedfinied";
            genre = "Undefinied";
        }
    }
}
