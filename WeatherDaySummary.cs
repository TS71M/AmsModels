namespace AmsModels;

// One row per field per day
[Index(nameof(FieldId), nameof(DayUtc), IsUnique = true)]
[Index(nameof(FieldId))]
[Index(nameof(DayUtc))]
public class WeatherDaySummary
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public Field Field { get; set; } = null!;

    // date-only (UTC)
    [Required]
    [Column(TypeName = "date")]
    public DateTime DayUtc { get; set; }

    [Column(TypeName = "decimal(5,2)")]
    public decimal? TempMinC { get; set; }

    [Column(TypeName = "decimal(5,2)")]
    public decimal? TempMaxC { get; set; }

    [Column(TypeName = "decimal(5,2)")]
    public decimal? TempMeanC { get; set; }

    [Column(TypeName = "decimal(6,2)")]
    public decimal? PrecipMm { get; set; }

    [Range(0, 100)]
    public short? HumidityMeanPct { get; set; }

    [MaxLength(64)]
    public string? Source { get; set; } = "openweathermap";

    [Required]
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    [Required]
    public DateTime UpdatedAtUtc { get; set; } = DateTime.UtcNow;
}
