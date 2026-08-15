namespace AmsModels;

[Index(nameof(SystemNoticeId), nameof(UserId), nameof(DeliveryKey), IsUnique = true)]
[Index(nameof(UserId), nameof(AcknowledgedAtUtc))]
public sealed class SystemNoticeDelivery
{
    [Key]
    public int SystemNoticeDeliveryId { get; set; }

    public int SystemNoticeId { get; set; }
    public int UserId { get; set; }
    public int? UserSessionId { get; set; }

    [Required, MaxLength(36)]
    public string DeliveryKey { get; set; } = "";

    public DateTime AcknowledgedAtUtc { get; set; }

    public SystemNotice? SystemNotice { get; set; }
    public User? User { get; set; }
    public UserSession? UserSession { get; set; }
}
