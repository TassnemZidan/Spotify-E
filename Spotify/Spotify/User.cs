using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Address { get; set; }
        public List<string> friends;
        private List<Playlist> playlists;


        public User(string name, string email, string address)
        {
            this.Name = name;
            this.Email = email;
            this.Address = address;
            friends = new List<string>();
            playlists = new List<Playlist>();
        }
    
        //show playlist
        public List<Playlist> showPlayList()
        {
            return new List<Playlist>(playlists);



        }
    }

}
