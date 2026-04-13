namespace AmsModels;

public partial class ConBil
{
    [Key]
    public int ConBilId { get; set; }
    public int ConBilNumId { get; set; }
    public int? AgrTaskWeekId { get; set; }
    public int ProductId { get; set; }
    public decimal Quantity { get; set; } = 0;
    public string AreaName { get; set; } = "";

    public virtual string QuantityL => Quantity + Product.UniWeiPackL;

    public AgrTaskWeek? AgrTaskWeek { get; set; }
    public required ConBilNum ConBilNum { get; set; }
    public required Product Product { get; set; }
}