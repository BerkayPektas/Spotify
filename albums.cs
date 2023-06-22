using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class albums
    {
        private List<Songs> songs = new List<Songs>();
        private static List<Playlist> playlists = new List<Playlist>();



        public void Display()
        {
            int optie = 0;

            do
            {
                Console.WriteLine("Select an album:");
                Console.WriteLine("1. Dave - We're All Alone In This Together");
                Console.WriteLine("2. Central Cee - 23 ");
                Console.WriteLine("3. The Weeknd - Starboy");
                Console.WriteLine("4. Harry Styles - Harry's House");
                Console.WriteLine("5. Back to menu");
                Console.Write("Album: ");
                optie = int.Parse(Console.ReadLine());

                switch (optie)
                {
                    case 1:
                        DisplaySongsForAlbum(" Dave - We're All Alone In This Together", Songs.GetSongsForAlbum(1));
                        break;
                    case 2:
                        DisplaySongsForAlbum("Central Cee - 23", Songs.GetSongsForAlbum(2));
                        break;
                    case 3:
                        DisplaySongsForAlbum("The Weeknd - Starboy", Songs.GetSongsForAlbum(3));
                        break;
                    case 4:
                        DisplaySongsForAlbum("Harry Styles - Harry's House", Songs.GetSongsForAlbum(4));
                        break;
                    case 0:
                        Console.WriteLine("Going back to main menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid Option.");
                        break;
                }

                Console.WriteLine();
            } while (optie != 0);
        }

        private void DisplaySongsForAlbum(string albumName, List<Songs> songs)
        {
            int optie = 0;

            do
            {
                Console.WriteLine($"Showing songs for {albumName}...");
                Console.WriteLine();

                for (int i = 0; i < songs.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {songs[i].ToString()}");
                }

                Console.WriteLine("0. Back to album");
                Console.Write("Song: ");
                optie = int.Parse(Console.ReadLine());

                if (optie == 0)
                {
                    break;
                }

                Songs selectedSong = songs[optie - 1];

                Console.WriteLine($"Selected Song: {selectedSong.ToString()}");
                Console.WriteLine("--------------------------------------------");

                do
                {
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Play Song");
                    Console.WriteLine("2. Pause Song");
                    Console.WriteLine("3. Add Song to Playlist");
                    Console.WriteLine("4. Back to album");
                    Console.Write("Option: ");
                    optie = int.Parse(Console.ReadLine());

                    switch (optie)
                    {
                        case 1:
                            Console.WriteLine("Song is now being played");
                            break;
                        case 2:
                            Console.WriteLine("Song is now being paused");
                            break;
                        case 3:
                            Console.WriteLine("Add song to playlist:");
                            AddSongToPlaylist(selectedSong);
                            break;
                        case 4:
                            Console.WriteLine("Going back to album...");
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }

                    Console.WriteLine();
                } while (optie != 4);
            } while (true);
        }


        public void AddSongToPlaylist(Songs song)
        {
            Console.WriteLine("Which playlist do you want to add the song to?");

            if (playlists.Count == 0)
            {
                Console.WriteLine("Currently no playlists available.");
                return;
            }

            Console.WriteLine("Current playlists:");
            for (int i = 0; i < playlists.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {playlists[i].Name}");
            }

            Console.Write("Playlist name: ");
            string playlistName = Console.ReadLine();

            Playlist selectedPlaylist = null;

            foreach (Playlist p in playlists)
            {
                if (p.Name == playlistName)
                {
                    selectedPlaylist = p;
                    break;
                }
            }

            if (selectedPlaylist == null)
            {
                Console.WriteLine("Playlist not found.");
                return;
            }

            // maakt playlist als die niet al bestaat (empty)
            if (selectedPlaylist.Songs == null)
            {
                selectedPlaylist.Songs = new List<Songs>();
            }

            selectedPlaylist.Songs.Add(song);

            Console.WriteLine($"{song.Name} - {song.Artist} has been added to {selectedPlaylist.Name}!");
        }
    }

}
