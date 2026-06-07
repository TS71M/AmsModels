namespace AmsModels;

[Index(nameof(Status), nameof(QueuedAtUtc))]
[Index(nameof(Status), nameof(StartedAtUtc))]
public class SurfaceCompositionRerunJob
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SurfaceCompositionRerunJobId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int SurfaceCompositionTransmissionId { get; set; }

    [Required]
    public int RequestedByUserId { get; set; }

    [Required, MaxLength(24)]
    public string Status { get; set; } = SurfaceCompositionRerunJobStatuses.Pending;

    public int Attempts { get; set; }

    [Required]
    public DateTime QueuedAtUtc { get; set; }

    public DateTime? StartedAtUtc { get; set; }

    public DateTime? CompletedAtUtc { get; set; }

    [Required]
    public DateTime UpdatedAtUtc { get; set; }

    [MaxLength(1000)]
    public string? LastError { get; set; }

    [ForeignKey(nameof(SurfaceCompositionTransmissionId))]
    public SurfaceCompositionTransmission Transmission { get; set; } = default!;

    [ForeignKey(nameof(RequestedByUserId))]
    public User RequestedByUser { get; set; } = default!;
}

public static class SurfaceCompositionRerunJobStatuses
{
    public const string Pending = "pending";
    public const string Running = "running";
    public const string Completed = "completed";
    public const string Failed = "failed";
}
