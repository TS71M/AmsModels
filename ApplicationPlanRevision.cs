namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(AnnualApplicationPlanId), nameof(RevisionNumber), IsUnique = true)]
public class ApplicationPlanRevision
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ApplicationPlanRevisionId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int AnnualApplicationPlanId { get; set; }

    [Range(1, int.MaxValue)]
    public int RevisionNumber { get; set; } = 1;

    public ApplicationPlanRevisionStatus Status { get; set; } = ApplicationPlanRevisionStatus.Draft;

    [Precision(12, 2)]
    public decimal BudgetTotal { get; set; }

    [MaxLength(4000)]
    public string StrategySummary { get; set; } = "";

    [MaxLength(4000)]
    public string NutrientTargetsJson { get; set; } = "";

    [MaxLength(4000)]
    public string ProductAllocationsJson { get; set; } = "";

    [MaxLength(32000)]
    public string EvidenceSnapshotJson { get; set; } = "";

    [MaxLength(1000)]
    public string ChangeSummary { get; set; } = "";

    public int? CreatedByUserId { get; set; }
    public int? ApprovedByUserId { get; set; }
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? ApprovedAtUtc { get; set; }

    public Guid? LastGridOperationId { get; set; }
    [MaxLength(64)]
    public string LastGridOperationHash { get; set; } = "";

    public required AnnualApplicationPlan AnnualApplicationPlan { get; set; }
    public virtual ICollection<ApplicationPlanAreaSnapshot> AreaSnapshots { get; set; } = [];
    public virtual ICollection<ApplicationPlanProductSnapshot> ProductSnapshots { get; set; } = [];
    public virtual ICollection<ApplicationPlanItem> PlannedApplications { get; set; } = [];
    public virtual ICollection<ApplicationExecution> Executions { get; set; } = [];
    public virtual ICollection<ApplicationPlanZone> Zones { get; set; } = [];
}
