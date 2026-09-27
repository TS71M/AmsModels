namespace AmsModels;

// Shared physical execution facts; product mass and nutrients stay on executions.
public sealed class ApplicationExecutionPass
{
    public int ApplicationExecutionPassId { get; set; }
    public int? FieldId { get; set; }
    public Field? Field { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int? AnnualApplicationPlanId { get; set; }
    public int? ApplicationPlanRevisionId { get; set; }
    public Guid? SourcePlanPassPubId { get; set; }
    public Guid SubmissionId { get; set; }
    [MaxLength(64)] public string SubmissionHash { get; set; } = "";
    public DateOnly ExecutedLocalDate { get; set; }
    public decimal TreatedAreaM2 { get; set; }
    public decimal? ActualCarrierVolumeLitres { get; set; }
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    // Immutable capture evidence, including selected surfaces and unknown inputs.
    [MaxLength(1000000)] public string CaptureEvidenceJson { get; set; } = "";
    public AnnualApplicationPlan? AnnualApplicationPlan { get; set; }
    public ApplicationPlanRevision? ApplicationPlanRevision { get; set; }
    public ICollection<ApplicationExecution> Executions { get; set; } = [];
}
