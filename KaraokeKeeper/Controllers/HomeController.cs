using KaraokeKeeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KaraokeKeeper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SongList()
        {
            ViewBag.Message = "The Song List.";

            Song first = new Song("first,", "who", 32,1234);
            Song second = new Song("second,", "who", 45,1234);
            Song third = new Song("third,", "who", 56,1234);
            Song forth = new Song("forth,", "who", 43,1234);

            List<Song> songs = new List<Song>(){ first, second, third, forth };

            ViewData["SongList"] = songs;

            return View(songs);
        }

       // [HttpPost]
       // public ActionResult SongList(List<Song> songs)
       // {
       //     return Content($)
       // }
    }
}