namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuId))]
[Index(nameof(IbuId), nameof(Active), nameof(SortOrder))]
[Index(nameof(FieldId), nameof(Active), nameof(SortOrder))]
public sealed class IbuContact
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IbuContactId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IbuId { get; set; }
    public int? FieldId { get; set; }

    [Required, MaxLength(150)]
    public string Name { get; set; } = "";

    [MaxLength(100)] public string? Role { get; set; }
    [MaxLength(50)] public string? Phone { get; set; }
    [MaxLength(50)] public string? Mobile { get; set; }
    [MaxLength(250), EmailAddress] public string? Email { get; set; }
    public bool IsPrimary { get; set; }
    public int SortOrder { get; set; }
    public bool Active { get; set; } = true;
    [DeleteBehavior(DeleteBehavior.Restrict)]
    public Ibu Ibu { get; set; } = null!;
    [DeleteBehavior(DeleteBehavior.Restrict)]
    public Field? Field { get; set; }
}
