namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ResearchArticleId), nameof(UserId), nameof(ReactionType), IsUnique = true)]
[Index(nameof(ResearchArticleId), nameof(ReactionType))]
[Index(nameof(UserId), nameof(CreatedUtc))]
public sealed class ResearchArticleReaction
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long ResearchArticleReactionId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int ResearchArticleId { get; set; }
    public ResearchArticle ResearchArticle { get; set; } = null!;

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    [Required, MaxLength(20)]
    public string ReactionType { get; set; } = "";

    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
}
