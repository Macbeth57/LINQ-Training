using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamMusic
{
    public class Database
    {
        public  List<Music> MusicList {  get; set; }

        public Database()
        {
            MusicList = new List<Music>();
        }
        
        public List<Music> Search(Genre genre)
        {
            List<Music> listToReturn = new List<Music>();
            listToReturn = MusicList
                .Where(musicToPutIn => musicToPutIn.Genre == genre)
                .OrderBy(musicToPutIn => musicToPutIn.NumberOfStreams)
                .ToList();

            return listToReturn;
        }

        public List<Music> Search(string wordToFind)
        {
            List<Music> listToReturn = new List<Music>();
            listToReturn = MusicList
                .Where(musicToPutIn => musicToPutIn.Artist.Contains(wordToFind))
                .OrderBy(musicToPutIn => musicToPutIn.NumberOfStreams)
                .ToList();

            return listToReturn;
        }
    }
}
