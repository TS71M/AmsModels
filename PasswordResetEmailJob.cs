using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(UserId), nameof(RequestedUtc))]
[Index(nameof(Status), nameof(NextAttemptUtc))]
public sealed class PasswordResetEmailJob
{
    [Key]
    public int PasswordResetEmailJobId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int UserId { get; set; }

    public PasswordResetEmailJobStatus Status { get; set; } = PasswordResetEmailJobStatus.Queued;

    public DateTime RequestedUtc { get; set; }
    public DateTime ExpiresUtc { get; set; }
    public DateTime? NextAttemptUtc { get; set; }
    public DateTime? LastAttemptUtc { get; set; }
    public DateTime? SentUtc { get; set; }
    public DateTime? FailedUtc { get; set; }
    public DateTime? CancelledUtc { get; set; }

    public int AttemptCount { get; set; }

    [MaxLength(512)]
    public string? LastError { get; set; }

    public User? User { get; set; }
}

public enum PasswordResetEmailJobStatus
{
    Queued = 1,
    RetryScheduled = 2,
    Processing = 3,
    Sent = 4,
    Failed = 5,
    Cancelled = 6
}
