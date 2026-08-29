namespace AmsModels;

public static class IrrigationRecognitionPatternProposalStatuses
{
    public const string Pending = "Pending";
    public const string Approved = "Approved";
    public const string Rejected = "Rejected";
}

/// <summary>
/// A visual discriminator suggested by an image analysis. It never changes the
/// recognition catalog until a SuperAdmin reviews the source image set.
/// </summary>
public sealed class IrrigationSprinklerRecognitionPatternProposal
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationSprinklerRecognitionPatternProposalId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int SurfaceSprinklerId { get; set; }
    public int? IrrigationSprinklerModelId { get; set; }
    public int? IrrigationSprinklerRecognitionFactId { get; set; }
    public int? ReviewedByUserId { get; set; }

    [Required, MaxLength(24)]
    public string Status { get; set; } = IrrigationRecognitionPatternProposalStatuses.Pending;

    [Required, MaxLength(64)]
    public string AnalysisHash { get; set; } = "";

    [Required, MaxLength(64)]
    public string PatternFingerprint { get; set; } = "";

    [Required, MaxLength(64)]
    public string FactType { get; set; } = "";

    [Required, MaxLength(500)]
    public string ProposedValue { get; set; } = "";

    [MaxLength(40)]
    public string EvidenceViews { get; set; } = "";

    [MaxLength(1200)]
    public string EvidenceSummary { get; set; } = "";

    [Precision(5, 4)]
    public decimal AiConfidence { get; set; }

    [MaxLength(64)]
    public string AiModel { get; set; } = "";

    [MaxLength(32)]
    public string PromptVersion { get; set; } = "";

    [MaxLength(120)]
    public string PredictedManufacturerName { get; set; } = "";

    [MaxLength(160)]
    public string PredictedModelName { get; set; } = "";

    public bool SuggestedRequiredForExactMatch { get; set; }
    public Guid? TopImagePubId { get; set; }
    public Guid? FrontImagePubId { get; set; }
    public Guid? BackImagePubId { get; set; }
    public int OccurrenceCount { get; set; } = 1;
    public string OriginalProposalJson { get; set; } = "";

    [MaxLength(1000)]
    public string ReviewerNotes { get; set; } = "";

    public DateTime CreatedAtUtc { get; set; }
    public DateTime LastObservedAtUtc { get; set; }
    public DateTime? ReviewedAtUtc { get; set; }

    public required SurfaceSprinkler SourceSprinkler { get; set; }
    public IrrigationSprinklerModel? SprinklerModel { get; set; }
    public IrrigationSprinklerRecognitionFact? ApprovedFact { get; set; }
    public User? ReviewedByUser { get; set; }
}
