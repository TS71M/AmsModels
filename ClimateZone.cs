namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ZoneCode), IsUnique = true)]
public class ClimateZone
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ClimateZoneId { get; set; }

    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    [MaxLength(24)]
    public string ZoneCode { get; set; } = "";

    [Required]
    [MaxLength(120)]
    public string ZoneName { get; set; } = "";

    [Required]
    [MaxLength(64)]
    public string ClassificationSystem { get; set; } = "Koppen-Geiger";

    [MaxLength(120)]
    public string? SourceName { get; set; }

    [MaxLength(500)]
    public string? SourceUrl { get; set; }

    [MaxLength(500)]
    public string? Notes { get; set; }

    public int SortOrder { get; set; }

    [Required]
    public bool Active { get; set; } = true;

    public virtual ICollection<Field> Fields { get; set; } = [];
    public virtual ICollection<WeatherDiaryRule> WeatherDiaryRules { get; set; } = [];
}
