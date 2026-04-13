namespace AmsModels;

public partial class ProductChemical
{
    [Key]
    public int ProdChemId { get; set; }
    public int ProductId { get; set; }
    public int ChemId { get; set; }
    public decimal Quantity { get; set; }

    [ForeignKey(nameof(UniWei))]
    public int UniWeiId { get; set; }

    [ForeignKey(nameof(UniWeiPer))]
    public int UniWeiIdper { get; set; }

    public required Chemical Chem { get; set; }
    public required Product Product { get; set; }
    public required Unit UniWei { get; set; }
    public required Unit UniWeiPer { get; set; }

}