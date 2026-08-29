namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IrrigationSystemId), nameof(Code), IsUnique = true)]
[Index(nameof(IrrigationSystemId), nameof(IrrigationHeadId), IsUnique = true)]
[Index(nameof(IrrigationSystemId), nameof(Active))]
public sealed class HydraulicNode
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int HydraulicNodeId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationSystemId { get; set; }
    public int? IrrigationHeadId { get; set; }

    [Required, MaxLength(80)]
    public string Code { get; set; } = "";

    [Required, MaxLength(40)]
    public string NodeTypeCode { get; set; } = "";

    [MaxLength(160)]
    public string Name { get; set; } = "";

    [Precision(10, 3)]
    public decimal ElevationM { get; set; }

    public bool Active { get; set; } = true;

    public required IrrigationSystem IrrigationSystem { get; set; }
    public IrrigationHead? IrrigationHead { get; set; }
    public ICollection<HydraulicPipe> OutgoingPipes { get; set; } = [];
    public ICollection<HydraulicPipe> IncomingPipes { get; set; } = [];
    public ICollection<HydraulicSource> Sources { get; set; } = [];
}
