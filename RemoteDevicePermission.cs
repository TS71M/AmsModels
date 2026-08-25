namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(RemoteDeviceId), nameof(UserId), IsUnique = true)]
[Index(nameof(UserId), nameof(RevokedAtUtc))]
public sealed class RemoteDevicePermission
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RemoteDevicePermissionId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int RemoteDeviceId { get; set; }

    [Required]
    public int UserId { get; set; }

    public int? GrantedByUserId { get; set; }

    [Required]
    public bool CanView { get; set; }

    [Required]
    public bool CanControl { get; set; }

    [Required]
    public bool CanClipboard { get; set; }

    [Required]
    public bool CanUnattended { get; set; }

    [Required]
    public DateTime GrantedAtUtc { get; set; } = DateTime.UtcNow;

    public DateTime? RevokedAtUtc { get; set; }

    public RemoteDevice RemoteDevice { get; set; } = null!;
    public User User { get; set; } = null!;
    public User? GrantedByUser { get; set; }
}
