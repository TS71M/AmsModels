namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(FieldId), nameof(Active))]
public sealed class FieldMask
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FieldMaskId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int FieldId { get; set; }
    public Field Field { get; set; } = null!;

    [Required, MaxLength(120)]
    public string MaskName { get; set; } = "";

    public FieldMaskType MaskType { get; set; } = FieldMaskType.Exclusion;
    public FieldMaskReason Reason { get; set; } = FieldMaskReason.Other;

    [Required]
    public string GeoJson { get; set; } = "";

    public bool Active { get; set; } = true;

    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedUtc { get; set; } = DateTime.UtcNow;
}
