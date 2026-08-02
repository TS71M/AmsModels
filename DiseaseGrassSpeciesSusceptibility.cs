namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(DiseaseId), nameof(GrassSpeciesId), IsUnique = true)]
public sealed class DiseaseGrassSpeciesSusceptibility
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DiseaseGrassSpeciesSusceptibilityId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int DiseaseId { get; set; }

    [Required]
    public int GrassSpeciesId { get; set; }

    // 1 = low, 2 = moderate, 3 = high. Zero is deliberately invalid.
    [Range(1, 3)]
    public byte SusceptibilityLevel { get; set; }

    public bool Active { get; set; } = true;

    [Required, MaxLength(200)]
    public string ContentOwner { get; set; } = "";

    public DateTime? ReviewedAtUtc { get; set; }

    [MaxLength(1000)]
    public string? EvidenceNote { get; set; }

    [MaxLength(2048)]
    public string? SourceUrl { get; set; }

    public Disease Disease { get; set; } = default!;
    public GrassSpecies GrassSpecies { get; set; } = default!;
}
