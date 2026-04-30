namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(AnnualApplicationPlanId), nameof(Type), nameof(DetectedAt))]
public class PlanTriggerEvent
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PlanTriggerEventId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int AnnualApplicationPlanId { get; set; }

    public ApplicationTriggerType Type { get; set; }
    public ApplicationTriggerSeverity Severity { get; set; } = ApplicationTriggerSeverity.Info;
    public PlanTriggerStatus Status { get; set; } = PlanTriggerStatus.Suggested;
    public DateTime DetectedAt { get; set; } = DateTime.UtcNow;

    [MaxLength(2000)]
    public string SuggestedAction { get; set; } = "";

    [MaxLength(2000)]
    public string Reason { get; set; } = "";

    [MaxLength(4000)]
    public string ContextJson { get; set; } = "";

    public required AnnualApplicationPlan AnnualApplicationPlan { get; set; }
    public virtual ICollection<PlanTriggerAffectedApplication> AffectedApplications { get; set; } = [];
}
