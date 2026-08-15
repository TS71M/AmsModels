using Lib.Planning;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ApplicationPlanItemId), nameof(NutrientCodeSnapshot), IsUnique = true)]
public sealed class ApplicationPlanItemNutrient
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationPlanItemNutrientId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int ApplicationPlanItemId { get; set; }

    public int? NutrientId { get; set; }

    [Required, MaxLength(20)]
    public string NutrientCodeSnapshot { get; set; } = "";

    [Precision(10, 4)]
    public decimal AnalysisAmountSnapshot { get; set; }

    public FertilizerNutrientAnalysisBasis AnalysisBasisSnapshot { get; set; }

    [Precision(10, 4)]
    public decimal GramsPerM2 { get; set; }

    [Precision(14, 3)]
    public decimal TotalGrams { get; set; }

    public required ApplicationPlanItem ApplicationPlanItem { get; set; }
    public Nutrient? Nutrient { get; set; }
}
