namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(AnnualApplicationPlanId), nameof(DeviationType))]
[Index(nameof(ApplicationPlanItemId))]
public class PlanDeviation
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PlanDeviationId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int AnnualApplicationPlanId { get; set; }

    public int? ApplicationPlanItemId { get; set; }
    public PlanDeviationType DeviationType { get; set; }

    [Precision(10, 3)]
    public decimal NutrientDelta { get; set; }

    [Precision(12, 2)]
    public decimal CostDelta { get; set; }

    [MaxLength(2000)]
    public string Reason { get; set; } = "";

    public int? ApprovedByUserId { get; set; }
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public required AnnualApplicationPlan AnnualApplicationPlan { get; set; }
    public ApplicationPlanItem? ApplicationPlanItem { get; set; }
    public User? ApprovedByUser { get; set; }
}
