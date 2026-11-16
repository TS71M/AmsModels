namespace AmsModels;

[Index(nameof(RelationshipId), nameof(FieldId), nameof(RevokedAtUtc))]
[Index(nameof(PubId), IsUnique = true)]
public sealed class FertilizerPlanningGrant
{
    public int FertilizerPlanningGrantId { get; set; }
    public Guid PubId { get; set; }
    public int RelationshipId { get; set; }
    public int FieldId { get; set; }
    public int GrantedByUserId { get; set; }
    public DateTime GrantedAtUtc { get; set; }
    public int? RevokedByUserId { get; set; }
    public DateTime? RevokedAtUtc { get; set; }
    public Field Field { get; set; } = null!;
    public IbuRelationship Relationship { get; set; } = null!;
}
