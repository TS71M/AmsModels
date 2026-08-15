namespace AmsModels;

[Index(nameof(ModuleKey), nameof(IbuId), IsUnique = true)]
[Index(nameof(Active), nameof(ExpiresAtUtc))]
public class ModulePilotGrant
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ModulePilotGrantId { get; set; }

    [Required, MaxLength(80)]
    public string ModuleKey { get; set; } = "";

    public int IbuId { get; set; }

    public bool Active { get; set; } = true;

    public DateTime? ExpiresAtUtc { get; set; }

    public DateTime CreatedAtUtc { get; set; }

    public DateTime UpdatedAtUtc { get; set; }

    public int? UpdatedByUserId { get; set; }

    public Ibu? Ibu { get; set; }

    public User? UpdatedByUser { get; set; }
}
