namespace AmsModels;

[Index(nameof(IrrigationScenarioId), nameof(IrrigationHeadId), IsUnique = true)]
[Index(nameof(IrrigationHeadId))]
[Index(nameof(IrrigationSprinklerNozzleOptionId))]
public sealed class IrrigationScenarioHeadSetting
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IrrigationScenarioHeadSettingId { get; set; }

    public int IrrigationScenarioId { get; set; }
    public int IrrigationHeadId { get; set; }
    public int? IrrigationSprinklerNozzleOptionId { get; set; }

    [Precision(8, 3), Range(typeof(decimal), "0", "30")]
    public decimal RuntimeMinutes { get; set; }

    [Precision(6, 3), Range(typeof(decimal), "0.001", "100")]
    public decimal? PressureOverrideBar { get; set; }

    public bool Enabled { get; set; } = true;

    [Precision(5, 1), Range(typeof(decimal), "0.1", "360")]
    public decimal? ArcOverrideDegrees { get; set; }

    public required IrrigationScenario IrrigationScenario { get; set; }
    public required IrrigationHead IrrigationHead { get; set; }
    public IrrigationSprinklerNozzleOption? NozzleOverride { get; set; }
}
