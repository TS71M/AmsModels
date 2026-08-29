namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IrrigationSystemId), nameof(HydraulicNodeId), IsUnique = true)]
[Index(nameof(IrrigationSystemId), nameof(Active))]
public sealed class HydraulicSource
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int HydraulicSourceId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationSystemId { get; set; }
    public int HydraulicNodeId { get; set; }

    [MaxLength(160)]
    public string Name { get; set; } = "";

    [Precision(7, 3), Range(typeof(decimal), "0", "100")]
    public decimal AvailablePressureBar { get; set; }

    public bool Active { get; set; } = true;

    public required IrrigationSystem IrrigationSystem { get; set; }
    public required HydraulicNode HydraulicNode { get; set; }
}
