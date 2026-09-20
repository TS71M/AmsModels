namespace AmsModels;

/// <summary>A SuperAdmin-approved physical identity crop, never proof of correct installation.</summary>
public sealed class IrrigationNozzleRecognitionReference
{
    [Key] public int IrrigationNozzleRecognitionReferenceId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int SurfaceSprinklerId { get; set; }
    public int SourceImageId { get; set; }
    public int IrrigationSprinklerModelId { get; set; }
    public int ApprovedByUserId { get; set; }
    public int Position { get; set; }
    [Required, MaxLength(80)] public string PartNumber { get; set; } = "";
    [MaxLength(80)] public string Color { get; set; } = "";
    [Required, MaxLength(64)] public string ApprovalHash { get; set; } = "";
    [Required, MaxLength(64)] public string ContentSha256 { get; set; } = "";
    public double CropX { get; set; }
    public double CropY { get; set; }
    public double CropWidth { get; set; }
    public double CropHeight { get; set; }
    [Required, MaxLength(524288)] public byte[] ImageBytes { get; set; } = [];
    [MaxLength(40)] public string OrientationStatus { get; set; } = "unknown";
    [MaxLength(240)] public string OrientationReason { get; set; } = "";
    public DateTime ApprovedAtUtc { get; set; }
    public bool Active { get; set; } = true;
    public SurfaceSprinkler SourceSprinkler { get; set; } = null!;
    public AppImage SourceImage { get; set; } = null!;
    public IrrigationSprinklerModel SprinklerModel { get; set; } = null!;
}
