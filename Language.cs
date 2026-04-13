namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(LanguageCode), IsUnique = true)]
[Index(nameof(CultureCode), IsUnique = true)]
public partial class Language
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LanguageId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, MaxLength(10)]
    public string LanguageCode { get; set; } = "";

    [Required, MaxLength(20)]
    public string CultureCode { get; set; } = "";

    [Required, MaxLength(100)]
    public string LanguageName { get; set; } = "";

    public bool Active { get; set; } = true;

    public virtual ICollection<CountryLanguage> CountryLanguages { get; set; } = [];
    public virtual ICollection<User> PreferredByUsers { get; set; } = [];
}