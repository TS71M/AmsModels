namespace AmsModels;

public sealed class GrassRecognitionObservation
{
    public int GrassRecognitionObservationId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int AreaId { get; set; }
    public int? SurfaceId { get; set; }
    public int SubmittedByUserId { get; set; }
    public Guid IdempotencyKey { get; set; }
    public string Mode { get; set; } = "composition";
    public string Status { get; set; } = "pending";
    public string ReviewStatus { get; set; } = "unreviewed";
    public int Version { get; set; } = 1;
    public int Attempts { get; set; }
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? ApprovedAtUtc { get; set; }
    public DateTime? ReopenedAtUtc { get; set; }
    public DateTime? LeaseUntilUtc { get; set; }
    public string PipelineVersion { get; set; } = "grass-evidence-v1";
    public string? ModelUsed { get; set; }
    public string SubmissionJson { get; set; } = "";
    public string? ResultJson { get; set; }
    public string? ReviewedResultJson { get; set; }
    public string? ReviewNote { get; set; }
    public string ReviewHistoryJson { get; set; } = "[]";
    public int? ReviewedByUserId { get; set; }
    public Area Area { get; set; } = null!;
    public Surface? Surface { get; set; }
    public User SubmittedByUser { get; set; } = null!;
    public ICollection<GrassRecognitionPhoto> Photos { get; set; } = [];
}

// Relational references protect submitted evidence from deletion while JSON records its role and hash.
public sealed class GrassRecognitionPhoto
{
    public int GrassRecognitionObservationId { get; set; }
    public int AreaCompositionPhotoId { get; set; }
    public string ContentHash { get; set; } = "";
    public GrassRecognitionObservation Observation { get; set; } = null!;
    public AreaCompositionPhoto Photo { get; set; } = null!;
}
