namespace Spotify
{
    public class program
    {


        public static void Main(string[] args)
        {
            Playlist playlist = new Playlist("Hipop");
            playlist.Name = "Huu";
            



            FiendsList fiendsList = new FiendsList("Tassnem");
            fiendsList.Add(" Tass");

            fiendsList.friends[1].showPlayList();
            
        }
    }
}