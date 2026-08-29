using Lib.Enums;

namespace AmsModels;

public sealed class IrrigationSprinklerNozzleOption
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationSprinklerNozzleOptionId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationSprinklerModelId { get; set; }
    public IrrigationNozzlePositionKind PositionKind { get; set; }

    [Required, MaxLength(80)]
    public string NozzleCode { get; set; } = "";

    [Required, MaxLength(160)]
    public string NozzleName { get; set; } = "";

    [Precision(10, 3), Range(typeof(decimal), "0", "10000")]
    public decimal? NominalFlowM3H { get; set; }

    [Precision(10, 2), Range(typeof(decimal), "0", "10000")]
    public decimal? NominalRadiusM { get; set; }

    [Precision(6, 2), Range(typeof(decimal), "0", "100")]
    public decimal? NominalPressureBar { get; set; }

    [MaxLength(80)]
    public string Color { get; set; } = "";

    [MaxLength(500)]
    public string? SourceUrl { get; set; }

    [MaxLength(500)]
    public string? ReferenceImageUrl { get; set; }

    [MaxLength(2000)]
    public string ReferenceNotes { get; set; } = "";

    public bool IsLegacy { get; set; }
    public bool Active { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public required IrrigationSprinklerModel SprinklerModel { get; set; }
    public ICollection<IrrigationNozzleConfigurationSlot> ConfigurationSlots { get; set; } = [];
    public ICollection<SurfaceSprinklerNozzle> InstalledNozzles { get; set; } = [];
    public ICollection<IrrigationHead> IrrigationHeads { get; set; } = [];
    public ICollection<IrrigationScenarioHeadSetting> ScenarioHeadSettings { get; set; } = [];
    public ICollection<IrrigationCalibrationLayer> CalibrationLayers { get; set; } = [];
    public ICollection<IrrigationSourceReference> IrrigationSourceReferences { get; set; } = [];
    public ICollection<SprinklerNozzlePerformance> PerformancePoints { get; set; } = [];
    public ICollection<SprinklerDistributionProfile> DistributionProfiles { get; set; } = [];
}
