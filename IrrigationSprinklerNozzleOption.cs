using Lib.Enums;

namespace AmsModels;

public sealed class IrrigationSprinklerNozzleOption
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationSprinklerNozzleOptionId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationSprinklerModelId { get; set; }
    public IrrigationNozzlePositionKind PositionKind { get; set; }

    [Required, MaxLength(80)]
    public string NozzleCode { get; set; } = "";

    [Required, MaxLength(160)]
    public string NozzleName { get; set; } = "";

    [MaxLength(80)]
    public string Color { get; set; } = "";

    [MaxLength(500)]
    public string? SourceUrl { get; set; }

    [MaxLength(2000)]
    public string ReferenceNotes { get; set; } = "";

    public bool IsLegacy { get; set; }
    public bool Active { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public required IrrigationSprinklerModel SprinklerModel { get; set; }
    public ICollection<IrrigationNozzleConfigurationSlot> ConfigurationSlots { get; set; } = [];
    public ICollection<SurfaceSprinklerNozzle> InstalledNozzles { get; set; } = [];
}
