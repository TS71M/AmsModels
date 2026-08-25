using Lib.Enums;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(PublicKey), IsUnique = true)]
[Index(nameof(IbuId), nameof(DeletedAtUtc))]
[Index(nameof(FieldId), nameof(DeletedAtUtc))]
[Index(nameof(LastSeenAtUtc))]
public sealed class RemoteDevice
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RemoteDeviceId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int IbuId { get; set; }

    public int? FieldId { get; set; }

    [Required, MaxLength(120)]
    public string DisplayName { get; set; } = "";

    [Required, MaxLength(120)]
    public string MachineName { get; set; } = "";

    [Required, MaxLength(32)]
    public string Platform { get; set; } = "Windows";

    [Required, MaxLength(64)]
    public string OperatingSystem { get; set; } = "Windows";

    [MaxLength(64)]
    public string? OperatingSystemVersion { get; set; }

    [Required, MaxLength(32)]
    public string AgentVersion { get; set; } = "";

    [MaxLength(2048)]
    public string? PublicKey { get; set; }

    [Required]
    public RemoteAccess.DeviceAccessMode AccessMode { get; set; } = RemoteAccess.DeviceAccessMode.AttendedOnly;

    [Required]
    public bool Enabled { get; set; } = true;

    [Required]
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public DateTime? LastSeenAtUtc { get; set; }
    public DateTime? DeletedAtUtc { get; set; }

    public Ibu Ibu { get; set; } = null!;
    public Field? Field { get; set; }
    public ICollection<RemoteDevicePermission> Permissions { get; set; } = [];
    public ICollection<RemoteDeviceAuthenticationChallenge> AuthenticationChallenges { get; set; } = [];
    public ICollection<RemoteDeviceEnrollment> ConsumedEnrollments { get; set; } = [];
}
