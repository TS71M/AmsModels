namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(FieldId), nameof(SampledAtUtc))]
[Index(nameof(AreaId), nameof(SampledAtUtc))]
[Index(nameof(SurfaceId), nameof(SampledAtUtc))]
public sealed class LeafNitrateMeasurement
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LeafNitrateMeasurementId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IbuId { get; set; }
    public int FieldId { get; set; }
    public int AreaId { get; set; }
    public int? SurfaceId { get; set; }
    public int? CreatedByUserId { get; set; }

    public DateTime SampledAtUtc { get; set; }
    public DateTime RecordedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAtUtc { get; set; }

    [Required, MaxLength(32)]
    public string Source { get; set; } = "MobileApp";

    [Required, MaxLength(80)]
    public string DeviceModel { get; set; } = "HORIBA LAQUAtwin NO3-11";

    [Required, MaxLength(64)]
    public string SampleMethod { get; set; } = "MowerCatchBoxClippings";

    [Required, MaxLength(32)]
    public string SampleCondition { get; set; } = "Dry";

    public bool RecentlyIrrigated { get; set; }
    public bool RecentlyRained { get; set; }
    public bool DewRemoved { get; set; }

    public DateTime? CalibrationAtUtc { get; set; }

    [Precision(10, 2)]
    public decimal? CalibrationLowPpmNo3 { get; set; }

    [Precision(10, 2)]
    public decimal? CalibrationHighPpmNo3 { get; set; }

    [Precision(5, 2)]
    public decimal? SampleTemperatureC { get; set; }

    [MaxLength(1000)]
    public string? Notes { get; set; }

    public bool Active { get; set; } = true;

    public Ibu Ibu { get; set; } = null!;
    public Field Field { get; set; } = null!;
    public Area Area { get; set; } = null!;
    public Surface? Surface { get; set; }
    public User? CreatedByUser { get; set; }
    public ICollection<LeafNitrateReading> Readings { get; set; } = [];
}
