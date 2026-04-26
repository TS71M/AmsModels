namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ClimateZoneId), nameof(GrassSpeciesId), nameof(GrassTypeId), nameof(Active))]
public class RiskHeatStressRule
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RiskHeatStressRuleId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int? ClimateZoneId { get; set; }
    public ClimateZone? ClimateZone { get; set; }

    public int? GrassSpeciesId { get; set; }
    public GrassSpecies? GrassSpecies { get; set; }

    public int? GrassTypeId { get; set; }
    public GrassType? GrassType { get; set; }

    [Precision(5, 2)]
    public decimal ModerateTempC { get; set; } = 30m;

    [Precision(5, 2)]
    public decimal HighTempC { get; set; } = 35m;

    [Range(0, 24)]
    public int ModerateHours { get; set; } = 2;

    [Range(0, 24)]
    public int HighHours { get; set; } = 6;

    public int SortOrder { get; set; }
    public bool Active { get; set; } = true;
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;
}
