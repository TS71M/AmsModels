namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ProcurementPurchaseOrderId), nameof(ReceivedDt))]
public class ProcurementReceipt
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProcurementReceiptId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int ProcurementPurchaseOrderId { get; set; }
    public int ReceivedByUserId { get; set; }
    public DateTime ReceivedDt { get; set; } = DateTime.UtcNow;

    [MaxLength(100)]
    public string DeliveryReference { get; set; } = "";

    [MaxLength(1000)]
    public string Notes { get; set; } = "";

    public required ProcurementPurchaseOrder ProcurementPurchaseOrder { get; set; }
    public required User ReceivedByUser { get; set; }
    public virtual ICollection<ProcurementReceiptLine> Lines { get; set; } = [];
}
