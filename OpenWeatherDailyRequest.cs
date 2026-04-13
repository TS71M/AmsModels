namespace AmsModels;

[Index(nameof(DayUtc), IsUnique = true)]
public class OpenWeatherDailyRequest
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    // Date only in UTC (e.g. 2026-02-08 00:00:00Z)
    [Required]
    public DateTime DayUtc { get; set; }

    [Required]
    public int RequestsUsed { get; set; }

    [Required]
    public DateTime UpdatedAtUtc { get; set; } = DateTime.UtcNow;
}
