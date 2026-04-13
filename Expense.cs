namespace AmsModels;

public partial class Expense
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ExpenseId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int YearId { get; set; }
    public int MonthId { get; set; }
    public int AccountId { get; set; }
    public int AreaId { get; set; }
    public int? SupplierId { get; set; }

    [MaxLength(250)]
    public string ExpNum { get; set; } = "";

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Date")]
    public DateTime ExpDat { get; set; }

    [MaxLength(1000)]
    public string ExpDes { get; set; } = "";
    public decimal ExpAmo { get; set; }
    public bool System { get; set; }

    public virtual string SupplierName => Supplier?.SupNam ?? "no supplier selected";

    public required Account Account { get; set; }
    public required Area Area { get; set; }
    public required Month Month { get; set; }
    public Supplier? Supplier { get; set; }
    public required Year Year { get; set; }

}