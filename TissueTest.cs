namespace AmsModels;

public partial class TissueTest
{
    [Key]
    public int TissueTestId { get; set; }
    public int AreaId { get; set; }
    public DateTime TissueTestDate { get; set; }
    //public decimal N { get; set; }
    //public decimal P { get; set; }
    //public decimal K { get; set; }
    //public decimal Mg { get; set; }
    //public decimal Ca { get; set; }
    //public decimal Zn { get; set; }
    //public decimal Cu { get; set; }
    //public decimal Mn { get; set; }
    //public decimal Fe { get; set; }
    //public decimal B { get; set; }

    public required Area Area { get; set; }

    public virtual ICollection<TissueTestChem> TissueTestChems { get; set; } = [];
}