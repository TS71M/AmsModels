namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ApplicationPlanRevisionId), nameof(SourceAreaPubId), IsUnique = true)]
public class ApplicationPlanAreaSnapshot
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationPlanAreaSnapshotId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int ApplicationPlanRevisionId { get; set; }

    public Guid? SourceAreaPubId { get; set; }

    [Required, MaxLength(120)]
    public string AreaName { get; set; } = "";

    public int SurfaceCount { get; set; }

    [Precision(12, 1)]
    public decimal SurfaceAreaM2 { get; set; }

    [MaxLength(32000)]
    public string SurfaceSnapshotJson { get; set; } = "";

    public required ApplicationPlanRevision ApplicationPlanRevision { get; set; }
    public virtual ICollection<ApplicationPlanZoneArea> ZoneAreas { get; set; } = [];
}
