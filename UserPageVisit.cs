namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(UserId))]
[Index(nameof(IbuId))]
[Index(nameof(App))]
[Index(nameof(Path))]
[Index(nameof(VisitedUtc))]
[Index(nameof(UserId), nameof(VisitedUtc))]
public sealed class UserPageVisit(
    int? ibuId,
    int userId,
    string app,
    string path,
    DateTime visitedUtc)
{
    [Key]
    public int UserPageVisitId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int? IbuId { get; set; } = ibuId;
    public int UserId { get; set; } = userId;

    [Required, MaxLength(32)]
    public string App { get; set; } = app;

    [Required, MaxLength(512)]
    public string Path { get; set; } = path;

    [MaxLength(256)]
    public string? PageTitle { get; set; }

    [Required, MaxLength(16)]
    public string Method { get; set; } = "GET";

    [MaxLength(45)]
    public string? IpAddress { get; set; }

    [MaxLength(512)]
    public string? UserAgent { get; set; }

    public DateTime VisitedUtc { get; set; } = visitedUtc;

    public Ibu? Ibu { get; set; }
    public User User { get; set; } = null!;
}
