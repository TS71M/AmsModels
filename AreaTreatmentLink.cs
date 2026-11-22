namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(FieldId), nameof(Name), IsUnique = true)]
public sealed class AreaTreatmentLink
{
    [Key]
    public int AreaTreatmentLinkId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int FieldId { get; set; }
    [Required, MaxLength(80)]
    public string Name { get; set; } = "";
    public Field Field { get; set; } = null!;
}
