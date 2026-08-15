namespace AmsModels;

[Index(nameof(IbuModuleSettingId), nameof(FieldId), IsUnique = true)]
[Index(nameof(FieldId))]
public sealed class IbuModuleFieldPermission
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IbuModuleFieldPermissionId { get; set; }

    public int IbuModuleSettingId { get; set; }

    public int FieldId { get; set; }

    public DateTime CreatedAtUtc { get; set; }

    public int? CreatedByUserId { get; set; }

    public IbuModuleSetting ModuleSetting { get; set; } = null!;

    public Field Field { get; set; } = null!;

    public User? CreatedByUser { get; set; }
}
