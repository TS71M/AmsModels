namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuRelationshipId), nameof(FieldId), IsUnique = true)]
[Index(nameof(IbuRelationshipId))]
[Index(nameof(FieldId))]
public sealed class IbuRelationshipField
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IbuRelationshipFieldId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int IbuRelationshipId { get; set; }

    [Required]
    public int FieldId { get; set; }

    public IbuRelationship IbuRelationship { get; set; } = null!;
    public Field Field { get; set; } = null!;
}
