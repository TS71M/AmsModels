namespace AmsModels;

[Index(nameof(CompetitorFindingId), nameof(CreatedUtc))]
public sealed class CompetitorDiscussionMessage
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long CompetitorDiscussionMessageId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int CompetitorFindingId { get; set; }
    public CompetitorFinding CompetitorFinding { get; set; } = null!;

    public int? UserId { get; set; }
    public User? User { get; set; }

    [Required, MaxLength(20)]
    public string Role { get; set; } = "User";

    [Required, MaxLength(8000)]
    public string Content { get; set; } = "";

    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
}
