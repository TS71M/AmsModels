namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(NonceHash), IsUnique = true)]
[Index(nameof(RemoteDeviceId), nameof(ExpiresAtUtc))]
public sealed class RemoteDeviceAuthenticationChallenge
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RemoteDeviceAuthenticationChallengeId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int RemoteDeviceId { get; set; }

    [Required, MaxLength(64)]
    public string NonceHash { get; set; } = "";

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime ExpiresAtUtc { get; set; }
    public DateTime? ConsumedAtUtc { get; set; }

    [ConcurrencyCheck]
    public Guid ConcurrencyStamp { get; set; } = Guid.NewGuid();

    public required RemoteDevice RemoteDevice { get; set; }
}
