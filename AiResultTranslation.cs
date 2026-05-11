namespace AmsModels;

[Index(nameof(SourceEntityType), nameof(SourcePubId), nameof(CultureCode), IsUnique = true)]
[Index(nameof(CreatedAtUtc))]
public class AiResultTranslation
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AiResultTranslationId { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(64)]
    public string SourceEntityType { get; set; } = "";

    [Required]
    public Guid SourcePubId { get; set; }

    [Required, MaxLength(16)]
    public string CultureCode { get; set; } = "";

    [Required, MaxLength(16)]
    public string SourceCultureCode { get; set; } = "";

    [Required, MaxLength(64)]
    public string SourceContentHash { get; set; } = "";

    [MaxLength(80)]
    public string? ModelUsed { get; set; }

    [Required]
    public string PayloadJson { get; set; } = "";

    [Required]
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    [Required]
    public DateTime UpdatedAtUtc { get; set; } = DateTime.UtcNow;
}
