using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class client
    {
        class Client
        {
            private Song currentSong;
            private bool isPlaying;

            public void PlaySong(Song song)
            {
                if (isPlaying)
                {
                    Console.WriteLine("A song is already playing. Stop the current song before playing a new one.");
                    return;
                }

                currentSong = song;
                isPlaying = true;
                Console.WriteLine("Now playing: " + song.Title);
            }

            public void PauseSong()
            {
                if (!isPlaying)
                {
                    Console.WriteLine("No song is currently playing.");
                    return;
                }

                Console.WriteLine("Song paused: " + currentSong.Title);
                isPlaying = false;
            }

            public void ResumeSong()
            {
                if (isPlaying)
                {
                    Console.WriteLine("A song is already playing.");
                    return;
                }

                if (currentSong == null)
                {
                    Console.WriteLine("No song is currently selected.");
                    return;
                }

                Console.WriteLine("Resuming song: " + currentSong.Title);
                isPlaying = true;
            }

            public void AddSongToPlaylist(Song song, Playlist playlist)
            {
                playlist.AddSong(song);
                Console.WriteLine("Added song '" + song.Title + "' to playlist: " + playlist.Name);
            }

            public void RemoveSongFromPlaylist(Song song, Playlist playlist)
            {
                playlist.RemoveSong(song);
                Console.WriteLine("Removed song '" + song.Title + "' from playlist: " + playlist.Name);
            }
        }
    }
}
