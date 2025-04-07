using Microsoft.AspNetCore.Mvc;
using MusicWeb1.Models;

namespace MusicWeb1.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;

        public ProfileController(ILogger<ProfileController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Trong tương lai, chúng ta sẽ lấy thông tin người dùng từ database
            var userProfile = new UserProfile
            {
                Username = "Người dùng mẫu",
                Email = "example@email.com",
                PhoneNumber = "(012) 345-6789",
                Address = "Hà Nội, Việt Nam",
                FavoriteSongsCount = 25,
                PlaylistsCount = 8,
                FollowingCount = 12,
                RecentActivities = new List<Activity>
                {
                    new Activity { Title = "Bài hát yêu thích mới", Description = "Bạn đã thêm \"Shape of You\" vào danh sách yêu thích", TimeAgo = "3 ngày trước" },
                    new Activity { Title = "Playlist mới", Description = "Bạn đã tạo playlist \"Nhạc yêu thích\"", TimeAgo = "1 tuần trước" }
                },
                Playlists = new List<Playlist>
                {
                    new Playlist { Name = "Nhạc yêu thích", SongCount = 15, CoverImage = "https://via.placeholder.com/50" },
                    new Playlist { Name = "Nhạc trữ tình", SongCount = 8, CoverImage = "https://via.placeholder.com/50" },
                    new Playlist { Name = "Nhạc EDM", SongCount = 12, CoverImage = "https://via.placeholder.com/50" },
                    new Playlist { Name = "Nhạc Acoustic", SongCount = 10, CoverImage = "https://via.placeholder.com/50" }
                }
            };

            return View(userProfile);
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Profile profile)
        {
            if (ModelState.IsValid)
            {
                // TODO: Cập nhật thông tin profile vào database
                return RedirectToAction(nameof(Index));
            }
            return View(profile);
        }
    }

    // Các model tạm thời để hiển thị dữ liệu
    public class UserProfile
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int FavoriteSongsCount { get; set; }
        public int PlaylistsCount { get; set; }
        public int FollowingCount { get; set; }
        public List<Activity> RecentActivities { get; set; }
        public List<Playlist> Playlists { get; set; }
    }

    public class Activity
    {
        public static string? Current { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TimeAgo { get; set; }
    }

    public class Playlist
    {
        public string Name { get; set; }
        public int SongCount { get; set; }
        public string CoverImage { get; set; }
    }
} 