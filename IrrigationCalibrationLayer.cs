namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuId), nameof(IrrigationAreaId), nameof(Active))]
[Index(nameof(SourceCatchCanTestId), IsUnique = true)]
[Index(nameof(IrrigationHeadId))]
[Index(nameof(IrrigationSprinklerNozzleOptionId))]
public sealed class IrrigationCalibrationLayer
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationCalibrationLayerId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IbuId { get; set; }
    public int IrrigationAreaId { get; set; }
    public int SourceCatchCanTestId { get; set; }
    public int? IrrigationHeadId { get; set; }
    public int? IrrigationSprinklerNozzleOptionId { get; set; }

    [Required, MaxLength(40)]
    public string ScopeCode { get; set; } = "AREA";

    [Precision(10, 6), Range(typeof(decimal), "0.05", "20")]
    public decimal ApplicationDepthMultiplier { get; set; } = 1m;

    [Precision(6, 3), Range(typeof(decimal), "0.001", "100")]
    public decimal? ReferencePressureBar { get; set; }

    [Range(1, 500)]
    public int MeasurementCount { get; set; }

    public bool Active { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }

    public required Ibu Ibu { get; set; }
    public required IrrigationArea IrrigationArea { get; set; }
    public required CatchCanTest SourceCatchCanTest { get; set; }
    public IrrigationHead? IrrigationHead { get; set; }
    public IrrigationSprinklerNozzleOption? SprinklerNozzle { get; set; }
}
