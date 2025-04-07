
namespace MusicWeb1.Models;

public partial class PlaylistSong
{
    public int PlaylistId { get; set; }

    public int SongId { get; set; }

    public int? OrderIndex { get; set; }

    public int? AddedByUserId { get; set; }

    public DateTime? AddedAt { get; set; }

    public virtual User? AddedByUser { get; set; }

    public virtual Playlist Playlist { get; set; } = null!;

    public virtual Song Song { get; set; } = null!;
}
