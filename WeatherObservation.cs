namespace AmsModels;

public enum WeatherObservationSourceType : short
{
    Observed = 0,
    ForecastOneCall = 1,
    Forecast5Tail = 2,
    Interpolated = 3,
    Computed = 4
}

[Index(nameof(FieldId), nameof(ObservedAtUtc), IsUnique = true)]
[Index(nameof(FieldId))]
[Index(nameof(ObservedAtUtc))]
[Index(nameof(SourceType))]
public class WeatherObservation
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public Field Field { get; set; } = null!;

    [Required]
    public DateTime ObservedAtUtc { get; set; }

    [Column(TypeName = "decimal(5,2)")]
    public decimal TempC { get; set; }

    [Range(0, 100)]
    public short RelativeHumidity { get; set; }

    public short PressureHPa { get; set; }

    [Column(TypeName = "decimal(6,2)")]
    public decimal WindSpeedMs { get; set; }

    [Range(0, 360)]
    public short? WindDeg { get; set; }

    [Column(TypeName = "decimal(6,2)")]
    public decimal? WindGustMs { get; set; }

    [Range(0, 100)]
    public short? CloudPct { get; set; }

    [Column(TypeName = "decimal(6,2)")]
    public decimal? RainMm1h { get; set; }

    [Column(TypeName = "decimal(6,2)")]
    public decimal? SnowMm1h { get; set; }

    public int? WeatherCode { get; set; }

    [MaxLength(32)]
    public string? WeatherMain { get; set; }

    [MaxLength(64)]
    public string? Source { get; set; }

    [Required]
    public WeatherObservationSourceType SourceType { get; set; } = WeatherObservationSourceType.Observed;

    public DateTime? SourceGeneratedAtUtc { get; set; }

    [Required]
    public bool IsImputed { get; set; }

    [MaxLength(32)]
    public string? ImputationMethod { get; set; }

    [Required]
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
}
