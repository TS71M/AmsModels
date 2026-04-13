namespace AmsModels;

public partial class OperationHole
{
    [Key]
    public int OperationHelpId { get; set; }
    public int OperationId { get; set; }
    public int HoleId { get; set; }

    public required Hole Hole { get; set; }
    public required Operation Operation { get; set; }
}