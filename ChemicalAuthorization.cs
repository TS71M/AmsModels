namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(ChemId), nameof(JurisdictionId), IsUnique = true)]
[Index(nameof(JurisdictionId))]
[Index(nameof(ChemId))]
public class ChemicalAuthorization
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ChemicalAuthorizationId { get; set; }


    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int ChemId { get; set; }

    [Required]
    public int JurisdictionId { get; set; }

    public bool Active { get; set; } = true;     // allowed vs banned
    public bool Allowed { get; set; } = true;     // allowed vs banned
    public DateTime? ValidFromUtc { get; set; }
    public DateTime? ValidToUtc { get; set; }

    // optional regulatory fields:
    [MaxLength(100)]
    public string? RegistrationNo { get; set; }

    [MaxLength(500)]
    public string? LabelUrl { get; set; }

    [MaxLength(2000)]
    public string? Notes { get; set; }


    public Chemical Chemical { get; set; } = null!;
    public Jurisdiction Jurisdiction { get; set; } = null!;
}
