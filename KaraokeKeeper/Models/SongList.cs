using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaraokeKeeper.Models
{
    public class SongList
    {
        List<String> songs = new List<String>();

        public SongList()
        {

        }

        public static List<Song> sortByGrade(List<Song> unsortedSongs)
        {
            List<Song> sortedSongs = unsortedSongs.OrderByDescending(o=>o._grade).ToList();

            return sortedSongs;
        }
    }
}