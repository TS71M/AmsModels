namespace AmsModels;

public partial class License
{
    [Key]
    public int LicenseId { get; set; }
    public bool Active { get; set; } = true;

    [Required, MaxLength(250)]
    public string LicenseName { get; set; } = "";

    [Range(1, 120, ErrorMessage = "Duration must be between 1 and 120 months.")]
    public int Duration { get; set; }

    public virtual ICollection<LicenseIbu> LicenseIbus { get; set; } = [];
}