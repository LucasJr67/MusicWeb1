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
                    new Playlist { PlaylistId = 1, Name = "Nhạc yêu thích", Description = "15 bài hát", CoverImage = "https://via.placeholder.com/50" },
                    new Playlist { PlaylistId = 2, Name = "Nhạc trữ tình", Description = "8 bài hát", CoverImage = "https://via.placeholder.com/50" },
                    new Playlist { PlaylistId = 3, Name = "Nhạc EDM", Description = "12 bài hát", CoverImage = "https://via.placeholder.com/50" },
                    new Playlist { PlaylistId = 4, Name = "Nhạc Acoustic", Description = "10 bài hát", CoverImage = "https://via.placeholder.com/50" }
                }
            };

            return View(userProfile);
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Profile profile, IFormFile avatar)
        {
            if (avatar != null && avatar.Length > 0)
            {
                // Lưu file và cập nhật đường dẫn
                var filePath = Path.Combine("wwwroot/uploads", avatar.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    avatar.CopyTo(stream);
                }
                profile.AvatarUrl = "/uploads/" + avatar.FileName;
            }
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
} 