namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ResearchArticleId), nameof(CreatedUtc))]
[Index(nameof(ParentCommentId), nameof(CreatedUtc))]
[Index(nameof(UserId), nameof(CreatedUtc))]
public sealed class ResearchArticleComment
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long ResearchArticleCommentId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int ResearchArticleId { get; set; }
    public ResearchArticle ResearchArticle { get; set; } = null!;

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public long? ParentCommentId { get; set; }
    public ResearchArticleComment? ParentComment { get; set; }
    public ICollection<ResearchArticleComment> Replies { get; set; } = [];

    [Required, MaxLength(2000)]
    public string Content { get; set; } = "";

    [Required, MaxLength(16)]
    public string LanguageCode { get; set; } = "en";

    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedUtc { get; set; }
    public bool IsRemoved { get; set; }
    public DateTime? RemovedUtc { get; set; }
    public int? RemovedByUserId { get; set; }
    public User? RemovedByUser { get; set; }
}
