using System;
using System.Collections.Generic;

namespace MusicWeb1.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? GoogleId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsLogin { get; set; }

    public bool? IsEmailVerified { get; set; }

    public string? RefreshToken { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual ICollection<ListenHistory> ListenHistories { get; set; } = new List<ListenHistory>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<PasswordReset> PasswordResets { get; set; } = new List<PasswordReset>();

    public virtual ICollection<PlaylistSong> PlaylistSongs { get; set; } = new List<PlaylistSong>();

    public virtual ICollection<RatingAlbum> RatingAlbums { get; set; } = new List<RatingAlbum>();

    public virtual ICollection<RatingPlaylist> RatingPlaylists { get; set; } = new List<RatingPlaylist>();

    public virtual ICollection<RatingSong> RatingSongs { get; set; } = new List<RatingSong>();

    public virtual ICollection<ReportTargetType> ReportTargetTypeModerators { get; set; } = new List<ReportTargetType>();

    public virtual ICollection<ReportTargetType> ReportTargetTypeUsers { get; set; } = new List<ReportTargetType>();

    public virtual ICollection<Subscription> Subscriptions { get; set; } = new List<Subscription>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
