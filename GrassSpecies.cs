namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(GrassTypeId))]
[Index(nameof(GrassTypeId), nameof(Name), IsUnique = true)]
[Index(nameof(MainImageId), IsUnique = true)]
public partial class GrassSpecies
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int GrassSpeciesId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    public bool Active { get; set; } = true;

    [Required]
    public DateTime CreatedAtUtc { get; set; }

    [Required]
    public DateTime UpdatedAtUtc { get; set; }

    [Required, MaxLength(250)]
    public string Name { get; set; } = "";

    [Required]
    public int GrassTypeId { get; set; }

    // If you can, rename to NMaxYear for clarity (kept as NMax to match your current property)
    [Precision(6, 1)]
    public decimal NMaxYear { get; set; }

    [Precision(6, 1)]
    public decimal NMaxMonth { get; set; }

    // K relative to N (dimensionless ratio)
    [Precision(5, 2)]
    public decimal KNRatioMin { get; set; } = 1.0m;

    [Precision(5, 2)]
    public decimal KNRatioMax { get; set; } = 1.5m;

    // Soil pH preference range
    [Precision(4, 1)]
    public decimal PHMin { get; set; }

    [Precision(4, 1)]
    public decimal PHMax { get; set; }

    // Salt tolerance range (keep int if you have a defined scale; otherwise consider 1–9 ratings)
    [Range(1, 9)]
    public int SaltToleranceMin { get; set; }

    [Range(1, 9)]
    public int SaltToleranceMax { get; set; }

    [MaxLength(250)]
    public string? LatinName { get; set; }

    [MaxLength(250)]
    public string? GrowthHabit { get; set; }

    // These are often unknown in datasets; keep nullable to avoid data-layer fallback text pollution
    [MaxLength(250)]
    public string? LiguleLeafMargin { get; set; }

    [MaxLength(250)]
    public string? AuriclesLeafHairs { get; set; }

    [MaxLength(250)]
    public string? VernationLeafStructure { get; set; }

    [MaxLength(250)]
    public string? CollarLeafArrangement { get; set; }

    [MaxLength(250)]
    public string? SeedheadColorFlowerColor { get; set; }

    [MaxLength(250)]
    public string? RootType { get; set; }

    public int? MainImageId { get; set; }
    public bool ShowInGtsInterpretation { get; set; } 
   
    // Navigation
    public GrassType GrassType { get; set; } = default!;

    [ForeignKey(nameof(MainImageId))]
    public AppImage? MainAppImage { get; set; }

    public ICollection<GrassSpeciesAlias> GraCulAliases { get; set; } = [];
    public ICollection<GrassSpeciesChemical> GraCulChems { get; set; } = [];
    public ICollection<GrassSpeciesTimingProfile> GrassSpeciesTimingProfiles { get; set; } = [];
    public ICollection<DieseaseGrassType> DiseaseGrassTypes { get; set; } = [];

    // Optional convenience (not persisted)
    [NotMapped]
    public decimal KNRatioMean => (KNRatioMin + KNRatioMax) / 2m;
}
