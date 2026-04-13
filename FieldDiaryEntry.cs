namespace AmsModels;

[Index(nameof(FieldId), nameof(OccurredAtUtc))]
[Index(nameof(UniqueKey), IsUnique = true)]
public class FieldDiaryEntry
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FieldDiaryEntryId { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public int IbuId { get; set; }

    public int? CreatedByUserId { get; set; }

    [Required]
    public DateTime OccurredAtUtc { get; set; }

    [Required]
    public DateTime RecordedAtUtc { get; set; } = DateTime.UtcNow;

    [Required]
    [MaxLength(32)]
    public string Category { get; set; } = "";

    [Required]
    [MaxLength(64)]
    public string EventCode { get; set; } = "";

    [Required]
    [MaxLength(32)]
    public string Source { get; set; } = "";

    [Required]
    [MaxLength(16)]
    public string Severity { get; set; } = "info";

    [Required]
    [MaxLength(180)]
    public string Title { get; set; } = "";

    [Required]
    [MaxLength(2000)]
    public string Summary { get; set; } = "";

    public string? DetailsJson { get; set; }

    [MaxLength(32)]
    public string? RelatedRiskKey { get; set; }

    [MaxLength(32)]
    public string? RelatedEntityType { get; set; }

    public Guid? RelatedPubId { get; set; }

    [MaxLength(200)]
    public string? UniqueKey { get; set; }

    [Required]
    public bool Active { get; set; } = true;

    public Field Field { get; set; } = null!;
    public Ibu Ibu { get; set; } = null!;
    public User? CreatedByUser { get; set; }
}
