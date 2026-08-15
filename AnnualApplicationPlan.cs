namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(FieldId), nameof(Year), nameof(NormalizedPlanName), IsUnique = true)]
public class AnnualApplicationPlan
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AnnualApplicationPlanId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int FieldId { get; set; }

    public int? AreaId { get; set; }

    [Range(1900, 2100)]
    public int Year { get; set; }

    [Required, MaxLength(120)]
    public string PlanName { get; set; } = "Plan 1";

    [Required, MaxLength(120)]
    public string NormalizedPlanName { get; set; } = "PLAN 1";

    [MaxLength(1000)]
    public string PlanPurpose { get; set; } = "";

    [Precision(12, 2)]
    public decimal BudgetTotal { get; set; }

    [MaxLength(4000)]
    public string StrategySummary { get; set; } = "";

    [MaxLength(4000)]
    public string NutrientTargetsJson { get; set; } = "";

    [MaxLength(4000)]
    public string ProductAllocationsJson { get; set; } = "";

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAtUtc { get; set; }

    public required Field Field { get; set; }
    public Area? Area { get; set; }

    public virtual ICollection<ApplicationPlanItem> PlannedApplications { get; set; } = [];
    public virtual ICollection<ApplicationPlanRevision> Revisions { get; set; } = [];
    public virtual ICollection<ApplicationExecution> Executions { get; set; } = [];
    public virtual ICollection<PlanDeviation> Deviations { get; set; } = [];
    public virtual ICollection<PlanTriggerEvent> TriggerEvents { get; set; } = [];
}
