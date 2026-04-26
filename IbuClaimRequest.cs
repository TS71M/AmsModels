using Lib.Enums;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuId), nameof(Status))]
[Index(nameof(Email), nameof(Status))]
public class IbuClaimRequest
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IbuClaimRequestId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int IbuId { get; set; }

    public int? RequestedUserId { get; set; }

    [Required, MaxLength(256)]
    public string Email { get; set; } = "";

    [Required, MaxLength(500)]
    public string BusinessUnitName { get; set; } = "";

    public IbuClaimRequestStatus Status { get; set; } = IbuClaimRequestStatus.Pending;

    public DateTime RequestedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? DecidedAtUtc { get; set; }
    public int? DecidedByUserId { get; set; }

    [MaxLength(1000)]
    public string DecisionNotes { get; set; } = "";

    public required Ibu Ibu { get; set; }
    public User? RequestedUser { get; set; }
    public User? DecidedByUser { get; set; }
}
