namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(CountryId), nameof(LanguageId), IsUnique = true)]
public partial class CountryLanguage
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CountryLanguageId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int CountryId { get; set; }
    public int LanguageId { get; set; }

    public bool IsDefault { get; set; }
    public bool Active { get; set; } = true;
    public int SortOrder { get; set; }

    public Country? Country { get; set; }
    public Language? Language { get; set; }
}
