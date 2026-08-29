namespace AmsModels;

public sealed class IrrigationSprinklerRecognitionProfile
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationSprinklerRecognitionProfileId { get; set; }

    public int IrrigationSprinklerModelId { get; set; }

    [Required, MaxLength(120)]
    public string RecognitionFamily { get; set; } = "";

    [MaxLength(160)]
    public string VisibleModelMarking { get; set; } = "";

    [MaxLength(32)]
    public string DriveType { get; set; } = "Unknown";

    [MaxLength(32)]
    public string ArcType { get; set; } = "Unknown";

    [MaxLength(80)]
    public string BodyStyle { get; set; } = "";

    [Range(0, 8)]
    public int? InlineFrontNozzlePortCountMin { get; set; }

    [Range(0, 8)]
    public int? InlineFrontNozzlePortCountMax { get; set; }

    [Range(0, 4)]
    public int? RearNozzlePortCount { get; set; }

    [MaxLength(80)]
    public string DimensionBoundary { get; set; } = "";

    [Precision(8, 2), Range(typeof(decimal), "0", "2000")]
    public decimal? OuterBodyDiameterMinMm { get; set; }

    [Precision(8, 2), Range(typeof(decimal), "0", "2000")]
    public decimal? OuterBodyDiameterMaxMm { get; set; }

    [MaxLength(80)]
    public string ReferenceFeature { get; set; } = "";

    [Precision(8, 2), Range(typeof(decimal), "0", "2000")]
    public decimal? ReferenceDiameterMm { get; set; }

    [Precision(8, 2), Range(typeof(decimal), "0", "3000")]
    public decimal? BodyHeightMinMm { get; set; }

    [Precision(8, 2), Range(typeof(decimal), "0", "3000")]
    public decimal? BodyHeightMaxMm { get; set; }

    [Precision(7, 2), Range(typeof(decimal), "0", "200")]
    public decimal? InletSizeMillimeters { get; set; }

    [Precision(6, 2), Range(typeof(decimal), "0", "100")]
    public decimal? DimensionalToleranceMm { get; set; }

    [Required, MaxLength(32)]
    public string VerificationStatus { get; set; } = "Partial";

    [MaxLength(500)]
    public string? SourceUrl { get; set; }

    [MaxLength(2000)]
    public string DistinguishingSummary { get; set; } = "";

    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public IrrigationSprinklerModel SprinklerModel { get; set; } = null!;
    public ICollection<IrrigationSprinklerRecognitionFact> Facts { get; set; } = [];
}
