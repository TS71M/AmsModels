namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuId), nameof(AskedUtc))]
[Index(nameof(UserId), nameof(AskedUtc))]
[Index(nameof(EscalationRecommended), nameof(AskedUtc))]
public sealed class AssistantConversationLog
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AssistantConversationLogId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int? IbuId { get; set; }
    public Ibu? Ibu { get; set; }

    public int? UserId { get; set; }
    public User? User { get; set; }

    public DateTime AskedUtc { get; set; }

    [Required, MaxLength(4000)]
    public string Question { get; set; } = "";

    [Required, MaxLength(8000)]
    public string Answer { get; set; } = "";

    [MaxLength(80)]
    public string? PageArea { get; set; }

    [MaxLength(180)]
    public string? PageRoute { get; set; }

    [MaxLength(220)]
    public string? PageTitle { get; set; }

    [MaxLength(600)]
    public string? Url { get; set; }

    [MaxLength(120)]
    public string? BrowserTitle { get; set; }

    [MaxLength(40)]
    public string? Culture { get; set; }

    [MaxLength(80)]
    public string? ModelName { get; set; }

    [MaxLength(120)]
    public string? Source { get; set; }

    public bool EscalationRecommended { get; set; }

    [MaxLength(500)]
    public string? EscalationReason { get; set; }

    public bool? Helpful { get; set; }

    [MaxLength(1000)]
    public string? UserFeedback { get; set; }

    public string? VisibleHeadingsJson { get; set; }
    public string? VisibleActionsJson { get; set; }
    public string? FormLabelsJson { get; set; }
    public string? PageInfoJson { get; set; }
    public string? RequestContextJson { get; set; }
}
