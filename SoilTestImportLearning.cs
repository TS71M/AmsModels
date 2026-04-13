namespace AmsModels;

[Table("SoilTestImportLearnings")]
[Index(nameof(FieldId), nameof(AliasKind), nameof(NormalizedSource), IsUnique = true)]
public partial class SoilTestImportLearning
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SoilTestImportLearningId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int FieldId { get; set; }

    [Required, MaxLength(50)]
    public string AliasKind { get; set; } = "";

    [Required, MaxLength(500)]
    public string SourceValue { get; set; } = "";

    [Required, MaxLength(500)]
    public string NormalizedSource { get; set; } = "";

    [MaxLength(250)]
    public string? CanonicalValue { get; set; }

    public int? SurfaceId { get; set; }
    public int? ChemId { get; set; }

    public int HitCount { get; set; }

    public DateTime LastUsedUtc { get; set; }

    public Field Field { get; set; } = null!;
    public Surface? Surface { get; set; }
    public Chemical? Chem { get; set; }
}
