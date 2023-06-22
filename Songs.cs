using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Songs
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Duration { get; set; }

        public Songs(string name, string artist, string album)
        {
            Name = name;
            Artist = artist;
            Album = album;
        }

        public override string ToString()
        {
            return $"{Name} - {Artist} ";
        }

        public static List<Songs> GetSongsForAlbum(int albumIndex)
        {
            switch (albumIndex)
            {
                case 1:
                    return new List<Songs>()
                    {
                        new Songs("Both Sides Of A Smile", "Dave", "We're All Alone In This Together"),
                        new Songs("In The Fire", "Dave", "We're All Alone In This Together")
                    };
                case 2:
                    return new List<Songs>()
                    {
                        new Songs("Ungrateful", "Central Cee", "23"),
                        new Songs("Lil Bro", "Central Cee", "23")
                    };
                case 3:
                    return new List<Songs>()
                    {
                        new Songs("Reminder", "The Weeknd", "Starboy"),
                        new Songs("Die For You", "The Weeknd", "Starboy")
                    };
                case 4:
                    return new List<Songs>()
                    {
                        new Songs("Falling", "Harry Styles", "Harry's House"),
                        new Songs("Cinema", "Harry Styles", "Harry's House")
                    };
                default:
                    return new List<Songs>();
            }
        }
    }
}

