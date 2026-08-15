namespace AmsModels;

[Index(nameof(ProcurementQuoteId), nameof(ProductId), IsUnique = true)]
public sealed class ProcurementQuoteLine
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProcurementQuoteLineId { get; set; }
    public int ProcurementQuoteId { get; set; }
    public int ProductId { get; set; }

    [Precision(18, 3)]
    public decimal Quantity { get; set; }

    [Precision(18, 2)]
    public decimal? UnitPrice { get; set; }

    [MaxLength(500)]
    public string Notes { get; set; } = "";

    public required ProcurementQuote ProcurementQuote { get; set; }
    public required Product Product { get; set; }
}
