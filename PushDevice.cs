namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(TokenHash), IsUnique = true)]
[Index(nameof(UserId))]
[Index(nameof(UserSessionId))]
[Index(nameof(DisabledUtc))]
public sealed class PushDevice
{
    [Key]
    public int PushDeviceId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int UserId { get; set; }
    public int? UserSessionId { get; set; }

    [Required, MaxLength(32)]
    public string Provider { get; set; } = "";

    [Required, MaxLength(32)]
    public string Platform { get; set; } = "";

    [Required, MaxLength(128)]
    public string TokenHash { get; set; } = "";

    [Required, MaxLength(4096)]
    public string Token { get; set; } = "";

    [MaxLength(128)]
    public string? DeviceId { get; set; }

    [MaxLength(120)]
    public string? DeviceName { get; set; }

    [MaxLength(32)]
    public string? AppVersion { get; set; }

    [MaxLength(32)]
    public string? BuildNumber { get; set; }

    public DateTime RegisteredUtc { get; set; }
    public DateTime LastSeenUtc { get; set; }
    public DateTime? DisabledUtc { get; set; }

    public User? User { get; set; }
    public UserSession? UserSession { get; set; }
}
