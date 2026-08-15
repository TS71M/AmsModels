namespace AmsModels;

[Index(nameof(ProcurementReceiptId), nameof(ProcurementPurchaseOrderLineId), IsUnique = true)]
public sealed class ProcurementReceiptLine
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProcurementReceiptLineId { get; set; }
    public int ProcurementReceiptId { get; set; }
    public int ProcurementPurchaseOrderLineId { get; set; }

    [Precision(18, 3)]
    public decimal QuantityReceived { get; set; }

    [Precision(18, 3)]
    public decimal QuantityRejected { get; set; }

    [MaxLength(500)]
    public string DiscrepancyReason { get; set; } = "";

    public required ProcurementReceipt ProcurementReceipt { get; set; }
    public required ProcurementPurchaseOrderLine ProcurementPurchaseOrderLine { get; set; }
}
