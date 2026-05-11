namespace AmsModels;

public class IbuAccessProfilePermission
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IbuAccessProfilePermissionId { get; set; }

    public int IbuAccessProfileId { get; set; }

    [Required, MaxLength(80)]
    public string ModuleKey { get; set; } = "";

    [Required, MaxLength(80)]
    public string PermissionKey { get; set; } = "";

    public bool IsAllowed { get; set; } = true;

    public required IbuAccessProfile AccessProfile { get; set; }
}
