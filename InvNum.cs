namespace AmsModels;

public partial class InvNum
{
    [Key]
    public int InvNumId { get; set; }
    public int FieldId { get; set; }

    [Display(Name = "Description")]
    public string InvDes { get; set; } = "";

    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    [Display(Name = "Date")]
    public DateTime InvDat { get; set; }
    public bool Booked { get; set; } = false;

    public required Field Field { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = [];
}