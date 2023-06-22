using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Playlist
    {
        public string Name { get; set; }
        public List<Songs> Songs { get; set; }
        public void AddSong(Songs song)
        {
            Songs.Add(song);
        }
        public Playlist(string name)
        {
            Name = name;

            // Voegt songs to aan playlist (hcode)
            Songs = new List<Songs>()
            {
                new Songs("Both Sides Of A Smile", "Dave", "We're All Alone In This Together"),
                new Songs("Ungrateful", "Central Cee", "23"),
                new Songs("Reminder", "The Weeknd", "Starboy"),
                new Songs("Falling", "Harry Styles", "Harry's House"),
            };
        }
    }
}
