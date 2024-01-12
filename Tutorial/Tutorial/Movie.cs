using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string title, string director, string rating)
        {
            this.title = title;
            this.director = director;
            Rating = rating; // use setter
        }

        public string Rating
        {
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

    }
}
