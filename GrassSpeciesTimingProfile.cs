namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(GrassSpeciesId))]
[Index(nameof(GrassSpeciesId), nameof(Code), IsUnique = true)]
[Index(nameof(GrassSpeciesId), nameof(DefaultName), IsUnique = true)]
public sealed class GrassSpeciesTimingProfile
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GrassSpeciesTimingProfileId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int GrassSpeciesId { get; set; }

    [Required, MaxLength(100)]
    public string Code { get; set; } = "";

    [Required, MaxLength(200)]
    public string DefaultName { get; set; } = "";

    public bool Active { get; set; } = true;
    public int SortOrder { get; set; }

    [Precision(9, 1)]
    public decimal PreferredFromGts { get; set; }

    [Precision(9, 1)]
    public decimal PreferredToGts { get; set; }

    [Precision(9, 1)]
    public decimal AcceptableFromGts { get; set; }

    [Precision(9, 1)]
    public decimal AcceptableToGts { get; set; }

    [MaxLength(1000)]
    public string? ManagementNote { get; set; }

    public GrassSpecies GrassSpecies { get; set; } = default!;
}
