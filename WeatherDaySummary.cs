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

    // Evidence metadata keeps daily calculations reproducible when observations,
    // interpolations, and forecast-derived gap fills coexist in the hourly table.
    public short? ObservedHourCount { get; set; }

    public short? ImputedHourCount { get; set; }

    public short? ForecastDerivedHourCount { get; set; }

    [MaxLength(32)]
    public string? Quality { get; set; }

    [MaxLength(32)]
    public string? AggregationVersion { get; set; }

    [Required]
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    [Required]
    public DateTime UpdatedAtUtc { get; set; } = DateTime.UtcNow;
}
