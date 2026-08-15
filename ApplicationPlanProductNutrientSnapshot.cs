using Lib.Planning;

namespace AmsModels;

[Index(nameof(ApplicationPlanProductSnapshotId), nameof(NutrientCode), IsUnique = true)]
public sealed class ApplicationPlanProductNutrientSnapshot
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationPlanProductNutrientSnapshotId { get; set; }

    [Required]
    public int ApplicationPlanProductSnapshotId { get; set; }

    public Guid? SourceNutrientPubId { get; set; }

    [Required, MaxLength(20)]
    public string NutrientCode { get; set; } = "";

    [Required, MaxLength(120)]
    public string NutrientName { get; set; } = "";

    [Precision(10, 4)]
    public decimal AnalysisAmount { get; set; }

    public FertilizerNutrientAnalysisBasis AnalysisBasis { get; set; }

    [MaxLength(250)]
    public string AnalysisSource { get; set; } = "";

    public bool IsVerified { get; set; }

    public required ApplicationPlanProductSnapshot ApplicationPlanProductSnapshot { get; set; }
}
