namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IrrigationAreaId), nameof(Active), nameof(CreatedUtc))]
[Index(nameof(IrrigationAreaId), nameof(Name))]
public sealed class IrrigationScenario
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationScenarioId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationAreaId { get; set; }

    [Required, MaxLength(160)]
    public string Name { get; set; } = "";

    [MaxLength(2000)]
    public string Description { get; set; } = "";

    [Precision(8, 3), Range(typeof(decimal), "0", "30")]
    public decimal DefaultRuntimeMinutes { get; set; }

    [Precision(8, 3), Range(typeof(decimal), "0.001", "100")]
    public decimal TargetDepthMm { get; set; }

    [Precision(6, 3), Range(typeof(decimal), "0.25", "2")]
    public decimal GridResolutionM { get; set; }

    [Precision(12, 4), Range(typeof(decimal), "0", "1000000")]
    public decimal MeanMm { get; set; }

    [Precision(8, 6), Range(typeof(decimal), "0", "1")]
    public decimal? DUlq { get; set; }

    [Precision(8, 6), Range(typeof(decimal), "0", "1")]
    public decimal? CU { get; set; }

    [Precision(12, 4), Range(typeof(decimal), "-1000000", "1000000")]
    public decimal TargetDeviation { get; set; }

    [Precision(7, 3), Range(typeof(decimal), "0", "100")]
    public decimal OutsideTargetPercent { get; set; }

    [Precision(12, 4), Range(typeof(decimal), "0", "1000000")]
    public decimal FlowM3H { get; set; }

    public DateTime CreatedUtc { get; set; }
    public int CreatedById { get; set; }
    public bool Active { get; set; } = true;

    public required IrrigationArea IrrigationArea { get; set; }
    public required User CreatedBy { get; set; }
    public ICollection<IrrigationScenarioHeadSetting> HeadSettings { get; set; } = [];
}
