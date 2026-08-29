namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(CatchCanTestId), nameof(Active))]
[Index(nameof(CatchCanTestId), nameof(X), nameof(Y), IsUnique = true)]
public sealed class CatchCanMeasurement
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CatchCanMeasurementId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int CatchCanTestId { get; set; }

    [Precision(12, 4)]
    public decimal X { get; set; }

    [Precision(12, 4)]
    public decimal Y { get; set; }

    [Precision(12, 4), Range(typeof(decimal), "0", "1000000")]
    public decimal? CollectedMl { get; set; }

    [Precision(12, 4), Range(typeof(decimal), "0.0001", "1000000")]
    public decimal? ContainerAreaCm2 { get; set; }

    [Precision(12, 5), Range(typeof(decimal), "0", "10000")]
    public decimal AppliedMm { get; set; }

    /// <summary>Immutable uncalibrated simulator value captured when the field test was recorded.</summary>
    [Precision(12, 5), Range(typeof(decimal), "0", "10000")]
    public decimal BaselineSimulatedMm { get; set; }

    public bool Active { get; set; } = true;
    public required CatchCanTest CatchCanTest { get; set; }
}
