namespace AmsModels;

[Index(nameof(Status), nameof(QueuedUtc))]
[Index(nameof(ResearchArticleId), nameof(Status), nameof(QueuedUtc))]
[Index(nameof(CompetitorFindingId), nameof(Status), nameof(QueuedUtc))]
public sealed class ResearchCodexTask
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long ResearchCodexTaskId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int? ResearchArticleId { get; set; }
    public ResearchArticle? ResearchArticle { get; set; }

    public int? CompetitorFindingId { get; set; }
    public CompetitorFinding? CompetitorFinding { get; set; }

    public int RequestedByUserId { get; set; }
    public User RequestedByUser { get; set; } = null!;

    [Required, MaxLength(24)]
    public string Status { get; set; } = ResearchCodexTaskStatuses.Pending;

    [Required, MaxLength(20000)]
    public string Brief { get; set; } = "";

    [MaxLength(20000)]
    public string? Result { get; set; }

    [MaxLength(1000)]
    public string? LastError { get; set; }

    [MaxLength(200)]
    public string? ThreadId { get; set; }

    public Guid? LeaseId { get; set; }
    public int Attempts { get; set; }
    public DateTime QueuedUtc { get; set; }
    public DateTime? StartedUtc { get; set; }
    public DateTime? CompletedUtc { get; set; }
    public DateTime UpdatedUtc { get; set; }
}

public static class ResearchCodexTaskStatuses
{
    public const string Draft = "draft";
    public const string Pending = "pending";
    public const string Running = "running";
    public const string Completed = "completed";
    public const string Failed = "failed";
}
