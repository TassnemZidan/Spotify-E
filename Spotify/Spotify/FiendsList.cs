using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class FiendsList {

        public List<User> friends;
        public string Name { get; set; }
    
    public FiendsList(string name)
    {
            this.Name = name;
    }
        public void Add(User user)
        {

            if (!friends.Contains(user))
            {
                friends.Add(user);
            }
        }
     public void Remove(User user)
            {
            if (friends.Contains(user)){
                friends.Remove(user);
            }
            }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
