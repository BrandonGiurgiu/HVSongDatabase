using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Testing.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Testing.Controllers
{
    public class SongsController : Controller
    {
        private readonly ISongsRepository repo;

        public SongsController(ISongsRepository repo)
        {
            this.repo = repo;
        }

        // Get: /<controller>/
        public IActionResult Index()
        {
            var songs = repo.GetAllSongs();
            return View(songs);
        }

        public IActionResult ViewSong (int id)
        {
            var song = repo.GetSongs(id);

            return View(song);
        }

        public IActionResult UpdateSong(int id)
        {
            Songs song = repo.GetSongs(id);
            if (song == null)
            {
                return View("SongNotFound");
            }
            return View(song);
        }

        public IActionResult UpdateSongToDatabase(Songs song)
        {
            repo.UpdateSong(song);

            return RedirectToAction("ViewSong", new { id = song.PerformanceID });
        }
        public IActionResult InsertSong()
        {
            return View();
        }
        public IActionResult InsertSongToDatabase(Songs songToInsert)
        {
            repo.InsertSong(songToInsert);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            repo.DeleteSongs(id);
            return Json("");
        }

    }
}

