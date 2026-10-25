namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(GrassSpeciesId))]
[Index(nameof(ImageId), IsUnique = true)]
[Index(nameof(ReferenceStatus), nameof(ReferencePartition), nameof(ReferenceKind), nameof(Active))]
[Index(nameof(ReferencePartition), nameof(ReferenceProvenanceGroup))]
public partial class GrassSpeciesPic
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GrassSpeciesPicId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public bool Active { get; set; } = true;

    [Required]
    public DateTime CreatedAtUtc { get; set; }

    [Required]
    public DateTime UpdatedAtUtc { get; set; }

    [Required]
    public int GrassSpeciesId { get; set; }

    [Required]
    public int ImageId { get; set; }

    [MaxLength(24)]
    public string ReferenceKind { get; set; } = "uncategorized";

    [MaxLength(24)]
    public string ReferenceStatus { get; set; } = "unverified";

    [MaxLength(16)]
    public string ReferencePartition { get; set; } = "reference";

    [ConcurrencyCheck]
    public int ReferenceVersion { get; set; }

    [MaxLength(16000)]
    public string? ReferenceMetadataJson { get; set; }

    [MaxLength(64)]
    public string? ReferenceContentHash { get; set; }

    [MaxLength(120)]
    public string ReferenceProvenanceGroup { get; set; } = "";

    public ICollection<GrassSpeciesReferenceTaxon> ReferenceTaxa { get; set; } = [];
    public ICollection<GrassSpeciesReferenceRevision> ReferenceRevisions { get; set; } = [];

    [ForeignKey(nameof(ImageId))]
    public AppImage AppImage { get; set; } = default!;

    [ForeignKey(nameof(GrassSpeciesId))]
    public GrassSpecies GrassSpecies { get; set; } = default!;
}