namespace AmsModels;

public class FieldMaintenance
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BuildingMaintenanceId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int FieldId { get; set; }
    public string Link { get; set; } = "";
    public bool ShowWeather { get; set; }
    public bool ShowDailyMessage { get; set; }
    public bool ShowJobBoard { get; set; }
    [MaxLength(500)]
    public string Message { get; set; } = "";

    public required Field Field { get; set; }
}