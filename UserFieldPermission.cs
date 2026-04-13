namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(UserId), nameof(FieldId), IsUnique = true)]
[Index(nameof(UserId))]
[Index(nameof(FieldId))]
public sealed class UserFieldPermission
{
    [Key]
    public int UserFieldPermissionId { get; set; }

    [Required]
    public Guid PubId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required]
    public bool Active { get; set; } = true;

    [ForeignKey(nameof(UserId))]
    public User User { get; set; } = null!;

    [ForeignKey(nameof(FieldId))]
    public Field Field { get; set; } = null!;
}