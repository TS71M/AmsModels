namespace AmsModels;

[Index(nameof(ApplicationPlanZoneId), nameof(ApplicationPlanAreaSnapshotId), IsUnique = true)]
public sealed class ApplicationPlanZoneArea
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationPlanZoneAreaId { get; set; }

    [Required]
    public int ApplicationPlanZoneId { get; set; }

    [Required]
    public int ApplicationPlanAreaSnapshotId { get; set; }

    public required ApplicationPlanZone ApplicationPlanZone { get; set; }
    public required ApplicationPlanAreaSnapshot ApplicationPlanAreaSnapshot { get; set; }
}
