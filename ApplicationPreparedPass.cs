using Lib.Enums;

namespace AmsModels;

/// <summary>Stable identity for prepared versions of one planned physical pass.</summary>
public sealed class ApplicationPreparedPass
{
    public int ApplicationPreparedPassId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int IbuId { get; set; }
    public int FieldId { get; set; }
    public int AnnualApplicationPlanId { get; set; }
    public int ApplicationPlanPassId { get; set; }
    public int CreatedByUserId { get; set; }
    public DateTime CreatedAtUtc { get; set; }

    public required Ibu Ibu { get; set; }
    public required Field Field { get; set; }
    public required AnnualApplicationPlan AnnualApplicationPlan { get; set; }
    public required ApplicationPlanPass ApplicationPlanPass { get; set; }
    public required User CreatedByUser { get; set; }
    public ICollection<ApplicationPreparedPassRevision> Revisions { get; set; } = [];
}

/// <summary>
/// Deterministic recipe snapshot. RecipeJson is never edited; signing only adds
/// the accountable confirmations that allow execution events to start.
/// </summary>
public sealed class ApplicationPreparedPassRevision
{
    public const int RecipeCapacity = 200000;
    public int ApplicationPreparedPassRevisionId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int ApplicationPreparedPassId { get; set; }
    public int RevisionNumber { get; set; }
    public ApplicationPreparedPassRevisionStatus Status { get; set; } = ApplicationPreparedPassRevisionStatus.AwaitingSignature;
    public bool IsCurrent { get; set; } = true;
    public Guid SourcePlanRevisionPubId { get; set; }
    [MaxLength(64)] public string RecipeSha256 { get; set; } = "";
    [MaxLength(RecipeCapacity)] public string RecipeJson { get; set; } = "{}";
    [MaxLength(64000)] public string AssessmentJson { get; set; } = "{}";
    [MaxLength(16000)] public string SafetyConfirmationJson { get; set; } = "";
    public int PreparedByUserId { get; set; }
    public DateTime PreparedAtUtc { get; set; }
    public int? SignedByUserId { get; set; }
    public DateTime? SignedAtUtc { get; set; }
    public int? AssignedToUserId { get; set; }
    public DateTime? AssignedAtUtc { get; set; }
    public int? ReviewedByUserId { get; set; }
    public DateTime? ReviewedAtUtc { get; set; }
    public Guid? ApprovedExecutionPassPubId { get; set; }
    public Guid ConcurrencyToken { get; set; } = Guid.NewGuid();

    public required ApplicationPreparedPass ApplicationPreparedPass { get; set; }
    public required User PreparedByUser { get; set; }
    public User? SignedByUser { get; set; }
    public User? AssignedToUser { get; set; }
    public User? ReviewedByUser { get; set; }
    public ICollection<ApplicationPreparedPassEvent> Events { get; set; } = [];
}

/// <summary>Append-only, idempotent applicator event.</summary>
public sealed class ApplicationPreparedPassEvent
{
    public int ApplicationPreparedPassEventId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int ApplicationPreparedPassRevisionId { get; set; }
    public Guid ClientEventId { get; set; }
    public ApplicationPreparedPassEventType EventType { get; set; }
    public DateTime OccurredAtUtc { get; set; }
    [MaxLength(16000)] public string PayloadJson { get; set; } = "{}";
    public int RecordedByUserId { get; set; }
    public DateTime RecordedAtUtc { get; set; }

    public required ApplicationPreparedPassRevision ApplicationPreparedPassRevision { get; set; }
    public required User RecordedByUser { get; set; }
}
