using Lib.Enums;

namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ManagerIbuId), nameof(ClientIbuId), IsUnique = true)]
[Index(nameof(ManagerIbuId), nameof(Active))]
[Index(nameof(ClientIbuId), nameof(Active))]
public class IbuRelationship
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IbuRelationshipId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int ManagerIbuId { get; set; }

    [Required]
    public int ClientIbuId { get; set; }

    [Required]
    public IbuRelationshipKinds.IbuRelationshipKind RelationshipKind { get; set; } = IbuRelationshipKinds.IbuRelationshipKind.ManagedBy;

    [Required]
    public IbuRelationshipFieldScopes.IbuRelationshipFieldScope Scope { get; set; } = IbuRelationshipFieldScopes.IbuRelationshipFieldScope.AllFields;

    [Required]
    public bool Active { get; set; } = true;

    [Required]
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    public Ibu ManagerIbu { get; set; } = null!;
    public Ibu ClientIbu { get; set; } = null!;
    public ICollection<IbuRelationshipField> ScopedFields { get; set; } = [];
}
