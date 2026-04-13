namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(CountryCode), IsUnique = true)]
public partial class Country
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CountryId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(2)]
    public string CountryCode { get; set; } = "";

    [Required, MaxLength(100)]
    public string CountryName { get; set; } = "";

    public virtual ICollection<Address> Addresses { get; set; } = [];
    public virtual ICollection<CountryLanguage> CountryLanguages { get; set; } = [];
    public virtual ICollection<Supplier> Suppliers { get; set; } = [];
    public virtual ICollection<Jurisdiction> Jurisdictions { get; set; } = [];
    public virtual ICollection<User> PreferredByUsers { get; set; } = [];
}