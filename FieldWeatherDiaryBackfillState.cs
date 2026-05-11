namespace AmsModels;

[Index(nameof(FieldId), IsUnique = true)]
[Index(nameof(Active), nameof(CompletedUtc), nameof(LastRunUtc))]
public class FieldWeatherDiaryBackfillState
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FieldWeatherDiaryBackfillStateId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public Field Field { get; set; } = null!;

    [Required]
    public DateTime RequestedAtUtc { get; set; } = DateTime.UtcNow;

    [Required]
    public DateTime MinDateUtc { get; set; }

    [Required]
    public DateTime NextToUtc { get; set; }

    public DateTime? CompletedUtc { get; set; }

    [Required]
    [MaxLength(32)]
    public string LogicVersion { get; set; } = "weather-diary-v1";

    public DateTime? LastRunUtc { get; set; }

    [MaxLength(2000)]
    public string? LastError { get; set; }

    [Required]
    public bool Active { get; set; } = true;
}
