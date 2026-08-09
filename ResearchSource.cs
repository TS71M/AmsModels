namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IsEnabled), nameof(NextScanUtc))]
public sealed class ResearchSource
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ResearchSourceId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(160)]
    public string Name { get; set; } = "";

    [Required, MaxLength(1000)]
    public string WebsiteUrl { get; set; } = "";

    [MaxLength(1000)]
    public string? FeedUrl { get; set; }

    [Required, MaxLength(40)]
    public string SourceType { get; set; } = "Rss";

    [MaxLength(500)]
    public string? Topics { get; set; }

    [MaxLength(1000)]
    public string? AccessNotes { get; set; }

    public bool IsEnabled { get; set; } = true;
    public int ScanIntervalDays { get; set; } = 7;
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime? LastScanUtc { get; set; }
    public DateTime? NextScanUtc { get; set; }
    public DateTime? LastSuccessfulScanUtc { get; set; }

    [MaxLength(1000)]
    public string? LastScanMessage { get; set; }

    public ICollection<ResearchArticle> Articles { get; set; } = [];
}
