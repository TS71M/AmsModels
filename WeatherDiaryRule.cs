namespace AmsModels;

[Index(nameof(EventKey), IsUnique = true)]
public sealed class WeatherDiaryRule
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WeatherDiaryRuleId { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    [MaxLength(120)]
    public string RuleName { get; set; } = "";

    [Required]
    [MaxLength(48)]
    public string EventKey { get; set; } = "";

    [Required]
    [MaxLength(32)]
    public string MetricKey { get; set; } = "";

    [Required]
    [MaxLength(8)]
    public string ComparisonType { get; set; } = "";

    [Required]
    [MaxLength(32)]
    public string BaselineSource { get; set; } = "None";

    [Precision(10, 2)]
    public decimal? WarningAbsolute { get; set; }

    [Precision(10, 2)]
    public decimal? DangerAbsolute { get; set; }

    [Precision(10, 2)]
    public decimal? WarningOffset { get; set; }

    [Precision(10, 2)]
    public decimal? DangerOffset { get; set; }

    [MaxLength(32)]
    public string? RelatedRiskKey { get; set; }

    public int? ClimateZoneId { get; set; }

    public int SortOrder { get; set; }

    [Required]
    public bool Active { get; set; } = true;

    public int? CreatedByUserId { get; set; }

    [Required]
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;

    [Required]
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;

    public ClimateZone? ClimateZone { get; set; }
    public User? CreatedByUser { get; set; }
}
