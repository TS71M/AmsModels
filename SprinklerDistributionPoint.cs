namespace AmsModels;

public sealed class SprinklerDistributionPoint
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SprinklerDistributionPointId { get; set; }

    public int SprinklerDistributionProfileId { get; set; }

    [Precision(7, 6), Range(typeof(decimal), "0", "1")]
    public decimal NormalizedDistance { get; set; }

    [Precision(10, 6), Range(typeof(decimal), "0", "1")]
    public decimal RelativeApplication { get; set; }

    public required SprinklerDistributionProfile Profile { get; set; }
}
