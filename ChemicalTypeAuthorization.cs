namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ChemTypeId))]
[Index(nameof(JurisdictionId))]
[Index(nameof(ChemTypeId), nameof(JurisdictionId), IsUnique = true)]
public sealed class ChemicalTypeAuthorization
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ChemTypeAuthId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int ChemTypeId { get; set; }

    [Required]
    public int JurisdictionId { get; set; }

    [Required]
    public bool Allowed { get; set; }

    public DateTimeOffset? ValidFromUtc { get; set; }
    public DateTimeOffset? ValidToUtc { get; set; }

    [Required]
    public bool Active { get; set; } = true;

    public ChemicalType? ChemType { get; set; }
    public Jurisdiction? Jurisdiction { get; set; }
}
