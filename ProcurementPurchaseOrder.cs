using Lib.Enums;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuId), nameof(Status))]
[Index(nameof(FieldId), nameof(Status))]
[Index(nameof(OrderNumber), nameof(IbuId), IsUnique = true)]
public class ProcurementPurchaseOrder
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProcurementPurchaseOrderId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int PurchaseRequisitionId { get; set; }
    public int IbuId { get; set; }
    public int FieldId { get; set; }
    public int SupplierId { get; set; }
    public int CreatedByUserId { get; set; }
    public int? SelectedProcurementQuoteId { get; set; }
    public ProcurementPurchaseOrderStatus Status { get; set; } = ProcurementPurchaseOrderStatus.Draft;
    public ProcurementInventoryHandoffStatus InventoryHandoffStatus { get; set; } = ProcurementInventoryHandoffStatus.NotRequired;
    public DateTime CreatedDt { get; set; } = DateTime.UtcNow;
    public DateTime? PlacedDt { get; set; }
    public DateTime? ExpectedDeliveryDate { get; set; }
    public DateTime? ClosedDt { get; set; }

    [Required, MaxLength(100)]
    public string OrderNumber { get; set; } = "";

    [Required, MaxLength(3)]
    public string CurrencyCode { get; set; } = "";

    [MaxLength(500)]
    public string DeliveryLocation { get; set; } = "";

    [MaxLength(500)]
    public string Terms { get; set; } = "";

    [MaxLength(1000)]
    public string Notes { get; set; } = "";

    [ConcurrencyCheck]
    public Guid ConcurrencyToken { get; set; } = Guid.NewGuid();

    public required PurchaseRequisition PurchaseRequisition { get; set; }
    public required Ibu Ibu { get; set; }
    public required Field Field { get; set; }
    public required Supplier Supplier { get; set; }
    public required User CreatedByUser { get; set; }
    public ProcurementQuote? SelectedProcurementQuote { get; set; }
    public virtual ICollection<ProcurementPurchaseOrderLine> Lines { get; set; } = [];
    public virtual ICollection<ProcurementReceipt> Receipts { get; set; } = [];
}
