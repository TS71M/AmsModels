namespace AmsModels;

public partial class Order
{
    [Key]
    public int OrderId { get; set; }
    public int OrdNumId { get; set; }
    public int ProductId { get; set; }
    public int? ProductSupplierId { get; set; }
    public decimal Quantity { get; set; }
    public decimal Price { get; set; }

    [Display(Name = "Requested Quantity")]
    public decimal ReqQua { get; set; }

    [Display(Name = "Already Ordered Quantity")]
    public decimal AlrOrd { get; set; }

    public string QuantityL => $"{Quantity:N1} {Product.UniWeiPackL}";
    public decimal Total => Quantity * Price;

    public required Product Product { get; set; }
    public ProductSupplier? ProductSupplier { get; set; }
    public required OrdNum OrdNum { get; set; }
}
