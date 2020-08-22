using System;
using System.Collections.Generic;
using System.Text;

namespace AnythingButCreed
{
    class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }

        public Song(string name, string artist)
        {
            Name = name;
            Artist = artist;
        }
    }
}
