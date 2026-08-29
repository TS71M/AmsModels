namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IrrigationSystemId), nameof(Code), IsUnique = true)]
[Index(nameof(StartNodeId))]
[Index(nameof(EndNodeId))]
[Index(nameof(IrrigationSystemId), nameof(Active))]
public sealed class HydraulicPipe
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int HydraulicPipeId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationSystemId { get; set; }
    public int StartNodeId { get; set; }
    public int EndNodeId { get; set; }

    [Required, MaxLength(80)]
    public string Code { get; set; } = "";

    [Precision(12, 3), Range(typeof(decimal), "0.001", "1000000")]
    public decimal LengthM { get; set; }

    [Precision(10, 3), Range(typeof(decimal), "0.001", "10000")]
    public decimal InternalDiameterMm { get; set; }

    [Precision(10, 6), Range(typeof(decimal), "0", "100")]
    public decimal AbsoluteRoughnessMm { get; set; }

    [MaxLength(80)]
    public string MaterialCode { get; set; } = "";

    public bool Active { get; set; } = true;

    public required IrrigationSystem IrrigationSystem { get; set; }
    public required HydraulicNode StartNode { get; set; }
    public required HydraulicNode EndNode { get; set; }
}
