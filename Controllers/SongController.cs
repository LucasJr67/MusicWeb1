using Microsoft.AspNetCore.Mvc;
using MusicWeb1.Models;
using System.Collections.Generic;
using System.Linq;

namespace MusicWeb1.Controllers
{
    public class SongController : Controller
    {
        private static List<Song> songs = new List<Song>();

        public IActionResult Index()
        {
            return View(songs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Song song)
        {
            songs.Add(song);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var song = songs.FirstOrDefault(s => s.SongId == id);
            return View(song);
        }

        [HttpPost]
        public IActionResult Edit(Song song)
        {
            var existingSong = songs.FirstOrDefault(s => s.SongId == song.SongId);
            if (existingSong != null)
            {
                existingSong.Title = song.Title;
                existingSong.Artist = song.Artist;
                existingSong.Album = song.Album;
                existingSong.Genre = song.Genre;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var song = songs.FirstOrDefault(s => s.SongId == id);
            return View(song);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var song = songs.FirstOrDefault(s => s.SongId == id);
            if (song != null)
            {
                songs.Remove(song);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var song = songs.FirstOrDefault(s => s.SongId == id);
            return View(song);
        }
    }
}