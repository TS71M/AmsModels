namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IrrigationSystemId))]
[Index(nameof(IrrigationControllerId))]
[Index(nameof(IrrigationControlStationId))]
[Index(nameof(IrrigationSprinklerModelId))]
[Index(nameof(IrrigationSprinklerNozzleOptionId))]
[Index(nameof(IrrigationSystemId), nameof(Name), IsUnique = true)]
[Index(nameof(IrrigationSystemId), nameof(Active))]
[Index(nameof(IrrigationControlStationId), nameof(ControlStationPositionNumber), IsUnique = true)]
public sealed class IrrigationHead
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationHeadId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationSystemId { get; set; }
    public int? IrrigationControllerId { get; set; }
    public int? IrrigationControlStationId { get; set; }
    public int? IrrigationSprinklerModelId { get; set; }
    public int? IrrigationSprinklerNozzleOptionId { get; set; }

    [Required, MaxLength(160)]
    public string Name { get; set; } = "";

    [MaxLength(200)]
    public string HardwareAddress { get; set; } = "";

    public double? MapX { get; set; }
    public double? MapY { get; set; }

    [Range(1, int.MaxValue)]
    public int? ControlStationPositionNumber { get; set; }

    [Precision(10, 3)]
    public decimal? ElevationM { get; set; }

    [Precision(5, 1), Range(typeof(decimal), "0", "360")]
    public decimal? ArcDegrees { get; set; }

    [Precision(5, 1), Range(typeof(decimal), "0", "360")]
    public decimal? OrientationDegrees { get; set; }

    public bool Active { get; set; } = true;

    public required IrrigationSystem IrrigationSystem { get; set; }
    public IrrigationController? IrrigationController { get; set; }
    public IrrigationControlStation? ControlStation { get; set; }
    public IrrigationSprinklerModel? SprinklerModel { get; set; }
    public IrrigationSprinklerNozzleOption? SprinklerNozzle { get; set; }
    public ICollection<IrrigationAreaHead> AreaMemberships { get; set; } = [];
    public ICollection<IrrigationScenarioHeadSetting> ScenarioSettings { get; set; } = [];
    public ICollection<IrrigationCalibrationLayer> CalibrationLayers { get; set; } = [];
    public ICollection<IrrigationSourceReference> SourceReferences { get; set; } = [];
    public ICollection<HydraulicNode> HydraulicNodes { get; set; } = [];
    public SurfaceSprinkler? FieldObservation { get; set; }
}
