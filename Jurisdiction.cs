namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(CountryId))]
[Index(nameof(CountryId), nameof(Name), IsUnique = true)]
public class Jurisdiction
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int JurisdictionId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int CountryId { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; } = "";

    public bool Active { get; set; } = true;

    public Country? Country { get; set; }

    // Optional but recommended if you’ll often navigate from Jurisdiction -> authorizations:
    public virtual ICollection<ChemicalAuthorization> ChemicalAuthorizations { get; set; } = [];
}