using Lib.Planning;

namespace AmsModels;

[Index(nameof(ApplicationExecutionId), nameof(NutrientCodeSnapshot), IsUnique = true)]
public sealed class ApplicationExecutionNutrient
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationExecutionNutrientId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int ApplicationExecutionId { get; set; }

    [Required, MaxLength(20)]
    public string NutrientCodeSnapshot { get; set; } = "";

    [Required, MaxLength(120)]
    public string NutrientNameSnapshot { get; set; } = "";

    [Precision(10, 4)]
    public decimal AnalysisAmountSnapshot { get; set; }

    public FertilizerNutrientAnalysisBasis AnalysisBasisSnapshot { get; set; }

    [Precision(10, 4)]
    public decimal GramsPerM2 { get; set; }

    [Precision(14, 3)]
    public decimal TotalGrams { get; set; }

    public required ApplicationExecution ApplicationExecution { get; set; }
}
