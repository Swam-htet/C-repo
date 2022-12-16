using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Movie
    {
        private string title;
        private int year;
        private int runtime;

        public string Title
        {
            get { return title; }   
            set { title = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Runtime
        {
            get { return runtime; }
            set { runtime = value; }
        }

        // constructor
        public Movie()
        {
            title = "Undefinied";
            year = 1900;
            runtime = 50;
        }
    }
}
