namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(FieldId), nameof(StartedUtc))]
[Index(nameof(Status), nameof(StartedUtc))]
public sealed class SatelliteStressScanRun
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SatelliteStressScanRunId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int FieldId { get; set; }
    public Field Field { get; set; } = null!;

    public DateTime StartedUtc { get; set; }
    public DateTime? CompletedUtc { get; set; }

    [Required, MaxLength(40)]
    public string Trigger { get; set; } = "Manual";

    [Required, MaxLength(40)]
    public string Status { get; set; } = "Started";

    public int RequestCount { get; set; }

    [Precision(10, 3)]
    public decimal ProcessingUnitsEstimate { get; set; }

    [MaxLength(160)]
    public string? SceneId { get; set; }

    [MaxLength(500)]
    public string? Message { get; set; }
}
