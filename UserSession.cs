namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(UserId))]
[Index(nameof(TokenHash), IsUnique = true)]
[Index(nameof(ExpiresUtc))]
public sealed class UserSession
{
    [Key]
    public int UserSessionId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int UserId { get; set; }

    [Required, MaxLength(128)]
    public string TokenHash { get; set; } = "";

    public DateTime CreatedUtc { get; set; }
    public DateTime ExpiresUtc { get; set; }
    public DateTime? LastUsedUtc { get; set; }
    public DateTime? RevokedUtc { get; set; }

    [MaxLength(45)]
    public string? IpAddress { get; set; }

    [MaxLength(512)]
    public string? UserAgent { get; set; }

    [MaxLength(120)]
    public string? DeviceName { get; set; }

    public User? User { get; set; }
}
