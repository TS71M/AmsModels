namespace AmsModels;

[Index(nameof(ProductId), nameof(SupplierId), IsUnique = true)]
public class ProductSupplier
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductSupplierId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int ProductId { get; set; }
    public int SupplierId { get; set; }

    [MaxLength(100)]
    [Display(Name = "Supplier Product Code")]
    public string SupplierProductCode { get; set; } = "";

    [Precision(18, 3)]
    [Display(Name = "Pack Size")]
    public decimal? PackSize { get; set; }

    [Precision(18, 2)]
    [Display(Name = "Unit Price")]
    public decimal? UnitPrice { get; set; }

    [MaxLength(3)]
    [Display(Name = "Currency")]
    public string CurrencyCode { get; set; } = "";

    [Display(Name = "Lead Time (days)")]
    public int? LeadTimeDays { get; set; }

    [Precision(18, 3)]
    [Display(Name = "Minimum Order Qty")]
    public decimal? MinimumOrderQty { get; set; }

    public bool IsPreferred { get; set; }
    public bool CanRequestPrice { get; set; } = true;
    public bool CanOrder { get; set; } = true;
    public bool IsActive { get; set; } = true;

    [MaxLength(500)]
    public string Notes { get; set; } = "";

    public string SupplierName => Supplier.SupNam;
    public string ProductName => Product.ProNam;

    public required Product Product { get; set; }
    public required Supplier Supplier { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = [];
    public virtual ICollection<PurchaseRequisitionLine> PurchaseRequisitionLines { get; set; } = [];
    public virtual ICollection<RequestPrice> RequestPrices { get; set; } = [];
}
