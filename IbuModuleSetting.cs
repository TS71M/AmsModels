namespace AmsModels;

[Index(nameof(IbuId), nameof(ModuleKey), IsUnique = true)]
public class IbuModuleSetting
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IbuModuleSettingId { get; set; }

    public int IbuId { get; set; }

    [Required, MaxLength(80)]
    public string ModuleKey { get; set; } = "";

    public bool IsEnabled { get; set; } = true;

    public DateTime CreatedAtUtc { get; set; }

    public DateTime UpdatedAtUtc { get; set; }

    public int? UpdatedByUserId { get; set; }

    public Ibu? Ibu { get; set; }

    public User? UpdatedByUser { get; set; }
}
