using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StreamMusic
{
    public class Music
    {
        public string Artist { get; set; }
        public Genre Genre { get; set; }
        public int Duration { get; set; }
        public int NumberOfStreams { get; set; }

        public Music(string artist, Genre genre, int duration)
        {
            Artist = artist;
            Genre = genre;
            Duration = duration;
        }
    }
}
