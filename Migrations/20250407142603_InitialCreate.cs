using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicWeb1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: true),
                    ApprovalStatus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Artists__25706B70CF170D7D", x => x.ArtistID);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Genres__0385055EBAFECE4E", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    PaymentMethodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PaymentM__DC31C1F34AA64086", x => x.PaymentMethodID);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    PlaylistID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Visibility = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValue: "Public"),
                    SystemGenerated = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    CoverImage = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Playlist__B301678064A1FAB5", x => x.PlaylistID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Roles__8AFACE3ACB7A3DE3", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Statuses__C8EE2043226E6BE0", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "TargetTypes",
                columns: table => new
                {
                    TargetTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetTypeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TargetTy__B3CB14E11401C7DE", x => x.TargetTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    GoogleID = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    IsLogin = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    IsEmailVerified = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    RefreshToken = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    LastLoginAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__1788CCAC70C5DF26", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: true),
                    CoverImage = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ArtistID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Albums__97B4BE174D078D7B", x => x.AlbumID);
                    table.ForeignKey(
                        name: "FK_Albums_Artists",
                        column: x => x.ArtistID,
                        principalTable: "Artists",
                        principalColumn: "ArtistID");
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    Lyrics = table.Column<string>(type: "text", nullable: true),
                    FilePath = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    GenreID = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    AudioURL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Songs__12E3D6F7D96908D8", x => x.SongID);
                    table.ForeignKey(
                        name: "FK_Songs_Genres",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "GenreID");
                });

            migrationBuilder.CreateTable(
                name: "FavoritePlaylists",
                columns: table => new
                {
                    PlaylistID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Favorite__6279EB4A4EF98B85", x => new { x.PlaylistID, x.UserID });
                    table.ForeignKey(
                        name: "FK_FavoritePlaylists_Playlists",
                        column: x => x.PlaylistID,
                        principalTable: "Playlists",
                        principalColumn: "PlaylistID");
                    table.ForeignKey(
                        name: "FK_FavoritePlaylists_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    FeedbackID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Feedback__6A4BEDF6E36BB878", x => x.FeedbackID);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "text", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Notifica__20CF2E32E75EFB11", x => x.NotificationID);
                    table.ForeignKey(
                        name: "FK_Notifications_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "PasswordResets",
                columns: table => new
                {
                    ResetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ResetToken = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsUsed = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Password__783CF7AD33DFE2B1", x => x.ResetID);
                    table.ForeignKey(
                        name: "FK_PasswordResets_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "RatingPlaylists",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    PlaylistID = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RatingPl__0CB8DAD43596A360", x => new { x.UserID, x.PlaylistID });
                    table.ForeignKey(
                        name: "FK_RatingPlaylists_Playlists",
                        column: x => x.PlaylistID,
                        principalTable: "Playlists",
                        principalColumn: "PlaylistID");
                    table.ForeignKey(
                        name: "FK_RatingPlaylists_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    SubscriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanType = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    IsAutoRenew = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Subscrip__9A2B24BDA45678FA", x => x.SubscriptionID);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    PaymentMethodID = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Transact__55433A4BB8B75445", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_Transactions_PaymentMethods",
                        column: x => x.PaymentMethodID,
                        principalTable: "PaymentMethods",
                        principalColumn: "PaymentMethodID");
                    table.ForeignKey(
                        name: "FK_Transactions_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserRole__AF27604F3E790A1A", x => new { x.UserID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID");
                    table.ForeignKey(
                        name: "FK_UserRoles_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "RatingAlbums",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    AlbumID = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RatingAl__7EF3874D16C3F449", x => new { x.UserID, x.AlbumID });
                    table.ForeignKey(
                        name: "FK_RatingAlbums_Albums",
                        column: x => x.AlbumID,
                        principalTable: "Albums",
                        principalColumn: "AlbumID");
                    table.ForeignKey(
                        name: "FK_RatingAlbums_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "ListenHistories",
                columns: table => new
                {
                    ListenID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ListenDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Device = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PlayedDuration = table.Column<int>(type: "int", nullable: true),
                    DeviceType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ListenHi__B2BCADCB946543F7", x => x.ListenID);
                    table.ForeignKey(
                        name: "FK_ListenHistories_Songs",
                        column: x => x.SongID,
                        principalTable: "Songs",
                        principalColumn: "SongID");
                    table.ForeignKey(
                        name: "FK_ListenHistories_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "PlaylistSongs",
                columns: table => new
                {
                    PlaylistID = table.Column<int>(type: "int", nullable: false),
                    SongID = table.Column<int>(type: "int", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: true),
                    AddedByUserID = table.Column<int>(type: "int", nullable: true),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Playlist__D22F5AEFAB35A2C3", x => new { x.PlaylistID, x.SongID });
                    table.ForeignKey(
                        name: "FK_PlaylistSongs_Playlists",
                        column: x => x.PlaylistID,
                        principalTable: "Playlists",
                        principalColumn: "PlaylistID");
                    table.ForeignKey(
                        name: "FK_PlaylistSongs_Songs",
                        column: x => x.SongID,
                        principalTable: "Songs",
                        principalColumn: "SongID");
                    table.ForeignKey(
                        name: "FK_PlaylistSongs_Users",
                        column: x => x.AddedByUserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "RatingSongs",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    SongID = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RatingSo__76A6F1C3C7B9E7E7", x => new { x.UserID, x.SongID });
                    table.ForeignKey(
                        name: "FK_RatingSongs_Songs",
                        column: x => x.SongID,
                        principalTable: "Songs",
                        principalColumn: "SongID");
                    table.ForeignKey(
                        name: "FK_RatingSongs_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "SongArtists",
                columns: table => new
                {
                    SongID = table.Column<int>(type: "int", nullable: false),
                    ArtistID = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SongArti__00B4D040CAB4F8EA", x => new { x.SongID, x.ArtistID });
                    table.ForeignKey(
                        name: "FK_SongArtists_Artists",
                        column: x => x.ArtistID,
                        principalTable: "Artists",
                        principalColumn: "ArtistID");
                    table.ForeignKey(
                        name: "FK_SongArtists_Songs",
                        column: x => x.SongID,
                        principalTable: "Songs",
                        principalColumn: "SongID");
                });

            migrationBuilder.CreateTable(
                name: "SongStatuses",
                columns: table => new
                {
                    SongID = table.Column<int>(type: "int", nullable: false),
                    StatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SongStat__3E6D34F36038C54A", x => new { x.SongID, x.StatusID });
                    table.ForeignKey(
                        name: "FK_SongStatuses_Songs",
                        column: x => x.SongID,
                        principalTable: "Songs",
                        principalColumn: "SongID");
                    table.ForeignKey(
                        name: "FK_SongStatuses_Statuses",
                        column: x => x.StatusID,
                        principalTable: "Statuses",
                        principalColumn: "StatusID");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "text", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FeedbackID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Comments__C3B4DFAA44605165", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_Feedbacks",
                        column: x => x.FeedbackID,
                        principalTable: "Feedbacks",
                        principalColumn: "FeedbackID");
                    table.ForeignKey(
                        name: "FK_Comments_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "ReportTargetTypes",
                columns: table => new
                {
                    ReportTargetTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetTypeID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    ResolvedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModeratorID = table.Column<int>(type: "int", nullable: true),
                    FeedbackID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ReportTa__F4C2F2BFF2D48D84", x => x.ReportTargetTypeID);
                    table.ForeignKey(
                        name: "FK_ReportTargetTypes_Feedbacks",
                        column: x => x.FeedbackID,
                        principalTable: "Feedbacks",
                        principalColumn: "FeedbackID");
                    table.ForeignKey(
                        name: "FK_ReportTargetTypes_Moderator",
                        column: x => x.ModeratorID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_ReportTargetTypes_TargetTypes",
                        column: x => x.TargetTypeID,
                        principalTable: "TargetTypes",
                        principalColumn: "TargetTypeID");
                    table.ForeignKey(
                        name: "FK_ReportTargetTypes_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NotificationID = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Location = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Events__7944C87081329014", x => x.EventID);
                    table.ForeignKey(
                        name: "FK_Events_Notifications",
                        column: x => x.NotificationID,
                        principalTable: "Notifications",
                        principalColumn: "NotificationID");
                });

            migrationBuilder.CreateTable(
                name: "NotificationTypes",
                columns: table => new
                {
                    NotificationTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NotificationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Notifica__299002A11AF6AD68", x => x.NotificationTypeID);
                    table.ForeignKey(
                        name: "FK_NotificationTypes_Notifications",
                        column: x => x.NotificationID,
                        principalTable: "Notifications",
                        principalColumn: "NotificationID");
                });

            migrationBuilder.CreateTable(
                name: "TransactionStatuses",
                columns: table => new
                {
                    TransactionStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Transact__57B5E1A3663EE3FB", x => x.TransactionStatusID);
                    table.ForeignKey(
                        name: "FK_TransactionStatuses_Transactions",
                        column: x => x.TransactionID,
                        principalTable: "Transactions",
                        principalColumn: "TransactionID");
                });

            migrationBuilder.CreateTable(
                name: "MusicEvents",
                columns: table => new
                {
                    MusicEventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistID = table.Column<int>(type: "int", nullable: false),
                    EventID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MusicEve__2D0C84D02158B9F3", x => x.MusicEventID);
                    table.ForeignKey(
                        name: "FK_MusicEvents_Artists",
                        column: x => x.ArtistID,
                        principalTable: "Artists",
                        principalColumn: "ArtistID");
                    table.ForeignKey(
                        name: "FK_MusicEvents_Events",
                        column: x => x.EventID,
                        principalTable: "Events",
                        principalColumn: "EventID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistID",
                table: "Albums",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FeedbackID",
                table: "Comments",
                column: "FeedbackID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserID",
                table: "Comments",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_NotificationID",
                table: "Events",
                column: "NotificationID");

            migrationBuilder.CreateIndex(
                name: "IX_FavoritePlaylists_UserID",
                table: "FavoritePlaylists",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserID",
                table: "Feedbacks",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ListenHistories_SongID",
                table: "ListenHistories",
                column: "SongID");

            migrationBuilder.CreateIndex(
                name: "IX_ListenHistories_UserID",
                table: "ListenHistories",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_MusicEvents_ArtistID",
                table: "MusicEvents",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_MusicEvents_EventID",
                table: "MusicEvents",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserID",
                table: "Notifications",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTypes_NotificationID",
                table: "NotificationTypes",
                column: "NotificationID");

            migrationBuilder.CreateIndex(
                name: "IX_PasswordResets_UserID",
                table: "PasswordResets",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistSongs_AddedByUserID",
                table: "PlaylistSongs",
                column: "AddedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistSongs_SongID",
                table: "PlaylistSongs",
                column: "SongID");

            migrationBuilder.CreateIndex(
                name: "IX_RatingAlbums_AlbumID",
                table: "RatingAlbums",
                column: "AlbumID");

            migrationBuilder.CreateIndex(
                name: "IX_RatingPlaylists_PlaylistID",
                table: "RatingPlaylists",
                column: "PlaylistID");

            migrationBuilder.CreateIndex(
                name: "IX_RatingSongs_SongID",
                table: "RatingSongs",
                column: "SongID");

            migrationBuilder.CreateIndex(
                name: "IX_ReportTargetTypes_FeedbackID",
                table: "ReportTargetTypes",
                column: "FeedbackID");

            migrationBuilder.CreateIndex(
                name: "IX_ReportTargetTypes_ModeratorID",
                table: "ReportTargetTypes",
                column: "ModeratorID");

            migrationBuilder.CreateIndex(
                name: "IX_ReportTargetTypes_TargetTypeID",
                table: "ReportTargetTypes",
                column: "TargetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ReportTargetTypes_UserID",
                table: "ReportTargetTypes",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_SongArtists_ArtistID",
                table: "SongArtists",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GenreID",
                table: "Songs",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_SongStatuses_StatusID",
                table: "SongStatuses",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserID",
                table: "Subscriptions",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PaymentMethodID",
                table: "Transactions",
                column: "PaymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserID",
                table: "Transactions",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionStatuses_TransactionID",
                table: "TransactionStatuses",
                column: "TransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "FavoritePlaylists");

            migrationBuilder.DropTable(
                name: "ListenHistories");

            migrationBuilder.DropTable(
                name: "MusicEvents");

            migrationBuilder.DropTable(
                name: "NotificationTypes");

            migrationBuilder.DropTable(
                name: "PasswordResets");

            migrationBuilder.DropTable(
                name: "PlaylistSongs");

            migrationBuilder.DropTable(
                name: "RatingAlbums");

            migrationBuilder.DropTable(
                name: "RatingPlaylists");

            migrationBuilder.DropTable(
                name: "RatingSongs");

            migrationBuilder.DropTable(
                name: "ReportTargetTypes");

            migrationBuilder.DropTable(
                name: "SongArtists");

            migrationBuilder.DropTable(
                name: "SongStatuses");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "TransactionStatuses");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "TargetTypes");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
