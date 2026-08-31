namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IrrigationSystemId))]
[Index(nameof(IrrigationControllerId))]
[Index(nameof(IrrigationControlStationId))]
[Index(nameof(IrrigationHeadId))]
[Index(nameof(IrrigationSprinklerModelId))]
[Index(nameof(IrrigationSprinklerNozzleOptionId))]
[Index(nameof(IrrigationAreaId))]
[Index(nameof(IrrigationSystemId), nameof(SourceType), nameof(SourceEntityType), nameof(SourceReference), IsUnique = true)]
public sealed class IrrigationSourceReference
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationSourceReferenceId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationSystemId { get; set; }
    public int? IrrigationControllerId { get; set; }
    public int? IrrigationControlStationId { get; set; }
    public int? IrrigationHeadId { get; set; }
    public int? IrrigationSprinklerModelId { get; set; }
    public int? IrrigationSprinklerNozzleOptionId { get; set; }
    public int? IrrigationAreaId { get; set; }

    [Required, MaxLength(80)]
    public string SourceType { get; set; } = "";

    [Required, MaxLength(80)]
    public string SourceEntityType { get; set; } = "";

    [Required, MaxLength(300)]
    public string SourceReference { get; set; } = "";

    public bool Active { get; set; } = true;

    public required IrrigationSystem IrrigationSystem { get; set; }
    public IrrigationController? IrrigationController { get; set; }
    public IrrigationControlStation? IrrigationControlStation { get; set; }
    public IrrigationHead? IrrigationHead { get; set; }
    public IrrigationSprinklerModel? SprinklerModel { get; set; }
    public IrrigationSprinklerNozzleOption? SprinklerNozzle { get; set; }
    public IrrigationArea? IrrigationArea { get; set; }
}
