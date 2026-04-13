namespace AmsModels;

public partial class PinPosition
{
    [Key]
    public int PinPositionId { get; set; }
    public int TaskGlobalId { get; set; }

    [Required, MaxLength(100)]
    public string PinPositionName { get; set; } = "";
    public int? PinPosId { get; set; }

    public string PinPosName => PinPos.PinPositionName;

    public required PinPos PinPos { get; set; }
    public required TaskGlobal TaskGlobal { get; set; }
}