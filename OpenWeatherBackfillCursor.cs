namespace AmsModels;

[Index(nameof(FieldId), IsUnique = true)]
[Index(nameof(Completed), nameof(NextDateUtc))]
public class OpenWeatherBackfillCursor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public Field Field { get; set; } = null!;

    // Next date we still need to fetch (date-only, UTC)
    [Required]
    [Column(TypeName = "date")]
    public DateTime NextDateUtc { get; set; }

    // Stop once NextDateUtc < MinDateUtc
    [Required]
    [Column(TypeName = "date")]
    public DateTime MinDateUtc { get; set; }

    [Required]
    public bool Completed { get; set; }

    [Required]
    public DateTime UpdatedAtUtc { get; set; } = DateTime.UtcNow;
}
