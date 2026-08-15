using Lib.Planning;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ApplicationPlanRevisionId), nameof(SourceProductPubId), IsUnique = true)]
public class ApplicationPlanProductSnapshot
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationPlanProductSnapshotId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int ApplicationPlanRevisionId { get; set; }

    public Guid? SourceProductPubId { get; set; }

    [Required, MaxLength(250)]
    public string ProductName { get; set; } = "";

    [MaxLength(120)]
    public string ProductTypeName { get; set; } = "";

    public FertilizerApplicationRateUnit? RateUnit { get; set; }

    [MaxLength(40)]
    public string RateUnitLabel { get; set; } = "";

    [Precision(10, 3)]
    public decimal RecommendedRate { get; set; }

    [Precision(8, 4)]
    public decimal? DensityKgPerL { get; set; }

    [Precision(10, 3)]
    public decimal PackSize { get; set; }

    [MaxLength(20)]
    public string PackUnitLabel { get; set; } = "";

    [Precision(10, 2)]
    public decimal UnitCost { get; set; }

    [Precision(12, 3)]
    public decimal InventoryQuantitySnapshot { get; set; }

    public bool IsAvailable { get; set; } = true;

    public required ApplicationPlanRevision ApplicationPlanRevision { get; set; }
    public virtual ICollection<ApplicationPlanProductNutrientSnapshot> Nutrients { get; set; } = [];
    public virtual ICollection<ApplicationPlanItem> PlannedApplications { get; set; } = [];
    public virtual ICollection<ApplicationPlanZoneProduct> Zones { get; set; } = [];
}
