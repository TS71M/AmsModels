namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(FieldId))]
public partial class Hole
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int HoleId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int FieldId { get; set; }
    public bool Active { get; set; } = true;

    [Required, MaxLength(100)]
    public string HolDes { get; set; } = "";

    [Required, MaxLength(3), DisplayName("Hole short")]
    public string HolShoNam { get; set; } = "";

    [DisplayName("Hole N°")]
    public int HoleNumber { get; set; } = 1;
    public int? ImageId { get; set; }

    public AppImage? AppImage { get; set; }
    public Field? Field { get; set; }

    public virtual ICollection<AgrTaskHole> AgrTaskHoles { get; set; } = [];
    public virtual ICollection<AgrTaskWeekHole> AgrTaskWeekHoles { get; set; } = [];
    public virtual ICollection<ClippArea> ClippAreas { get; set; } = [];
    public virtual ICollection<GreenSpeed> GreenSpeeds { get; set; } = [];
    public virtual ICollection<OperationHole> OperationHelps { get; set; } = [];
    public virtual ICollection<SnagList> SnagLists { get; set; } = [];
    public virtual ICollection<SoiTesSat> SoiTesSats { get; set; } = [];
    public virtual ICollection<Surface> Surfaces { get; set; } = [];
    public virtual ICollection<TaskWorkHole> TaskWorkHolesExecuteds { get; set; } = [];
}
