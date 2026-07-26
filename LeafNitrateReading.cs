namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(LeafNitrateMeasurementId), nameof(Sequence), IsUnique = true)]
public sealed class LeafNitrateReading
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LeafNitrateReadingId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int LeafNitrateMeasurementId { get; set; }
    public int Sequence { get; set; }

    [Precision(10, 2)]
    public decimal RawValue { get; set; }

    [Required, MaxLength(16)]
    public string RawBasis { get; set; } = "NO3-N";

    [Required, MaxLength(16)]
    public string RawUnit { get; set; } = "ppm";

    [Precision(10, 2)]
    public decimal NormalizedNo3NPpm { get; set; }

    public bool Stabilized { get; set; } = true;
    public bool Rejected { get; set; }

    [MaxLength(250)]
    public string? RejectionReason { get; set; }

    public LeafNitrateMeasurement Measurement { get; set; } = null!;
}
