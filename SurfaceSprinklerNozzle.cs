using Lib.Enums;

namespace AmsModels;

public sealed class SurfaceSprinklerNozzle
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SurfaceSprinklerNozzleId { get; set; }

    public int SurfaceSprinklerId { get; set; }
    public int? IrrigationSprinklerNozzleOptionId { get; set; }

    [Range(1, 5)]
    public int Position { get; set; }

    public IrrigationNozzlePositionKind PositionKind { get; set; }
    public IrrigationNozzleState State { get; set; }

    [Required, MaxLength(80)]
    public string PositionLabel { get; set; } = "";

    [MaxLength(80)]
    public string NozzleCode { get; set; } = "";

    [MaxLength(160)]
    public string NozzleName { get; set; } = "";

    [MaxLength(80)]
    public string Color { get; set; } = "";

    [Precision(5, 4)]
    public decimal? RecognitionConfidence { get; set; }

    public required SurfaceSprinkler SurfaceSprinkler { get; set; }
    public IrrigationSprinklerNozzleOption? NozzleOption { get; set; }
}
