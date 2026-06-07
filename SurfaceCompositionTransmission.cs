namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(SurfaceId))]
[Index(nameof(CreatedAtUtc))]
public class SurfaceCompositionTransmission
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SurfaceCompositionTransmissionId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int SurfaceId { get; set; }

    [Required]
    public DateTime CreatedAtUtc { get; set; }

    [Required]
    public DateTime NextAllowedAtUtc { get; set; }

    [Required, MaxLength(80)]
    public string ModelUsed { get; set; } = "";

    [Required, MaxLength(16)]
    public string SourceCultureCode { get; set; } = "en";

    [Precision(5, 4)]
    public decimal Confidence { get; set; }

    [MaxLength(2000)]
    public string? Summary { get; set; }

    [MaxLength(2000)]
    public string? SuitabilitySummary { get; set; }

    [Precision(5, 1)]
    public decimal WeedCoveragePercent { get; set; }

    public int PhotoCount { get; set; }

    [Required, MaxLength(32)]
    public string RerunStatus { get; set; } = "not_checked";

    public DateTime? RerunLastCheckedAtUtc { get; set; }

    [MaxLength(80)]
    public string? RerunLastModelUsed { get; set; }

    [Precision(5, 4)]
    public decimal? RerunLastConfidence { get; set; }

    public DateTime? RerunDecisionAtUtc { get; set; }

    [MaxLength(1000)]
    public string? RerunReviewNote { get; set; }

    public string? RerunResultJson { get; set; }

    [ForeignKey(nameof(SurfaceId))]
    public Surface Surface { get; set; } = default!;

    public ICollection<SurfaceCompositionTransmissionSpecies> Species { get; set; } = [];
    public ICollection<AreaCompositionPhoto> Photos { get; set; } = [];
}
