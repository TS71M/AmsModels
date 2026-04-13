namespace AmsModels;

public partial class DelBilNum
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DelBilNumId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int YearId { get; set; }

    [Display(Name = "Order Number")]
    public int OrdNumId { get; set; }

    [Required, Display(Name = "Delivery Number"), MaxLength(250)]
    public string DelBilNumName { get; set; } = "";

    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true), Display(Name = "Delivery Date")]
    public DateTime DelDat { get; set; }

    [Display(Name = "Delivery Completed")]
    public bool DelCom { get; set; }

    public required OrdNum OrdNum { get; set; }
    public required Year Year { get; set; }

    public virtual ICollection<DelBil> DelBils { get; set; } = [];
}