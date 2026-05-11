namespace AmsModels;

public class UserPermissionOverride
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserPermissionOverrideId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IbuId { get; set; }
    public int UserId { get; set; }

    [Required, MaxLength(80)]
    public string ModuleKey { get; set; } = "";

    [Required, MaxLength(80)]
    public string PermissionKey { get; set; } = "";

    public bool IsAllowed { get; set; }

    [MaxLength(500)]
    public string Reason { get; set; } = "";

    public required Ibu Ibu { get; set; }
    public required User User { get; set; }
}
