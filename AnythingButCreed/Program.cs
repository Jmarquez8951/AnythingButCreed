using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main()
        {
            var goodSongs = new List<Song>();
            var allSongs = new List<Song>
            {
                new Song("American Idiot", "Green Day"),
                new Song("Wake Me Up When September Ends", "Green Day"),
                new Song("Blinding Lights", "The Weekend"),
                new Song("Torn", "Creed"),
                new Song("Time", "Creed"),
                new Song("When I Grow Up", "NF"),
                new Song("Island In The Sun", "Weezer"),
                new Song("I'm Just a Kid", "Simple Plan"),
                new Song("Riot", "Three Days Grace"),
                new Song("One Last Breath", "Creed"),
                new Song("Hide", "Creed"),
                new Song("Bullets", "Creed")
            };

            var chosen = allSongs.Where(s => s.Artist != "Creed");

            foreach (var song in chosen)
            {
                goodSongs.Add(song);
            }

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} : {song.Name}");
            }
        }
    }
}
