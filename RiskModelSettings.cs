[Index(nameof(SettingsKey), IsUnique = true)]
public class RiskModelSettings
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int RiskModelSettingsId { get; set; }

    [Required]
    [MaxLength(64)]
    public string SettingsKey { get; set; } = "global";

    [Precision(5, 2)]
    public decimal HeatStressModerateTempC { get; set; } = 30m;

    [Precision(5, 2)]
    public decimal HeatStressHighTempC { get; set; } = 35m;

    [Range(0, 24)]
    public int HeatStressModerateHours { get; set; } = 2;

    [Range(0, 24)]
    public int HeatStressHighHours { get; set; } = 6;

    [Precision(5, 2)]
    public decimal FrostModerateTempC { get; set; } = 2m;

    [Precision(5, 2)]
    public decimal FrostHighTempC { get; set; } = 0m;

    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;
}
