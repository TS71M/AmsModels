namespace AmsModels;

public partial class Inventory
{
    [Key]
    public int InvId { get; set; }
    public int InvNumId { get; set; }
    public int ProductId { get; set; }
    public decimal Quantity { get; set; }
    public decimal Stock { get; set; }

    public decimal Difference => Stock - Quantity;
    public string DifferenceL => Difference + Product.UniWeiPackL;
    public string StockL => Stock + Product.UniWeiPackL;
    public string QuantityL => Quantity + Product.UniWeiPackL;

    public required InvNum InvNum { get; set; }
    public required Product Product { get; set; }

}