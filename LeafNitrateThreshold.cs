namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(IbuId), nameof(ScopeType), nameof(Active))]
[Index(nameof(AreaId), nameof(Active))]
[Index(nameof(SurfaceId), nameof(Active))]
[Index(nameof(GrassSpeciesId), nameof(Active))]
public sealed class LeafNitrateThreshold
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int LeafNitrateThresholdId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public int IbuId { get; set; }
    public int? AreaId { get; set; }
    public int? SurfaceId { get; set; }
    public int? GrassSpeciesId { get; set; }
    public int? CreatedByUserId { get; set; }

    [Required, MaxLength(24)]
    public string ScopeType { get; set; } = "Area";

    [Required, MaxLength(64)]
    public string SampleMethod { get; set; } = "MowerCatchBoxClippings";

    [Precision(10, 2)]
    public decimal MinimumNo3NPpm { get; set; }

    [Precision(10, 2)]
    public decimal MaximumNo3NPpm { get; set; }

    public int? StartMonth { get; set; }
    public int? EndMonth { get; set; }

    [Precision(6, 2)]
    public decimal? MowingHeightMm { get; set; }

    [MaxLength(500)]
    public string? SourceReference { get; set; }

    [MaxLength(1000)]
    public string? Notes { get; set; }

    public DateTime EffectiveFromUtc { get; set; }
    public DateTime? EffectiveToUtc { get; set; }
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public bool Active { get; set; } = true;

    public Ibu Ibu { get; set; } = null!;
    public Area? Area { get; set; }
    public Surface? Surface { get; set; }
    public GrassSpecies? GrassSpecies { get; set; }
    public User? CreatedByUser { get; set; }
}
