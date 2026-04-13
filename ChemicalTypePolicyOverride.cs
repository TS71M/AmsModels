namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(OwnerType), nameof(OwnerId), nameof(ChemTypeId), IsUnique = true)]
[Index(nameof(OwnerId))]
[Index(nameof(ChemTypeId))]
public sealed partial class ChemicalTypePolicyOverride
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ChemTypePolOvrId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public ChemPolicyOwnerType OwnerType { get; set; }

    /// <summary>
    /// Internal owner id (IbuId or FieldId). Never exposed externally.
    /// </summary>
    [Required]
    public int OwnerId { get; set; }

    [Required]
    public int ChemTypeId { get; set; }

    [ForeignKey(nameof(ChemTypeId))]
    public ChemicalType? ChemType { get; set; }

    [Required]
    public bool Allowed { get; set; }

    public DateTimeOffset? ValidFromUtc { get; set; }
    public DateTimeOffset? ValidToUtc { get; set; }

    [MaxLength(500)]
    public string? Reason { get; set; }

    [Required]
    public bool Active { get; set; } = true;
}
