namespace AmsModels;

public partial class PriInqNum
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PriInqNumId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int FieldId { get; set; }
    public int PriInqNumber { get; set; }
    public int YearId { get; set; }
    public DateTime PriInqNumDat { get; set; }
    public DateTime PriInqDelDat { get; set; }
    public bool PriInqClosed { get; set; }
    public DateTime ReqDate { get; set; }
    public DateTime ReqDelDate { get; set; }
    public bool RequestClosed { get; set; }
    public bool OrderCompleted { get; set; }
    public bool PriSurClosed { get; set; }

    public required Field Field { get; set; }
    public required Year Year { get; set; }

    public virtual ICollection<PriInq> PriInqs { get; set; } = [];
    public virtual ICollection<OrdNum> OrdNums { get; set; } = [];
    public virtual ICollection<RequestSupplier> RequestSuppliers { get; set; } = [];
}