namespace AmsModels;

public partial class ConBilNum
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ConBilNumId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int YearId { get; set; }
    public int FieldId { get; set; }
    public int ConBilNumName { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Consumption Date")]
    public DateTime UsingDate { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime EndDate { get; set; }
    public bool Booked { get; set; }
    public string? Comments { get; set; }

    public required Field Field { get; set; }
    public required Year Year { get; set; }


    public virtual ICollection<ConBil> ConBils { get; set; } = [];
    public virtual ICollection<Operation> Operations { get; set; } = [];
}