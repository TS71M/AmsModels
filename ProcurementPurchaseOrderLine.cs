namespace AmsModels;

[Index(nameof(ProcurementPurchaseOrderId), nameof(ProductId), IsUnique = true)]
public class ProcurementPurchaseOrderLine
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProcurementPurchaseOrderLineId { get; set; }
    public int ProcurementPurchaseOrderId { get; set; }
    public int ProductId { get; set; }
    public int? ProductSupplierId { get; set; }

    [Precision(18, 3)]
    public decimal QuantityOrdered { get; set; }

    [Precision(18, 2)]
    public decimal UnitPrice { get; set; }

    [MaxLength(250)]
    public string ProductNameSnapshot { get; set; } = "";

    [MaxLength(100)]
    public string UnitLabelSnapshot { get; set; } = "";

    [MaxLength(100)]
    public string SupplierProductCodeSnapshot { get; set; } = "";

    [MaxLength(500)]
    public string Notes { get; set; } = "";

    public required ProcurementPurchaseOrder ProcurementPurchaseOrder { get; set; }
    public required Product Product { get; set; }
    public ProductSupplier? ProductSupplier { get; set; }
    public virtual ICollection<ProcurementReceiptLine> ReceiptLines { get; set; } = [];
}
