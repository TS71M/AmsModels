namespace AmsModels;

public partial class RequestSupplier
{
    [Key]
    public int RequestSupplierId { get; set; }
    public int PriInqNumId { get; set; }
    public int SupplierId { get; set; }

    public required PriInqNum PriInqNum { get; set; }
    public required Supplier Supplier { get; set; }

    public virtual ICollection<RequestPrice> RequestPrices { get; set; } = [];
}