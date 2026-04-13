namespace AmsModels;

public sealed class FieldClimateNormal
{
    [Key]
    public int FieldClimateNormalId { get; set; }

    [Required]
    public Guid PubId { get; set; } // DB-generated (newsequentialid())

    [Required]
    public int FieldId { get; set; }

    [Required]
    public ClimateNormalSourceType SourceType { get; set; }

    public bool Active { get; set; } = true;

    // Optional metadata (helpful later, harmless now)
    public short? FromYear { get; set; }
    public short? ToYear { get; set; }

    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;

    public required Field Field { get; set; }
    public List<FieldClimateNormalMonth> Months { get; set; } = [];
}

public enum ClimateNormalSourceType : short
{
    Manual = 1,
    Calculated = 2
}