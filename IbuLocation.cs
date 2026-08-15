namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuId))]
[Index(nameof(IbuId), nameof(Active), nameof(SortOrder))]
[Index(nameof(FieldId), nameof(Active), nameof(SortOrder))]
public sealed class IbuLocation
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IbuLocationId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IbuId { get; set; }
    public int? FieldId { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; } = "";

    [MaxLength(250)]
    public string? Address { get; set; }

    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public bool IsPrimary { get; set; }
    public int SortOrder { get; set; }
    public bool Active { get; set; } = true;
    [DeleteBehavior(DeleteBehavior.Restrict)]
    public Ibu Ibu { get; set; } = null!;
    [DeleteBehavior(DeleteBehavior.Restrict)]
    public Field? Field { get; set; }
}
