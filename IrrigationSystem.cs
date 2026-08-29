namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuId))]
[Index(nameof(IbuId), nameof(Name), IsUnique = true)]
[Index(nameof(IbuId), nameof(Active))]
public sealed class IrrigationSystem
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationSystemId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IbuId { get; set; }

    [Required, MaxLength(160)]
    public string Name { get; set; } = "";

    [MaxLength(2000)]
    public string Description { get; set; } = "";

    [MaxLength(120)]
    public string Manufacturer { get; set; } = "";

    [MaxLength(160)]
    public string ControlSystem { get; set; } = "";

    [MaxLength(120)]
    public string SourceSystem { get; set; } = "";

    [Required, MaxLength(40)]
    public string HydraulicCalculationMethodCode { get; set; } = "DARCY_WEISBACH";

    [Precision(6, 3), Range(typeof(decimal), "0", "100")]
    public decimal? HydraulicDesignPressureBar { get; set; }

    [Precision(7, 3), Range(typeof(decimal), "0.001", "100")]
    public decimal? HydraulicVelocityWarningThresholdMS { get; set; }

    public bool Active { get; set; } = true;

    public required Ibu Ibu { get; set; }
    public ICollection<IrrigationController> Controllers { get; set; } = [];
    public ICollection<IrrigationHead> Heads { get; set; } = [];
    public ICollection<IrrigationArea> Areas { get; set; } = [];
    public ICollection<IrrigationSourceReference> SourceReferences { get; set; } = [];
    public ICollection<HydraulicNode> HydraulicNodes { get; set; } = [];
    public ICollection<HydraulicPipe> HydraulicPipes { get; set; } = [];
    public ICollection<HydraulicSource> HydraulicSources { get; set; } = [];
}
