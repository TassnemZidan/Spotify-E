using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Playlist
    {
        private List<Song> songs;
        private Song currentlyPlaying;

        public string Name { get; set; }

        public Playlist(string name)
        {
            this.Name = name;
            songs = new List<Song>();
            currentlyPlaying = null;
        }
        public void Add(Song song)
        {
            if (!songs.Contains(song))
            {
                songs.Add(song);
            }
        }
        public void Add(List<Song> songs)
        {
            foreach (Song song in songs)
            {
                this.songs.Add(song);

            }
        }

        public void Remove(Song song)
        {
            if (songs.Contains(song))
            {
                songs.Remove(song);
            }
        }
       
        public Song PlayFirstOrNextSong()
        {
            if (currentlyPlaying == null || !songs.Contains(currentlyPlaying))
            {
                if (songs.Count() > 0)
                {
                    currentlyPlaying = songs.ElementAt(0);
                }
                else
                {
                    currentlyPlaying = null;
                }
            }
            else
            {
                if (songs.Contains(currentlyPlaying))
                {
                    currentlyPlaying = songs.ElementAt(songs.IndexOf(currentlyPlaying) + 1);
                }
            }
            return currentlyPlaying;
        }
        public void StopPlaying()
        {
            currentlyPlaying = null;
        }
        public List<Song> Songs()
        {
            return new List<Song>(songs);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    
}
