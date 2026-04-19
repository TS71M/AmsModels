namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(PurchaseRequisitionId), nameof(ProductId))]
public class PurchaseRequisitionLine
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PurchaseRequisitionLineId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int PurchaseRequisitionId { get; set; }
    public int ProductId { get; set; }
    public int? PreferredProductSupplierId { get; set; }

    [Precision(18, 3)]
    public decimal Quantity { get; set; }

    [MaxLength(500)]
    public string Notes { get; set; } = "";

    public required PurchaseRequisition PurchaseRequisition { get; set; }
    public required Product Product { get; set; }
    public ProductSupplier? PreferredProductSupplier { get; set; }
}
