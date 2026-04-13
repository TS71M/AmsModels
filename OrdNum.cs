namespace AmsModels;

public partial class OrdNum
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrdNumId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int YearId { get; set; }
    public int? PriInqNumId { get; set; }
    public int SupplierId { get; set; }

    [Display(Name = "Order Number")]
    public int OrdNum1 { get; set; }

    [Display(Name = "Order Date")]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime OrdDat { get; set; }

    [Display(Name = "Delivery Date")]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime DelDat { get; set; }
    public bool Approved { get; set; }

    [Display(Name = "Order approved")]
    public bool OrdCom { get; set; }

    [Display(Name = "Delivery Completed")]
    public bool DelCom { get; set; }
    public int? UserId { get; set; }

    [Display(Name = "Approval Date")]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    public DateTime? ApproveDate { get; set; }

    public string OrderDetails => OrdNum1 + " " + Supplier.SupNam + " " + OrdDat.ToShortDateString();

    [Display(Name = "Total")]
    public decimal TotalAmount => Orders.Sum(o => o.Total);

    [Display(Name = "Approved by")]
    public string ApprovedBy => User.Name?.FullName ?? "-";
    public string DateApproved => ApproveDate is not null ? ApproveDate.Value.ToShortDateString() : " - ";
    public bool Deletable => DelBilNums.Count != 0;


    public required PriInqNum PriInqNum { get; set; }
    public required Supplier Supplier { get; set; }
    public required User User { get; set; }
    public required Year Year { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = [];
    public virtual ICollection<DelBilNum> DelBilNums { get; set; } = [];
}