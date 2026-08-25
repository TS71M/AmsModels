using Lib.Enums;

namespace AmsModels;

public sealed class IrrigationNozzleConfiguration
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationNozzleConfigurationId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int? IrrigationSprinklerModelId { get; set; }
    public int? IbuId { get; set; }
    public int? FieldId { get; set; }

    public IrrigationConfigurationScope Scope { get; set; } = IrrigationConfigurationScope.Global;

    [Required, MaxLength(100)]
    public string ScopeKey { get; set; } = "global";

    [Required, MaxLength(500)]
    public string UniquenessKey { get; set; } = "";

    [Required, MaxLength(160)]
    public string Name { get; set; } = "";

    public bool IsUnknownSprinkler { get; set; }

    [MaxLength(2000)]
    public string RecognitionHints { get; set; } = "";

    public bool IsAiDiscovered { get; set; }
    public bool IsApprovedReference { get; set; }
    public bool Active { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public IrrigationSprinklerModel? SprinklerModel { get; set; }
    public Ibu? Ibu { get; set; }
    public Field? Field { get; set; }
    public ICollection<IrrigationNozzleConfigurationSlot> Slots { get; set; } = [];
    public ICollection<SurfaceSprinkler> SurfaceSprinklers { get; set; } = [];
}
