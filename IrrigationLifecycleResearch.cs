namespace AmsModels;

[Index(nameof(ResearchKey), IsUnique = true)]
[Index(nameof(State), nameof(UpdatedAtUtc))]
[Index(nameof(ManufacturerName), nameof(TargetKind), nameof(Identifier), nameof(CreatedAtUtc))]
public sealed class IrrigationLifecycleResearch
{
    [Key] public int IrrigationLifecycleResearchId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    [Required, MaxLength(64)] public string ResearchKey { get; set; } = "";
    [Required, MaxLength(120)] public string ManufacturerName { get; set; } = "";
    [Required, MaxLength(20)] public string TargetKind { get; set; } = "";
    [Required, MaxLength(160)] public string Identifier { get; set; } = "";
    [Required, MaxLength(20)] public string State { get; set; } = "Queued";
    [Required, MaxLength(20)] public string ProductionStatus { get; set; } = "Unknown";
    [MaxLength(1000)] public string ProductionSourceUrl { get; set; } = "";
    [Required, MaxLength(20)] public string AvailabilityStatus { get; set; } = "Unknown";
    [MaxLength(1000)] public string AvailabilitySourceUrl { get; set; } = "";
    [Required, MaxLength(20)] public string DocumentationStatus { get; set; } = "Unknown";
    [MaxLength(1000)] public string DocumentationSourceUrl { get; set; } = "";
    [MaxLength(2000)] public string EvidenceSummary { get; set; } = "";
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }
    public DateTime? CheckedAtUtc { get; set; }
    public DateTime? ReviewedAtUtc { get; set; }
    public int? ReviewedByUserId { get; set; }
    public Guid? ProcessingToken { get; set; }
}
