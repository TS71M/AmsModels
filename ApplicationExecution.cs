namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(AnnualApplicationPlanId), nameof(ExecutedDate))]
[Index(nameof(ApplicationPlanItemId))]
[Index(nameof(ApplicationPlanRevisionId), nameof(ExecutedLocalDate))]
[Index(nameof(MachineId))]
public class ApplicationExecution
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationExecutionId { get; set; }
    // Nullable during rollout so older linked-record writers remain compatible.
    public int? FieldId { get; set; }
    public Field? Field { get; set; }
    public int? ApplicationExecutionPassId { get; set; }
    public ApplicationExecutionPass? ApplicationExecutionPass { get; set; }

    // Corrections append a successor; the original measurement remains intact.
    public int? ReplacesExecutionId { get; set; }
    public ApplicationExecution? ReplacesExecution { get; set; }
    public ApplicationExecution? Correction { get; set; }
    public bool IsVoided { get; set; }
    [MaxLength(1000)]
    public string CorrectionReason { get; set; } = "";
    public int? RecordedByUserId { get; set; }
    public User? RecordedByUser { get; set; }
    [Precision(9, 4)]
    public decimal? ProductDensityKgPerLSnapshot { get; set; }

    public Guid? SubmissionId { get; set; }
    [MaxLength(64)]
    public string SubmissionHash { get; set; } = "";

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int? AnnualApplicationPlanId { get; set; }

    public int? ApplicationPlanItemId { get; set; }
    public int? ApplicationPlanRevisionId { get; set; }
    public DateTime ExecutedDate { get; set; }
    public DateOnly ExecutedLocalDate { get; set; }
    public int? ActualProductId { get; set; }
    public int? MachineId { get; set; }

    public Guid? SourcePlanProductSnapshotPubId { get; set; }

    [MaxLength(250)]
    public string ActualProductNameSnapshot { get; set; } = "";

    public Guid? SourcePlanZonePubId { get; set; }

    [MaxLength(120)]
    public string ZoneNameSnapshot { get; set; } = "";

    public Guid? SourceMachinePubId { get; set; }

    [MaxLength(120)]
    public string MachineNameSnapshot { get; set; } = "";

    [Precision(12, 3)]
    public decimal? MachineCapacitySnapshot { get; set; }

    [MaxLength(40)]
    public string MachineCapacityUnitSnapshot { get; set; } = "";

    public DateOnly? MachineLastCalibratedOnSnapshot { get; set; }
    public DateOnly? MachineCalibrationDueOnSnapshot { get; set; }

    [Precision(10, 3)]
    public decimal ActualRate { get; set; }

    public Lib.Planning.FertilizerApplicationRateUnit? ActualRateUnit { get; set; }

    [Precision(12, 1)]
    public decimal TreatedAreaSnapshotM2 { get; set; }

    [Precision(12, 3)]
    public decimal ActualProductQuantity { get; set; }

    public Lib.Planning.FertilizerProductQuantityUnit? ActualProductQuantityUnit { get; set; }

    [Precision(12, 2)]
    public decimal ActualCost { get; set; }

    public bool CompletesPlannedApplication { get; set; } = true;

    [MaxLength(4000)]
    public string WeatherAtExecutionJson { get; set; } = "";

    [MaxLength(2000)]
    public string Notes { get; set; } = "";

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public AnnualApplicationPlan? AnnualApplicationPlan { get; set; }
    public ApplicationPlanRevision? ApplicationPlanRevision { get; set; }
    public ApplicationPlanItem? ApplicationPlanItem { get; set; }
    public Product? ActualProduct { get; set; }
    public Machine? Machine { get; set; }
    public virtual ICollection<ApplicationExecutionNutrient> NutrientContributions { get; set; } = [];
}
