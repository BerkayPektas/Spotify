using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class speellijsten
    {
        class Playlist
        {
            public string Name { get; set; }
            private List<Song> songs;
            private int currentSongIndex;

            public Playlist(string name)
            {
                Name = name;
                songs = new List<Song>();
                currentSongIndex = 0;
            }

            public void AddSong(Song song)
            {
                songs.Add(song);
            }

            public void RemoveSong(Song song)
            {
                songs.Remove(song);
            }

            public void Play()
            {
                if (songs.Count == 0)
                {
                    Console.WriteLine("The playlist is empty.");
                    return;
                }

                Console.WriteLine("Playing playlist: " + Name);

                while (currentSongIndex < songs.Count)
                {
                    Song currentSong = songs[currentSongIndex];
                    Console.WriteLine("Now playing: " + currentSong.Title);

                    // Simulate playing the song...

                    currentSongIndex++;
                }

                Console.WriteLine("End of playlist.");
                currentSongIndex = 0; // Reset the current song index for future playbacks
            }
        }

    }
}
