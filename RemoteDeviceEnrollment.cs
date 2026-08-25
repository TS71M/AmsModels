namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(TokenHash), IsUnique = true)]
[Index(nameof(IbuId), nameof(ExpiresAtUtc))]
public sealed class RemoteDeviceEnrollment
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RemoteDeviceEnrollmentId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IbuId { get; set; }
    public int? FieldId { get; set; }
    public int CreatedByUserId { get; set; }

    [Required, MaxLength(64)]
    public string TokenHash { get; set; } = "";

    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime ExpiresAtUtc { get; set; }
    public DateTime? ConsumedAtUtc { get; set; }
    public DateTime? CancelledAtUtc { get; set; }
    public int? ConsumedByRemoteDeviceId { get; set; }

    [ConcurrencyCheck]
    public Guid ConcurrencyStamp { get; set; } = Guid.NewGuid();

    public required Ibu Ibu { get; set; }
    public Field? Field { get; set; }
    public required User CreatedByUser { get; set; }
    public RemoteDevice? ConsumedByRemoteDevice { get; set; }
}
