namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ClientIbuId), nameof(OperationId), IsUnique = true)]
[Index(nameof(State), nameof(EffectiveAtUtc))]
public class IbuManagementTransition
{
    [Key] public int IbuManagementTransitionId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public Guid OperationId { get; set; }
    public int ClientIbuId { get; set; }
    public int ApprovedByUserId { get; set; }
    public DateTime ApprovedAtUtc { get; set; }
    public DateTime EffectiveAtUtc { get; set; }
    public DateTime? AppliedAtUtc { get; set; }
    public DateTime? ReviewRequiredAtUtc { get; set; }
    public DateTime? CancelledAtUtc { get; set; }
    public int? CancelledByUserId { get; set; }
    [MaxLength(1000)] public string ChangeSummary { get; set; } = "";
    [MaxLength(24)] public string State { get; set; } = "Scheduled";
    [MaxLength(500)] public string Reason { get; set; } = "";
    [MaxLength(64)] public string RequestHash { get; set; } = "";
    [MaxLength(64)] public string BaselineHash { get; set; } = "";
    [MaxLength(32768)] public string RequestJson { get; set; } = "";
    [MaxLength(65536)] public string ReviewJson { get; set; } = "";
    [ConcurrencyCheck] public Guid Version { get; set; } = Guid.NewGuid();
    public Ibu ClientIbu { get; set; } = null!;
    public User ApprovedByUser { get; set; } = null!;
    public ICollection<IbuProductHandover> Products { get; set; } = [];
}

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(SourceIbuId), nameof(CreatedProductPubId), nameof(RejectedAtUtc))]
[Index(nameof(DestinationIbuId), nameof(CreatedProductPubId), nameof(RejectedAtUtc))]
public class IbuProductHandover
{
    [Key] public int IbuProductHandoverId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int IbuManagementTransitionId { get; set; }
    public int SourceIbuId { get; set; }
    public int DestinationIbuId { get; set; }
    public Guid SourceProductPubId { get; set; }
    public DateTime CapturedAtUtc { get; set; } = DateTime.UtcNow;
    [MaxLength(16384)] public string DecisionHistoryJson { get; set; } = "[]";
    [MaxLength(250)] public string TargetName { get; set; } = "";
    public bool IncludePrice { get; set; }
    [MaxLength(64)] public string SnapshotHash { get; set; } = "";
    [MaxLength(65536)] public string SnapshotJson { get; set; } = "";
    public int? SourceApprovedByUserId { get; set; }
    public DateTime? SourceApprovedAtUtc { get; set; }
    public int? DestinationApprovedByUserId { get; set; }
    public DateTime? DestinationApprovedAtUtc { get; set; }
    public int? RejectedByUserId { get; set; }
    public DateTime? RejectedAtUtc { get; set; }
    [MaxLength(500)] public string Reason { get; set; } = "";
    public Guid? CreatedProductPubId { get; set; }
    [ConcurrencyCheck] public Guid Version { get; set; } = Guid.NewGuid();
    public IbuManagementTransition Transition { get; set; } = null!;
    public Ibu SourceIbu { get; set; } = null!;
    public Ibu DestinationIbu { get; set; } = null!;
}
