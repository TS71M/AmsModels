namespace AmsModels;

[Index(nameof(FieldId), nameof(ForecastForUtc), IsUnique = true)]
public class WeatherForecastHour
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public Field Field { get; set; } = null!;

    [Required]
    public DateTime ForecastForUtc { get; set; }

    [Required]
    public DateTime GeneratedAtUtc { get; set; }

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

    // Probability of precipitation 0.00 .. 1.00
    [Column(TypeName = "decimal(3,2)")]
    public decimal? Pop { get; set; }

    public int? WeatherCode { get; set; }

    [MaxLength(32)]
    public string? WeatherMain { get; set; }

    [MaxLength(64)]
    public string? Source { get; set; }

    [Required]
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public static bool IsInterpolated { get; set; } = false;
}