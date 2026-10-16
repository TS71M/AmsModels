namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ApplicationPlanZoneId), nameof(ApplicationPlanProductSnapshotId), IsUnique = true)]
[Index(nameof(ApplicationPlanZoneId), nameof(SortOrder))]
public sealed class ApplicationPlanZoneProduct
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationPlanZoneProductId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int ApplicationPlanZoneId { get; set; }

    [Required]
    public int ApplicationPlanProductSnapshotId { get; set; }

    public int SortOrder { get; set; }

    [Precision(10, 3)]
    public decimal DefaultRate { get; set; }

    [Precision(10, 2)]
    public decimal DefaultWaterVolume { get; set; }

    [MaxLength(1000)]
    public string Notes { get; set; } = "";

    // Optional annual/monthly intent in this frozen product's quantity unit.
    // Independent of scheduled applications and material-purchase allocations.
    [MaxLength(4000)]
    public string? AllocationIntentJson { get; set; }

    public required ApplicationPlanZone ApplicationPlanZone { get; set; }
    public required ApplicationPlanProductSnapshot ApplicationPlanProductSnapshot { get; set; }
}
