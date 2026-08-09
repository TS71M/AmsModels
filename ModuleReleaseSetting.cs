namespace AmsModels;

[Index(nameof(ModuleKey), IsUnique = true)]
public class ModuleReleaseSetting
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ModuleReleaseSettingId { get; set; }

    [Required, MaxLength(80)]
    public string ModuleKey { get; set; } = "";

    public bool IsReleased { get; set; }

    public DateTime CreatedAtUtc { get; set; }

    public DateTime UpdatedAtUtc { get; set; }

    public int? UpdatedByUserId { get; set; }

    public User? UpdatedByUser { get; set; }
}
