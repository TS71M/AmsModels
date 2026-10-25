namespace AmsModels;

// An image can depict a verified mixture. Keep associations searchable without
// duplicating the AppImage or changing the existing gallery's primary species.
[PrimaryKey(nameof(GrassSpeciesPicId), nameof(GrassSpeciesId))]
[Index(nameof(GrassSpeciesId), nameof(GrassSpeciesPicId))]
public sealed class GrassSpeciesReferenceTaxon
{
    public int GrassSpeciesPicId { get; set; }
    public int GrassSpeciesId { get; set; }

    [Precision(5, 2), Range(0, 100)]
    public decimal? MeasuredCanopyPercent { get; set; }

    [ForeignKey(nameof(GrassSpeciesPicId))]
    public GrassSpeciesPic Picture { get; set; } = null!;

    [ForeignKey(nameof(GrassSpeciesId))]
    public GrassSpecies Species { get; set; } = null!;
}

// Historical metadata, association labels and verification decisions must survive
// later correction/retirement. This is domain provenance, not an operational log.
[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(GrassSpeciesPicId), nameof(Version), IsUnique = true)]
[Index(nameof(DatasetPartition), nameof(ProvenanceGroup))]
[Index(nameof(ContentHash))]
public sealed class GrassSpeciesReferenceRevision
{
    [Key]
    public int GrassSpeciesReferenceRevisionId { get; set; }
    public Guid PubId { get; set; } = Guid.NewGuid();
    public int GrassSpeciesPicId { get; set; }
    public int Version { get; set; }
    public int? ActorUserId { get; set; }
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

    // Indexed audit evidence makes earlier evaluation reservations durable after
    // metadata corrections. The JSON snapshot preserves the complete review.
    [MaxLength(16)]
    public string DatasetPartition { get; set; } = "reference";

    [MaxLength(120)]
    public string ProvenanceGroup { get; set; } = "";

    [MaxLength(64)]
    public string? ContentHash { get; set; }

    [MaxLength(32)]
    public string Action { get; set; } = "";

    [MaxLength(24000)]
    public string SnapshotJson { get; set; } = "";

    [ForeignKey(nameof(GrassSpeciesPicId))]
    public GrassSpeciesPic Picture { get; set; } = null!;

    [ForeignKey(nameof(ActorUserId))]
    public User? ActorUser { get; set; }
}
