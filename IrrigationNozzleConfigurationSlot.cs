using Lib.Enums;

namespace AmsModels;

public sealed class IrrigationNozzleConfigurationSlot
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationNozzleConfigurationSlotId { get; set; }

    public int IrrigationNozzleConfigurationId { get; set; }
    public int? IrrigationSprinklerNozzleOptionId { get; set; }

    [Range(1, 5)]
    public int Position { get; set; }

    public IrrigationNozzlePositionKind PositionKind { get; set; }

    [Required, MaxLength(80)]
    public string PositionLabel { get; set; } = "";

    [MaxLength(80)]
    public string NozzleCode { get; set; } = "";

    [MaxLength(160)]
    public string NozzleName { get; set; } = "";

    [MaxLength(80)]
    public string Color { get; set; } = "";

    public bool IsOptional { get; set; }

    public required IrrigationNozzleConfiguration Configuration { get; set; }
    public IrrigationSprinklerNozzleOption? NozzleOption { get; set; }
}
