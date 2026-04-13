namespace AmsModels;

public partial class Name
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int NameId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }
    public int IbuId { get; set; }

    [Required, MaxLength(250)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; } = "";

    [MaxLength(250)]
    [Display(Name = "Middle Name")]
    public string? MiddleName { get; set; }

    [Required, MaxLength(250)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; } = "";

    [Display(Name = "Name")]
    public string FullName => $"{FirstName} {MiddleName ?? string.Empty} {LastName}".Trim();

    public required Ibu Ibu { get; set; }
}