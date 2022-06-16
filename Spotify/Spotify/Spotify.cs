using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Spotify
    {
        private List<Song> songs;
        private List<Playlist> playlists;
        private Song currentPlaying;
        private Playlist currentPlayingList;

        public List<Song> Songs()
        {
            return new List<Song>(songs);
        }
        public List<Playlist> Playlists()
        {
            return new List<Playlist>(playlists);
        }
        public Spotify()
        {
            songs = new List<Song>();
            playlists = new List<Playlist>();
            currentPlaying=null;
            currentPlayingList=null;
        }
        public void Add(Song song)
        {
            if (!songs.Contains(song))
            {
                songs.Add(song);
            }
        }
            public void Add(Playlist playlist)
            {
            if (!playlists.Contains(playlist))
            {
                playlists.Add(playlist);
            }
            }
        public void Remove(Playlist playlist)
        {
            if (playlists.Contains(playlist))
            {
                playlists.Remove(playlist);
            }
        }
        public void Play(Song song)
        {
            if (currentPlayingList != null)
            {
                currentPlayingList.StopPlaying();
                currentPlayingList = null;
            }
            currentPlaying = song;
        }
        public void Play(Playlist playlist)
        {
            if (currentPlayingList == playlist)
            {
                currentPlaying = currentPlayingList.PlayFirstOrNextSong();
            }
            else
            {
                if (currentPlaying != null)
                {
                    currentPlayingList.StopPlaying();
                }
                currentPlayingList = playlist;
                currentPlaying = currentPlayingList.PlayFirstOrNextSong();
            }
        }
            public void StopPlaying()
            {
            Play((Song)null);
            }
        public Song IsPlaying()
        {
            return currentPlaying;
        }
        }
        }
    

