namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(CompetitorSourceId), nameof(NormalizedUrlHash), IsUnique = true)]
public sealed class CompetitorPage
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CompetitorPageId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int CompetitorSourceId { get; set; }
    public CompetitorSource CompetitorSource { get; set; } = null!;

    [Required, MaxLength(1000)]
    public string Url { get; set; } = "";

    [Required, MaxLength(64)]
    public string NormalizedUrlHash { get; set; } = "";

    [MaxLength(500)]
    public string? LastTitle { get; set; }

    [MaxLength(64)]
    public string? ContentHash { get; set; }

    [MaxLength(20000)]
    public string? ContentSnapshot { get; set; }

    public bool IsEnabled { get; set; } = true;
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime? LastScanUtc { get; set; }
    public DateTime? LastChangedUtc { get; set; }

    [MaxLength(1000)]
    public string? LastScanMessage { get; set; }

    public ICollection<CompetitorFinding> Findings { get; set; } = [];
}
