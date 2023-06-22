namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int optie = 0;

            do
            {
                Console.WriteLine("Select option");
                Console.WriteLine("1, Albums");
                Console.WriteLine("2, Playlists");
                Console.WriteLine("3, Friend list");
                Console.WriteLine("4, Profiel");
                Console.WriteLine("5, Exit");
                Console.Write("Optie: ");
                optie = int.Parse(Console.ReadLine());

                switch (optie)
                {
                    case 1:
                        Console.WriteLine("Navigating to Albums...");
                        Album albums = new Album();
                        albums.Display();
                        break;
                    case 2:
                        Console.WriteLine("Navigating to Playlists...");
                        Playlistmenu playlistMenu = new Playlistmenu();
                        playlistMenu.DisplayPlaylistMenu();
                        break;
                    case 3:
                        Console.WriteLine("Navigating to Friendlist...");
                        Friends vrienden = new Friends();
                        vrienden.Display();
                        break;
                    case 4:
                        Console.WriteLine("Navigating to Profile...");
                        Profile profile = new Profile();
                        profile.Display();
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid Option.");
                        break;
                }

                Console.WriteLine();
            } while (optie != 5);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}