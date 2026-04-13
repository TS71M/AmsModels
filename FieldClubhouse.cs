using Lib.Images;

namespace AmsModels;

public class FieldClubhouse
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BuildingClubhouseId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int FieldId { get; set; }
    public string Link { get; set; } = "";

    [Required, MaxLength(500)]
    public string Message { get; set; } = "";
    public string ClubInfo { get; set; } = "";
    public bool ShowWeather { get; set; }
    public bool ShowDailyMessage { get; set; }
    public bool ShowGreenSpeed { get; set; }
    public bool ShowJobs { get; set; }
    public bool ShowPinPosition { get; set; }
    public bool ShowImage { get; set; }
    public bool ShowClubInfo { get; set; }
    public bool ShowManager { get; set; }
    public int? ImageId { get; set; }

    public string Image => ImageX.ImageToString(AppImage?.ImageFile, ImageX.StandardImage.NoImage);

    public AppImage? AppImage { get; set; }
    public required Field Field { get; set; }
}