namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuId), nameof(AbsentUserId), nameof(ReplacementUserId), nameof(StartDate), nameof(EndDate))]
public sealed class UserTemporaryReplacement
{
    [Key]
    public int UserTemporaryReplacementId { get; set; }

    [Required]
    public Guid PubId { get; set; }

    [Required]
    public int IbuId { get; set; }

    [Required]
    public int AbsentUserId { get; set; }

    [Required]
    public int ReplacementUserId { get; set; }

    [Required]
    public DateOnly StartDate { get; set; }

    [Required]
    public DateOnly EndDate { get; set; }

    [MaxLength(250)]
    public string Reason { get; set; } = "";

    [Required]
    public bool Active { get; set; } = true;

    public Ibu Ibu { get; set; } = null!;
    public User AbsentUser { get; set; } = null!;
    public User ReplacementUser { get; set; } = null!;
}
