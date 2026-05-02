namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(FieldId), IsUnique = true)]
[Index(nameof(Enabled), nameof(NextEligibleScanUtc))]
public sealed class SatelliteStressMonitoringSetting
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SatelliteStressMonitoringSettingId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int FieldId { get; set; }
    public Field Field { get; set; } = null!;

    public bool Enabled { get; set; }
    public SatelliteStressMonitoringFrequency Frequency { get; set; } = SatelliteStressMonitoringFrequency.Weekly;

    [Precision(5, 2)]
    public decimal MaxCloudCoveragePercent { get; set; } = 40m;

    public int MinDaysBetweenScans { get; set; } = 3;
    public int MonthlyRequestBudget { get; set; } = 30;
    public DateTime? LastCatalogCheckUtc { get; set; }
    public DateTime? LastProcessedUtc { get; set; }
    public DateTime? NextEligibleScanUtc { get; set; }

    [MaxLength(160)]
    public string? LastProcessedSceneId { get; set; }

    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;
}
