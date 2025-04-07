using Microsoft.AspNetCore.Mvc;
using MusicWeb1.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MusicWeb1.Controllers
{
    public class PlaylistController : Controller
    {
        private static List<Playlist> playlists = new List<Playlist>
        {
            new Playlist
            {
                PlaylistId = 1,
                Name = "Rock Hits",
                Description = "Best rock songs collection",
                CoverImage = "https://via.placeholder.com/50"
            },
            new Playlist
            {
                PlaylistId = 2,
                Name = "EDM",
                Description = "Electronic dance music collection",
                CoverImage = "https://via.placeholder.com/50"
            },
            new Playlist
            {
                PlaylistId = 3,
                Name = "Acoustic",
                Description = "Relaxing acoustic songs",
                CoverImage = "https://via.placeholder.com/50"
            }
        };

        private static List<PlaylistSong> playlistSongs = new List<PlaylistSong>();

        // Danh sách bài hát mẫu để demo
        private static List<Song> songs = new List<Song>
        {
            new Song { SongId = 1, Title = "Shape of You", Artist = "Ed Sheeran", Album = "÷" },
            new Song { SongId = 2, Title = "Blinding Lights", Artist = "The Weeknd", Album = "After Hours" },
            new Song { SongId = 3, Title = "Dance Monkey", Artist = "Tones and I", Album = "The Kids Are Coming" },
            new Song { SongId = 4, Title = "Someone You Loved", Artist = "Lewis Capaldi", Album = "Divinely Uninspired" },
            new Song { SongId = 5, Title = "Stay With Me", Artist = "Sam Smith", Album = "In The Lonely Hour" }
        };

        public IActionResult Index()
        {
            return View(playlists);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Playlist playlist)
        {
            int newId = 1;
            if (playlists.Any())
            {
                newId = playlists.Max(p => p.PlaylistId) + 1;
            }
            
            playlist.PlaylistId = newId;
            playlists.Add(playlist);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var playlist = playlists.FirstOrDefault(p => p.PlaylistId == id);
            return View(playlist);
        }

        [HttpPost]
        public IActionResult Edit(Playlist playlist)
        {
            var existingPlaylist = playlists.FirstOrDefault(p => p.PlaylistId == playlist.PlaylistId);
            if (existingPlaylist != null)
            {
                existingPlaylist.Name = playlist.Name;
                existingPlaylist.Description = playlist.Description;
                existingPlaylist.CoverImage = playlist.CoverImage;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var playlist = playlists.FirstOrDefault(p => p.PlaylistId == id);
            return View(playlist);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var playlist = playlists.FirstOrDefault(p => p.PlaylistId == id);
            if (playlist != null)
            {
                playlists.Remove(playlist);
                playlistSongs.RemoveAll(ps => ps.PlaylistId == id);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var playlist = playlists.FirstOrDefault(p => p.PlaylistId == id);
            
            if (playlist != null)
            {
                ViewBag.Songs = playlistSongs.Where(ps => ps.PlaylistId == id).ToList();
                ViewBag.AllSongs = songs;
            }
            
            return View(playlist);
        }

        // Action hiển thị form thêm bài hát
        public IActionResult AddSong(int id)
        {
            var playlist = playlists.FirstOrDefault(p => p.PlaylistId == id);
            if (playlist == null)
            {
                return NotFound();
            }

            // Lấy danh sách các bài hát chưa có trong playlist
            var existingSongIds = playlistSongs
                .Where(ps => ps.PlaylistId == id)
                .Select(ps => ps.SongId)
                .ToList();

            var availableSongs = songs
                .Where(s => !existingSongIds.Contains(s.SongId))
                .ToList();

            ViewBag.PlaylistName = playlist.Name;
            ViewBag.PlaylistId = playlist.PlaylistId;
            ViewBag.AvailableSongs = availableSongs;

            return View();
        }

        // Action xử lý thêm bài hát
        [HttpPost]
        public IActionResult AddSong(int playlistId, int songId)
        {
            var playlist = playlists.FirstOrDefault(p => p.PlaylistId == playlistId);
            if (playlist != null)
            {
                // Kiểm tra xem bài hát đã tồn tại trong playlist chưa
                var existingSong = playlistSongs.FirstOrDefault(ps => 
                    ps.PlaylistId == playlistId && ps.SongId == songId);

                if (existingSong == null)
                {
                    var playlistSong = new PlaylistSong
                    {
                        PlaylistId = playlistId,
                        SongId = songId,
                        AddedAt = DateTime.Now
                    };
                    
                    playlistSongs.Add(playlistSong);
                }
            }
            
            return RedirectToAction("Details", new { id = playlistId });
        }

        // Action hiển thị form xác nhận xóa bài hát
        public IActionResult RemoveSong(int playlistId, int songId)
        {
            var playlist = playlists.FirstOrDefault(p => p.PlaylistId == playlistId);
            var song = songs.FirstOrDefault(s => s.SongId == songId);

            if (playlist == null || song == null)
            {
                return NotFound();
            }

            ViewBag.PlaylistName = playlist.Name;
            ViewBag.PlaylistId = playlistId;
            ViewBag.SongTitle = song.Title;
            ViewBag.SongId = songId;

            return View();
        }

        // Action xử lý xóa bài hát
        [HttpPost]
        [ActionName("RemoveSong")]
        public IActionResult RemoveSongConfirmed(int playlistId, int songId)
        {
            var playlistSong = playlistSongs.FirstOrDefault(ps => 
                ps.PlaylistId == playlistId && ps.SongId == songId);

            if (playlistSong != null)
            {
                playlistSongs.Remove(playlistSong);
            }
            
            return RedirectToAction("Details", new { id = playlistId });
        }
    }
}