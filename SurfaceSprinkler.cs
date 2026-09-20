namespace AmsModels;

public sealed class SurfaceSprinkler
{
    public const int RecognitionSummaryMaxLength = 1000;

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SurfaceSprinklerId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int SurfaceId { get; set; }
    public int? IrrigationHeadId { get; set; }
    public int? IrrigationSprinklerModelId { get; set; }
    public int? IrrigationNozzleConfigurationId { get; set; }
    public int? TopImageId { get; set; }
    public int? FrontImageId { get; set; }
    public int? BackImageId { get; set; }
    public int? ReviewedByUserId { get; set; }

    [Required, MaxLength(80)]
    public string Identifier { get; set; } = "";

    [MaxLength(120)]
    public string ManufacturerName { get; set; } = "";

    [MaxLength(160)]
    public string ModelName { get; set; } = "";

    [MaxLength(160)]
    public string ConfigurationName { get; set; } = "";

    [Precision(5, 4)]
    public decimal? RecognitionConfidence { get; set; }

    [MaxLength(RecognitionSummaryMaxLength)]
    public string RecognitionSummary { get; set; } = "";

    public string RecognitionAnalysisJson { get; set; } = "";

    public string RecognitionAnalysisHistoryJson { get; set; } = "[]";

    [MaxLength(500)]
    public string ConditionFlags { get; set; } = "";

    [MaxLength(2000)]
    public string Notes { get; set; } = "";

    [MaxLength(32)]
    public string ReviewDecision { get; set; } = "";

    [Precision(9, 6)]
    public decimal? Latitude { get; set; }

    [Precision(9, 6)]
    public decimal? Longitude { get; set; }

    [Precision(9, 2)]
    public decimal? LocationAccuracyMeters { get; set; }

    [Precision(5, 1)]
    public decimal? ArcDegrees { get; set; }

    [Precision(8, 2)]
    public decimal? OperatingPressureKpa { get; set; }

    public DateTime? LocationCapturedAtUtc { get; set; }

    [MaxLength(32)]
    public string LocationSource { get; set; } = "";

    public bool NeedsReview { get; set; } = true;
    public bool Active { get; set; } = true;
    public DateTime? ConfirmedAtUtc { get; set; }
    public DateTime? ReviewedAtUtc { get; set; }
    // The exact change notice awaiting explicit recorder acknowledgement; reading messages does not clear it.
    [ConcurrencyCheck]
    public Guid? PendingReviewMessagePubId { get; set; }
    public DateTime? IrrigationHeadLinkedAtUtc { get; set; }

    [MaxLength(32)]
    public string IrrigationHeadLinkMethod { get; set; } = "";

    public DateTime LastInspectedAtUtc { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }
    public int CreatedByUserId { get; set; }

    public required Surface Surface { get; set; }
    public IrrigationHead? IrrigationHead { get; set; }
    public IrrigationSprinklerModel? SprinklerModel { get; set; }
    public IrrigationNozzleConfiguration? NozzleConfiguration { get; set; }
    public AppImage? TopImage { get; set; }
    public AppImage? FrontImage { get; set; }
    public AppImage? BackImage { get; set; }
    public User? ReviewedByUser { get; set; }
    public ICollection<SurfaceSprinklerNozzle> Nozzles { get; set; } = [];
    public ICollection<IrrigationSprinklerRecognitionExample> ApprovedRecognitionExamples { get; set; } = [];
    public ICollection<IrrigationSprinklerRecognitionPatternProposal> RecognitionPatternProposals { get; set; } = [];
}
