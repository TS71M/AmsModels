namespace AmsModels;

public sealed class IrrigationSprinklerRecognitionFact
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationSprinklerRecognitionFactId { get; set; }

    public int IrrigationSprinklerRecognitionProfileId { get; set; }

    [Required, MaxLength(64)]
    public string FactType { get; set; } = "";

    [Required, MaxLength(500)]
    public string Value { get; set; } = "";

    [Precision(4, 3), Range(typeof(decimal), "0", "1")]
    public decimal EvidenceWeight { get; set; } = 0.5m;

    public bool IsRequiredForExactMatch { get; set; }

    [MaxLength(500)]
    public string? SourceUrl { get; set; }

    [Range(0, 1000)]
    public int SortOrder { get; set; }

    public IrrigationSprinklerRecognitionProfile RecognitionProfile { get; set; } = null!;
}
