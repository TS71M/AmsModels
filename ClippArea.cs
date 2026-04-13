namespace AmsModels;

public partial class ClippArea
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ClippAreaId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int AreaId { get; set; }
    public int HoleId { get; set; }
    public bool Active { get; set; } = true;

    public string AreaHole => Area.AreaName + " " + Hole.HolShoNam;

    public required Area Area { get; set; }
    public required Hole Hole { get; set; }

    public virtual ICollection<ClippMeas> ClippMeass { get; set; } = [];
}