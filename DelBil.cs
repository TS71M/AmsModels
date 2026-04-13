namespace AmsModels;

public partial class DelBil
{
    [Key]
    public int DelBilId { get; set; }
    public int DelBilNumId { get; set; }

    [Display(Name = "Product")]
    public int ProductId { get; set; }
    public decimal Quantity { get; set; }

    [Display(Name = "Already Delivered")]
    public decimal AlrDel { get; set; }

    [Display(Name = "Not yet Delivered")]
    public decimal NotYetDelivered { get; set; }

    public string QuantityL => Quantity.ToString("N1") + Product.UniWeiPackL;
    public string AlrDelL => AlrDel.ToString("N1") + Product.UniWeiPackL;
    public string NotYetDeliveredL => NotYetDelivered.ToString("N1") + Product.UniWeiPackL;
    public decimal Ordered => DelBilNum.OrdNum.Orders.Where(o => o.ProductId == ProductId).Sum(o => o.Quantity);
    public string OrderedL => Ordered.ToString("N1") + Product?.UniWeiPackL;

    public required DelBilNum DelBilNum { get; set; }
    public required Product Product { get; set; }

}