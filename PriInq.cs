namespace AmsModels;

public partial class PriInq
{
    [Key]
    public int PriInqId { get; set; }
    public int PriInqNumId { get; set; }
    public int ProductId { get; set; }
    public decimal Quantity { get; set; }

    public int IbuId => PriInqNum.FieldId;
    public int YearId => PriInqNum.YearId;
    public int Year => PriInqNum.Year.YearNumber;


    public required PriInqNum PriInqNum { get; set; }
    public required Product Product { get; set; }

    public virtual ICollection<RequestPrice> RequestPrices { get; set; } = [];

}