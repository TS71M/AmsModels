namespace AmsModels;

[Index(nameof(ResearchArticleId), nameof(CreatedUtc))]
public sealed class ResearchDiscussionMessage
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long ResearchDiscussionMessageId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int ResearchArticleId { get; set; }
    public ResearchArticle ResearchArticle { get; set; } = null!;

    public int? UserId { get; set; }
    public User? User { get; set; }

    [Required, MaxLength(20)]
    public string Role { get; set; } = "User";

    [Required, MaxLength(8000)]
    public string Content { get; set; } = "";

    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
}
