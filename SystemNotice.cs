using Lib.Enums;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IsActive), nameof(StartsAtUtc), nameof(ExpiresAtUtc))]
public sealed class SystemNotice
{
    [Key]
    public int SystemNoticeId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(120)]
    public string Title { get; set; } = "";

    [Required, MaxLength(1000)]
    public string Message { get; set; } = "";

    public SystemNoticeDisplayMode DisplayMode { get; set; }
    public DateTime StartsAtUtc { get; set; }
    public DateTime? ExpiresAtUtc { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }
    public int CreatedByUserId { get; set; }

    public User? CreatedByUser { get; set; }
    public ICollection<SystemNoticeDelivery> Deliveries { get; set; } = [];
}
