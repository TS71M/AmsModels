namespace AmsModels;

// A historical surface design can replace models and need not have controller-linked heads.
public sealed class IrrigationDesignScenario
{
    public int IrrigationDesignScenarioId { get; set; }
    public Guid PubId { get; set; }
    public int SurfaceId { get; set; }
    [MaxLength(160)] public string Name { get; set; } = "";
    [MaxLength(160)] public string NameKey { get; set; } = "";
    [MaxLength(20)] public string Mode { get; set; } = "";
    [MaxLength(3000000)] public string SnapshotJson { get; set; } = "";
    public DateTime CreatedUtc { get; set; }
    public int CreatedById { get; set; }
    public Surface Surface { get; set; } = null!;
    public User CreatedBy { get; set; } = null!;
}
