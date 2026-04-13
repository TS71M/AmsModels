namespace AmsModels;

public partial class AgrTaskWeekHole
{
    [Key]
    public int AgrTaskWeekHoleId { get; set; }

    [Required]
    public int AgrTaskWeekId { get; set; }

    [Required]
    public int HoleId { get; set; }

    [Required]
    public int SurfaceId { get; set; }

    public required AgrTaskWeek AgrTaskWeek { get; set; }
    public required Hole Hole { get; set; }
    public required Surface Surface { get; set; }
}