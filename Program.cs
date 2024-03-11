namespace StreamMusic
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Music> list = new List<Music>
            {
                new Music("The Police", Genre.Rock, 240),
                new Music("Queen", Genre.Rock, 190),
                new Music("Dire straits", Genre.Rock, 287),
                new Music("Bon Jovi", Genre.Rock, 305),
                new Music("Tiakola", Genre.Rap, 245),
                new Music("Notorious BIG", Genre.Rap, 278),
                new Music("Joey Bada$$", Genre.Rap, 213),
                new Music("Kekra", Genre.Rap, 276),
                new Music("Alexandra Streliski", Genre.Piano, 180),
                new Music("Hideyuki Hashimoto", Genre.Piano, 168),
                new Music("kjell Inge", Genre.Piano, 756),
                new Music("Jim Perkins", Genre.Piano, 478)
            };
            Database database = new Database();
            database.MusicList = list;

            for(int i = 0; i < 500; i++)
            {
                Thread.Sleep(5);
                Random random = new Random();
                int randomIndex = random.Next(0, list.Count);
                database.MusicList[randomIndex].NumberOfStreams++;
            }

            //Affichage du nombre de stream
            foreach(Music music in list) 
            {
                Console.WriteLine(music.Artist);
                Console.WriteLine(music.NumberOfStreams);
                Console.WriteLine();
            }

            //Recherche par genre => NbrDeStreams
            foreach (Music music in database.Search(Genre.Rap))
            {
                Console.WriteLine(music.Artist);
            }

            Console.WriteLine();

            //Recherche par Nom => NbrDeStreams
            foreach (Music music in database.Search("a"))
            {
                Console.WriteLine(music.Artist);
            }

            Console.ReadLine();
        }
    }
}
