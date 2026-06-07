namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(GroupKey), IsUnique = true)]
public class GrassSpeciesChartGroup
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GrassSpeciesChartGroupId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public bool Active { get; set; } = true;

    [Required]
    public DateTime CreatedAtUtc { get; set; }

    [Required]
    public DateTime UpdatedAtUtc { get; set; }

    [Required, MaxLength(80)]
    public string GroupKey { get; set; } = "";

    [Required, MaxLength(120)]
    public string DisplayName { get; set; } = "";

    [Required, MaxLength(40)]
    public string TaxonRank { get; set; } = "species_group";

    public bool IsChartable { get; set; } = true;

    public int SortOrder { get; set; }

    [MaxLength(16)]
    public string? ColorHex { get; set; }

    public ICollection<GrassSpeciesChartGroupTerm> Terms { get; set; } = [];
    public ICollection<SurfaceCompositionTransmissionSpecies> TransmissionSpecies { get; set; } = [];
}
