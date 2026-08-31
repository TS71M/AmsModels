namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IrrigationSystemId))]
[Index(nameof(IrrigationControllerId))]
[Index(nameof(IrrigationSystemId), nameof(ControllerNumber), nameof(StationNumber), IsUnique = true)]
public sealed class IrrigationControlStation
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationControlStationId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationSystemId { get; set; }
    public int? IrrigationControllerId { get; set; }

    [Required, MaxLength(160)]
    public string Name { get; set; } = "";

    [MaxLength(200)]
    public string HardwareAddress { get; set; } = "";

    [Range(0, int.MaxValue)]
    public int ControllerNumber { get; set; }

    [Range(0, int.MaxValue)]
    public int StationNumber { get; set; }

    public bool Active { get; set; } = true;

    public required IrrigationSystem IrrigationSystem { get; set; }
    public IrrigationController? IrrigationController { get; set; }
    public ICollection<IrrigationHead> Heads { get; set; } = [];
    public ICollection<IrrigationSourceReference> SourceReferences { get; set; } = [];
}
