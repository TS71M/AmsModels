namespace AmsModels;

/// <summary>Durable acknowledgement of one committed grid operation.</summary>
public sealed class ApplicationPlanGridReceipt
{
    public int ApplicationPlanRevisionId { get; set; }
    public Guid OperationId { get; set; }
    [Required, MaxLength(64)] public string PayloadHash { get; set; } = "";
    public DateTime RecordedAtUtc { get; set; } = DateTime.UtcNow;
    public required ApplicationPlanRevision ApplicationPlanRevision { get; set; }
}
