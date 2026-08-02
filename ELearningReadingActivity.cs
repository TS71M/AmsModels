namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(UserId), nameof(PagePath), nameof(ActivityDateUtc), IsUnique = true)]
public sealed class ELearningReadingActivity
{
    [Key]
    public int ELearningReadingActivityId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int UserId { get; set; }

    [Required, MaxLength(256)]
    public string PagePath { get; set; } = "";

    [Required, MaxLength(256)]
    public string PageTitle { get; set; } = "";

    public int EngagedSeconds { get; set; }
    public int ReadingThresholdSeconds { get; set; }
    public int MaxScrollPercent { get; set; }
    public DateTime CompletedUtc { get; set; }

    [Column(TypeName = "date")]
    public DateTime ActivityDateUtc { get; set; }

    public User User { get; set; } = null!;
}
