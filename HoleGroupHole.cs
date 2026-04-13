namespace AmsModels;

public class HoleGroupHole
{
    [Key]
    public int HoleGroupHoleId { get; set; }
    public int HoleGroupId { get; set; }
    public int HoleId { get; set; }

    public required HoleGroup HoleGroup { get; set; }
    public required Hole Hole { get; set; }
}