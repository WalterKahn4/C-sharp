using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;

        // static attribute

        public static int songCount = 0;

        public Song(string title, string artist, int duration)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }

    


    }
}
