namespace AmsModels;

public partial class Surface
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SurfaceId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public int AreaId { get; set; }

    [Required]
    public int HoleId { get; set; }

    [Precision(7, 1)]
    public decimal SurfaceSizeM2 { get; set; }

    public virtual string SurfaceName => $"{Area.AreaName} {Hole.HolDes}";

    public required Field Field { get; set; }
    public required Area Area { get; set; }
    public required Hole Hole { get; set; }

    public virtual ICollection<AgrTaskHole> AgrTaskHoles { get; set; } = [];
    public virtual ICollection<AgrTaskWeekHole> AgrTaskWeekHoles { get; set; } = [];
    public virtual ICollection<AreaCompositionPhoto> AreaCompositionPhotos { get; set; } = [];
    public virtual ICollection<SoilTest> SoilTests { get; set; } = [];
    public virtual ICollection<TaskWorkHole> TaskWorkHoles { get; set; } = [];
}
