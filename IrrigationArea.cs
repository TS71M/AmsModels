namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IrrigationSystemId))]
[Index(nameof(FieldId))]
[Index(nameof(IrrigationSystemId), nameof(Name), IsUnique = true)]
[Index(nameof(IrrigationSystemId), nameof(Active))]
public sealed class IrrigationArea
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationAreaId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationSystemId { get; set; }
    public int? FieldId { get; set; }
    public int? SurfaceId { get; set; }
    public Surface? Surface { get; set; }

    [Required, MaxLength(160)]
    public string Name { get; set; } = "";

    [MaxLength(80)]
    public string AreaTypeCode { get; set; } = "";

    public bool Active { get; set; } = true;

    public required IrrigationSystem IrrigationSystem { get; set; }
    public Field? Field { get; set; }
    public IrrigationAreaBoundary? Boundary { get; set; }
    public ICollection<IrrigationAreaHead> HeadMemberships { get; set; } = [];
    public ICollection<IrrigationScenario> Scenarios { get; set; } = [];
    public ICollection<CatchCanTest> CatchCanTests { get; set; } = [];
    public ICollection<IrrigationCalibrationLayer> CalibrationLayers { get; set; } = [];
    public ICollection<IrrigationSourceReference> SourceReferences { get; set; } = [];
}
