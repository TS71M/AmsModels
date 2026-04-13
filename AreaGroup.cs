namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(Code), IsUnique = true)]
public class AreaGroup
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AreaGroupId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(40)]
    public string Code { get; set; } = "";

    [Required, MaxLength(80)]
    public string Name { get; set; } = "";

    public bool Active { get; set; } = true;

    // Behavior flags (drive UI + API rules)
    public bool SupportsSurfaces { get; set; }              // Hole×Area (Surface) allowed?
    public bool SupportsTurfDefaults { get; set; }          // NMax/ET/GDD/DollarSpot etc relevant?
    public bool SupportsComposition { get; set; }           // grass/soil composition relevant?

    // Optional ordering for dropdown
    public int SortOrder { get; set; } = 0;
}
