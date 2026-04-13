namespace AmsModels;

public partial class AgrTaskHole
{
    [Key]
    public int AgrTaskHoleId { get; set; }

    [Required]
    public int AgrTaskId { get; set; }

    [Required]
    public int HoleId { get; set; }

    [Required]
    public int SurfaceId { get; set; }

    public required AgrTask AgrTask { get; set; }
    public required Hole Hole { get; set; }
    public required Surface Surface { get; set; }
}