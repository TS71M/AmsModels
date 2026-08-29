namespace AmsModels;

/// <summary>
/// Immutable, globally reusable lesson created only when a SuperAdmin approves a
/// catalog-backed sprinkler recognition. It deliberately excludes field, company,
/// user, and coordinate data so recognition can reuse the lesson across tenants.
/// </summary>
public sealed class IrrigationSprinklerRecognitionExample
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationSprinklerRecognitionExampleId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int SurfaceSprinklerId { get; set; }
    public int IrrigationSprinklerModelId { get; set; }
    public int? IrrigationNozzleConfigurationId { get; set; }
    public int ApprovedByUserId { get; set; }

    [Required, MaxLength(64)]
    public string AnalysisHash { get; set; } = "";

    [Required, MaxLength(32)]
    public string PromptVersion { get; set; } = "";

    [Precision(5, 4)]
    public decimal OriginalConfidence { get; set; }

    [MaxLength(120)]
    public string PredictedManufacturerName { get; set; } = "";

    [MaxLength(160)]
    public string PredictedModelName { get; set; } = "";

    [MaxLength(160)]
    public string PredictedConfigurationName { get; set; } = "";

    [Required, MaxLength(120)]
    public string ApprovedManufacturerName { get; set; } = "";

    [Required, MaxLength(160)]
    public string ApprovedModelName { get; set; } = "";

    [MaxLength(160)]
    public string ApprovedConfigurationName { get; set; } = "";

    [MaxLength(240)]
    public string ObservedNozzleColors { get; set; } = "";

    [MaxLength(2000)]
    public string EvidenceSummary { get; set; } = "";

    [Required, MaxLength(500)]
    public string ErrorFingerprint { get; set; } = "";

    public string OriginalAnalysisJson { get; set; } = "";
    public string ApprovedCorrectionJson { get; set; } = "";

    public Guid? TopImagePubId { get; set; }
    public Guid? FrontImagePubId { get; set; }
    public Guid? BackImagePubId { get; set; }

    public bool IsGlobalStandard { get; set; } = true;
    public bool Active { get; set; } = true;
    public DateTime ApprovedAtUtc { get; set; }

    public required SurfaceSprinkler SourceSprinkler { get; set; }
    public required IrrigationSprinklerModel ApprovedSprinklerModel { get; set; }
    public IrrigationNozzleConfiguration? ApprovedNozzleConfiguration { get; set; }
    public required User ApprovedByUser { get; set; }
}
