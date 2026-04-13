namespace AmsModels;

public partial class HoleGroup
{
    [Key]
    public int HoleGroupId { get; set; }
    public int FieldId { get; set; }

    [MaxLength(100)]
    public string GroupName { get; set; } = "";
    public string HoleNames = "";

    public required Field Field { get; set; }

    public ICollection<HoleGroupHole> HoleGroupHoles { get; set; } = [];

}