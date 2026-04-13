namespace AmsModels;

public partial class RequestPrice
{
    [Key]
    public int RequestPriceId { get; set; }
    public int RequestSupplierId { get; set; }
    public int PriInqId { get; set; }
    public int? ProductSupplierId { get; set; }
    public decimal Price { get; set; }

    public ProductSupplier? ProductSupplier { get; set; }
    public required RequestSupplier RequestSupplier { get; set; }
    public required PriInq PriInq { get; set; }
}
