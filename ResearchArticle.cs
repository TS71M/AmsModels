namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(NormalizedUrlHash), IsUnique = true)]
[Index(nameof(ReviewStatus), nameof(DiscoveredUtc))]
[Index(nameof(PublishWebApp), nameof(PublishedUtc))]
[Index(nameof(PublishPublicWeb), nameof(PublishedUtc))]
public sealed class ResearchArticle
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ResearchArticleId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int ResearchSourceId { get; set; }
    public ResearchSource ResearchSource { get; set; } = null!;

    [Required, MaxLength(1000)]
    public string OriginalUrl { get; set; } = "";

    [Required, MaxLength(64)]
    public string NormalizedUrlHash { get; set; } = "";

    [Required, MaxLength(500)]
    public string Title { get; set; } = "";

    [MaxLength(240)]
    public string? Author { get; set; }

    [MaxLength(240)]
    public string? Publisher { get; set; }

    public DateTime? PublishedAtUtc { get; set; }
    public DateTime DiscoveredUtc { get; set; } = DateTime.UtcNow;

    [MaxLength(4000)]
    public string? SourceExcerpt { get; set; }

    [MaxLength(4000)]
    public string? EditorialSummary { get; set; }

    [MaxLength(1000)]
    public string? WhyItMatters { get; set; }

    [MaxLength(1000)]
    public string? EvidenceAssessment { get; set; }

    [MaxLength(1000)]
    public string? Limitations { get; set; }

    [MaxLength(500)]
    public string? TopicTags { get; set; }

    [Required, MaxLength(40)]
    public string ReviewStatus { get; set; } = "New";

    public bool SuggestELearningUpdate { get; set; }
    public bool PublishWebApp { get; set; }
    public bool PublishMobileApp { get; set; }
    public bool PublishPublicWeb { get; set; }
    public DateTime? PublishedUtc { get; set; }
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;

    public ICollection<ResearchDiscussionMessage> DiscussionMessages { get; set; } = [];
}
