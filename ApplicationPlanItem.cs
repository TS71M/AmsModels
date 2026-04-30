namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(AnnualApplicationPlanId), nameof(PlannedDate))]
[Index(nameof(ProductId))]
public class ApplicationPlanItem
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationPlanItemId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int AnnualApplicationPlanId { get; set; }

    public DateTime PlannedDate { get; set; }
    public ApplicationTriggerType TriggerType { get; set; } = ApplicationTriggerType.Calendar;

    public int? ProductId { get; set; }
    public ApplicationProductCategory ProductCategory { get; set; } = ApplicationProductCategory.Unknown;

    [MaxLength(250)]
    public string TargetProblem { get; set; } = "";

    [Precision(10, 3)]
    public decimal Rate { get; set; }

    [Precision(10, 2)]
    public decimal WaterVolume { get; set; }

    [MaxLength(2000)]
    public string Instructions { get; set; } = "";

    [MaxLength(2000)]
    public string Reason { get; set; } = "";

    [MaxLength(2000)]
    public string Restrictions { get; set; } = "";

    public ApplicationValidationStatus ValidationStatus { get; set; } = ApplicationValidationStatus.PendingValidation;
    public bool IsBaseline { get; set; } = true;

    public required AnnualApplicationPlan AnnualApplicationPlan { get; set; }
    public Product? Product { get; set; }

    public virtual ICollection<ApplicationExecution> Executions { get; set; } = [];
    public virtual ICollection<PlanDeviation> Deviations { get; set; } = [];
    public virtual ICollection<PlanTriggerAffectedApplication> TriggerEvents { get; set; } = [];
}
