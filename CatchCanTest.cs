namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuId), nameof(Active), nameof(TestDateUtc))]
[Index(nameof(IrrigationAreaId), nameof(Active), nameof(TestDateUtc))]
public sealed class CatchCanTest
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CatchCanTestId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IbuId { get; set; }
    public int IrrigationAreaId { get; set; }
    public int CreatedById { get; set; }
    public DateTime TestDateUtc { get; set; }

    [Range(1, 86400)]
    public int RuntimeSeconds { get; set; }

    [MaxLength(2000)]
    public string WeatherNotes { get; set; } = "";

    [Precision(8, 3), Range(typeof(decimal), "0", "100")]
    public decimal? WindSpeedMps { get; set; }

    [Precision(6, 2), Range(typeof(decimal), "0", "360")]
    public decimal? WindDirectionDegrees { get; set; }

    public bool Active { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public required Ibu Ibu { get; set; }
    public required IrrigationArea IrrigationArea { get; set; }
    public required User CreatedBy { get; set; }
    public ICollection<CatchCanMeasurement> Measurements { get; set; } = [];
    public IrrigationCalibrationLayer? CalibrationLayer { get; set; }
}
