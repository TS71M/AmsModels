namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ChangeFingerprint), IsUnique = true)]
[Index(nameof(ReviewStatus), nameof(DetectedUtc))]
[Index(nameof(CodexStatus), nameof(UpdatedUtc))]
public sealed class CompetitorFinding
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CompetitorFindingId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int CompetitorSourceId { get; set; }
    public CompetitorSource CompetitorSource { get; set; } = null!;

    public int? CompetitorPageId { get; set; }
    public CompetitorPage? CompetitorPage { get; set; }

    [Required, MaxLength(64)]
    public string ChangeFingerprint { get; set; } = "";

    [Required, MaxLength(1000)]
    public string EvidenceUrl { get; set; } = "";

    [Required, MaxLength(500)]
    public string Title { get; set; } = "";

    [Required, MaxLength(40)]
    public string FindingType { get; set; } = "Update";

    public DateTime DetectedUtc { get; set; } = DateTime.UtcNow;
    public DateTime? PublishedAtUtc { get; set; }

    [MaxLength(4000)]
    public string? ChangeSummary { get; set; }

    [MaxLength(2000)]
    public string? AgronomyManagerRelevance { get; set; }

    [MaxLength(1500)]
    public string? CustomerValue { get; set; }

    [MaxLength(1500)]
    public string? StrategicFit { get; set; }

    [MaxLength(1000)]
    public string? EstimatedEffort { get; set; }

    [MaxLength(1500)]
    public string? RisksAndUnknowns { get; set; }

    [Required, MaxLength(40)]
    public string Recommendation { get; set; } = "Watch";

    [MaxLength(1000)]
    public string? RecommendationReason { get; set; }

    [MaxLength(1000)]
    public string? EvidenceAssessment { get; set; }

    public int RelevanceScore { get; set; }

    [Required, MaxLength(40)]
    public string Confidence { get; set; } = "Low";

    [Required, MaxLength(40)]
    public string ReviewStatus { get; set; } = "New";

    [MaxLength(12000)]
    public string? CodexBrief { get; set; }

    [Required, MaxLength(40)]
    public string CodexStatus { get; set; } = "NotRequested";

    [MaxLength(200)]
    public string? CodexThreadId { get; set; }

    public DateTime? CodexPreparedUtc { get; set; }
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;

    public ICollection<CompetitorDiscussionMessage> DiscussionMessages { get; set; } = [];
}
