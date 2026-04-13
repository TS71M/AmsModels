namespace AmsModels;

[Index(nameof(SurfaceId), nameof(SoiTesDat), IsUnique = true)]
public partial class SoilTest
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SoiTesId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int SurfaceId { get; set; }

    [Required]
    public DateTime SoiTesDat { get; set; }

    public bool Ignore { get; set; }
    public string? MethodCode { get; set; }
    public string? MethodRaw { get; set; }

    public virtual string SurfaceName => Surface.SurfaceName;

    public required Surface Surface { get; set; }

    public virtual ICollection<SoilTestChem> SoilTestChems { get; set; } = [];

}