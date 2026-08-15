using Lib.Planning;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(AnnualApplicationPlanId), nameof(PlannedDate))]
[Index(nameof(ApplicationPlanRevisionId), nameof(PlannedDate))]
[Index(nameof(ApplicationPlanRevisionId), nameof(ScheduleStatus), nameof(CurrentScheduledLocalDate))]
[Index(nameof(ApplicationPlanZoneId), nameof(PlannedLocalDate))]
[Index(nameof(ProductId))]
[Index(nameof(ApplicationPlanProductSnapshotId))]
[Index(nameof(MachineId))]
public class ApplicationPlanItem
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationPlanItemId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int AnnualApplicationPlanId { get; set; }

    [Required]
    public int ApplicationPlanRevisionId { get; set; }

    public int? ApplicationPlanZoneId { get; set; }

    public DateTime PlannedDate { get; set; }
    public DateOnly PlannedLocalDate { get; set; }
    public DateOnly CurrentScheduledLocalDate { get; set; }
    public ApplicationPlanItemScheduleStatus ScheduleStatus { get; set; } = ApplicationPlanItemScheduleStatus.Planned;
    public DateTime? ScheduleUpdatedAtUtc { get; set; }
    public ApplicationTriggerType TriggerType { get; set; } = ApplicationTriggerType.Calendar;

    public int? ProductId { get; set; }
    public int? ApplicationPlanProductSnapshotId { get; set; }
    public int? MachineId { get; set; }
    public ApplicationProductCategory ProductCategory { get; set; } = ApplicationProductCategory.Unknown;

    [MaxLength(250)]
    public string TargetProblem { get; set; } = "";

    [Precision(10, 3)]
    public decimal Rate { get; set; }

    public FertilizerApplicationRateUnit? RateUnit { get; set; }

    [Precision(12, 1)]
    public decimal TreatedAreaSnapshotM2 { get; set; }

    [Precision(12, 3)]
    public decimal PlannedProductQuantity { get; set; }

    public FertilizerProductQuantityUnit? PlannedProductQuantityUnit { get; set; }

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
    public required ApplicationPlanRevision ApplicationPlanRevision { get; set; }
    public ApplicationPlanZone? ApplicationPlanZone { get; set; }
    public Product? Product { get; set; }
    public ApplicationPlanProductSnapshot? ApplicationPlanProductSnapshot { get; set; }
    public Machine? Machine { get; set; }

    public virtual ICollection<ApplicationExecution> Executions { get; set; } = [];
    public virtual ICollection<ApplicationPlanItemScheduleEvent> ScheduleEvents { get; set; } = [];
    public virtual ICollection<PlanDeviation> Deviations { get; set; } = [];
    public virtual ICollection<PlanTriggerAffectedApplication> TriggerEvents { get; set; } = [];
    public virtual ICollection<ApplicationPlanItemNutrient> NutrientContributions { get; set; } = [];
}
