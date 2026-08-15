namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(FieldId), nameof(UserId), nameof(CreatedAtUtc))]
[Index(nameof(ParentGraphAnalysisRecordId))]
public sealed class GraphAnalysisRecord
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GraphAnalysisRecordId { get; set; }

    [Required]
    public Guid PubId { get; set; } = Guid.NewGuid();

    public int IbuId { get; set; }
    public Ibu Ibu { get; set; } = null!;

    public int FieldId { get; set; }
    public Field Field { get; set; } = null!;

    public int? UserId { get; set; }
    public User? User { get; set; }

    public int? ParentGraphAnalysisRecordId { get; set; }
    public GraphAnalysisRecord? ParentGraphAnalysisRecord { get; set; }

    public DateTime CreatedAtUtc { get; set; }

    [Required, MaxLength(32)]
    public string Mode { get; set; } = string.Empty;

    [Required, MaxLength(300)]
    public string Question { get; set; } = string.Empty;

    public DateOnly From { get; set; }
    public DateOnly To { get; set; }
    public Guid? AreaPubId { get; set; }

    [Required, MaxLength(40)]
    public string Outcome { get; set; } = string.Empty;

    [Required, MaxLength(180)]
    public string Title { get; set; } = string.Empty;

    [MaxLength(64)]
    public string? SourceSeriesKey { get; set; }

    [MaxLength(64)]
    public string? TargetSeriesKey { get; set; }

    public int? FieldEvidenceScore { get; set; }
    public int? CombinedEvidenceScore { get; set; }

    [Required]
    public string ResultJson { get; set; } = string.Empty;

    [Required, MaxLength(24)]
    public string AnalysisVersion { get; set; } = "graph-v2";
}
