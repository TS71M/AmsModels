namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(UserId))]
[Index(nameof(IbuId))]
[Index(nameof(OccuredUtc))]
public class LoginLog(
    int? ibuId,
    int? userId,
    DateTime occuredUtc,
    bool succeeded
)
{
    [Key]
    public int LoginLogId { get; set; }

    public Guid PubId { get; set; }
    public int? IbuId { get; set; } = ibuId;
    public int? UserId { get; set; } = userId;

    public DateTime OccuredUtc { get; set; } = occuredUtc;

    public bool Succeeded { get; set; } = succeeded;

    [MaxLength(32)]
    public string? FailureCode { get; set; }

    [MaxLength(45)]
    public string? IpAddress { get; set; }

    [MaxLength(512)]
    public string? UserAgent { get; set; }

    public Ibu? Ibu { get; set; }
    public User? User { get; set; }
}