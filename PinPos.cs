namespace AmsModels;

public partial class PinPos
{
    [Key]
    public int PinPosId { get; set; }
    public int FieldId { get; set; }
    public bool Active { get; set; } = true;
    public string PinPositionName { get; set; } = "";

    public required Field Field { get; set; }

    public virtual ICollection<PinPosition> PinPositions { get; set; } = [];
}