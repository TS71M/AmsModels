namespace AmsModels;

[Index(nameof(ApplicationPlanZoneId), nameof(NutrientId), IsUnique = true)]
[Index(nameof(NutrientId))]
public sealed class ApplicationPlanZoneNutrientTarget
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationPlanZoneNutrientTargetId { get; set; }

    [Required]
    public int ApplicationPlanZoneId { get; set; }

    [Required]
    public int NutrientId { get; set; }

    [Precision(10, 3)]
    public decimal AnnualTargetGramsPerM2 { get; set; }

    [Precision(10, 3)]
    public decimal? MinimumGramsPerM2 { get; set; }

    [Precision(10, 3)]
    public decimal? MaximumGramsPerM2 { get; set; }

    [Required, MaxLength(120)]
    public string Source { get; set; } = "manual";

    [MaxLength(1000)]
    public string Rationale { get; set; } = "";

    public required ApplicationPlanZone ApplicationPlanZone { get; set; }
    public required Nutrient Nutrient { get; set; }
}
