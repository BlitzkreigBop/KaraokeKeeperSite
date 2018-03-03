using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaraokeKeeper.Models
{
    public class Song
    {
        public String _name;
        public String _artist;
        public Int32 _grade;
        public Int32 _id; 

        public Song(String name, String artist, Int32 grade, Int32 id)
        {
            _name = name;
            _artist = artist;
            _grade = grade;
            _id = id;
        }
    }
}