namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(UserId), nameof(SectionSlug), nameof(CompletedUtc))]
public sealed class ELearningQuizAttempt
{
    [Key]
    public int ELearningQuizAttemptId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int UserId { get; set; }

    [Required, MaxLength(64)]
    public string SectionSlug { get; set; } = "";

    [Required, MaxLength(1000)]
    public string QuestionStateJson { get; set; } = "[]";

    [MaxLength(4000)]
    public string? AnswersJson { get; set; }

    public DateTime StartedUtc { get; set; }
    public DateTime? CompletedUtc { get; set; }
    public int? Score { get; set; }
    public bool Passed { get; set; }

    [MaxLength(16)]
    public string? Medal { get; set; }

    public User User { get; set; } = null!;
}
