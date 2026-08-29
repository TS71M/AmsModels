namespace AmsModels;

public sealed class SprinklerDistributionProfile
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SprinklerDistributionProfileId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IrrigationSprinklerNozzleOptionId { get; set; }

    [Precision(6, 3), Range(typeof(decimal), "0.001", "100")]
    public decimal PressureBar { get; set; }

    [Required, MaxLength(500)]
    public string DataSource { get; set; } = "";

    [Required, MaxLength(40)]
    public string ConfidenceLevelCode { get; set; } = "";

    public bool Active { get; set; } = true;
    public DateTime CreatedAtUtc { get; set; }
    public DateTime UpdatedAtUtc { get; set; }

    public required IrrigationSprinklerNozzleOption NozzleOption { get; set; }
    public ICollection<SprinklerDistributionPoint> Points { get; set; } = [];
}
