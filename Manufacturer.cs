namespace AmsModels;

public partial class Manufacturer
{
    [Key]
    public int ManufacturerId { get; set; }

    [Required, MaxLength(250)]
    public string Name { get; set; } = "";

    // Name remains the catalogue matching identity; presentation edits must not
    // rewrite historical evidence or string-based manufacturer relationships.
    [MaxLength(120)] public string? DisplayName { get; set; }
    [MaxLength(500)] public string? LogoUrl { get; set; }

    [Required, Url(ErrorMessage = "Please enter a valid URL."), MaxLength(250)]
    public string WebSite { get; set; } = "";

    public virtual ICollection<Machine> Machineries { get; set; } = [];
}
