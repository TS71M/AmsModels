namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(LynxImportStationId))]
[Index(nameof(LynxImportStationId), nameof(PointNumber), IsUnique = true)]
public sealed class LynxImportMapPoint
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LynxImportMapPointId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int LynxImportStationId { get; set; }
    public int PointNumber { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public bool OnMap { get; set; }
    public bool Active { get; set; } = true;

    public required LynxImportStation LynxImportStation { get; set; }
}
