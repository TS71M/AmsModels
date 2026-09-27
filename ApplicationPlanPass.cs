namespace AmsModels;

// One physical pass owns shared preparation. Product rates and nutrient mass
// remain on the existing plan items; grouping is not tank-mix certification.
public sealed class ApplicationPlanPass
{
    public int ApplicationPlanPassId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public Guid? OriginPassPubId { get; set; }
    public int ApplicationPlanRevisionId { get; set; }
    public int ApplicationPlanZoneId { get; set; }
    [MaxLength(120)] public string Name { get; set; } = "";
    public DateOnly PlannedLocalDate { get; set; }
    public decimal TreatedAreaSnapshotM2 { get; set; }
    public decimal CarrierVolumeLitresPerHa { get; set; }
    public int? MachineId { get; set; }
    public Guid ConcurrencyToken { get; set; } = Guid.NewGuid();
    public required ApplicationPlanRevision ApplicationPlanRevision { get; set; }
    public required ApplicationPlanZone ApplicationPlanZone { get; set; }
    public Machine? Machine { get; set; }
    public ICollection<ApplicationPlanItem> Items { get; set; } = [];
}
