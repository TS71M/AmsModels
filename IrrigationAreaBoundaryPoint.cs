namespace AmsModels;

[Index(nameof(IrrigationAreaBoundaryId), nameof(Sequence), IsUnique = true)]
public sealed class IrrigationAreaBoundaryPoint
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationAreaBoundaryPointId { get; set; }

    public int IrrigationAreaBoundaryId { get; set; }
    public int Sequence { get; set; }

    public double X { get; set; }
    public double Y { get; set; }

    public required IrrigationAreaBoundary Boundary { get; set; }
}
