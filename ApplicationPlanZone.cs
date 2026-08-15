namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ApplicationPlanRevisionId), nameof(SortOrder))]
public class ApplicationPlanZone
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationPlanZoneId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int ApplicationPlanRevisionId { get; set; }

    [Required, MaxLength(120)]
    public string ZoneName { get; set; } = "";

    public int SortOrder { get; set; }

    [Precision(12, 1)]
    public decimal TreatedAreaSnapshotM2 { get; set; }

    [MaxLength(1000)]
    public string Notes { get; set; } = "";

    public required ApplicationPlanRevision ApplicationPlanRevision { get; set; }
    public virtual ICollection<ApplicationPlanZoneArea> Areas { get; set; } = [];
    public virtual ICollection<ApplicationPlanZoneNutrientTarget> NutrientTargets { get; set; } = [];
    public virtual ICollection<ApplicationPlanZoneProduct> Products { get; set; } = [];
}
