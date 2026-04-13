namespace AmsModels;

public sealed class FieldClimateNormalMonth
{
    [Key]
    public int FieldClimateNormalMonthId { get; set; }

    [Required]
    public Guid PubId { get; set; } // DB-generated

    [Required]
    public int FieldClimateNormalId { get; set; }

    // 1..12
    [Range(1, 12)]
    public byte Month { get; set; }

    // °C (one decimal is enough)
    public decimal Value { get; set; }

    public bool Active { get; set; } = true;

    public required FieldClimateNormal FieldClimateNormal { get; set; }
}
