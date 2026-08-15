using Lib.Enums;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(PurchaseRequisitionId), nameof(CreatedDt))]
public sealed class PurchaseRequisitionEvent
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PurchaseRequisitionEventId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int PurchaseRequisitionId { get; set; }
    public int? ActorUserId { get; set; }
    public ProcurementEventType EventType { get; set; }
    public PurchaseRequisitionStatus? FromStatus { get; set; }
    public PurchaseRequisitionStatus? ToStatus { get; set; }
    public bool IsAutomatic { get; set; }
    public DateTime CreatedDt { get; set; } = DateTime.UtcNow;

    [MaxLength(1000)]
    public string Note { get; set; } = "";

    public required PurchaseRequisition PurchaseRequisition { get; set; }
    public User? ActorUser { get; set; }
}
