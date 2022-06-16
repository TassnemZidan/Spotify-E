using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Song
    {
      public string Name { get; set; }
      public int Year { get; set; }
      public string Artist { get; set; }
      
        public Song(string name, int year, string artist)
        {
            Name = name;
            Year = year;
            Artist = artist;
        }
        public override string ToString()
        {
            return Name +" / "+Artist+ " / "+Year;
        }

    }
}
