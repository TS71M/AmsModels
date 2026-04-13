namespace AmsModels;

[Index(nameof(StandardId), nameof(ChemId), nameof(MethodCodeNormalized), IsUnique = true)]
public sealed partial class SoilStandardAnalyteGuideline
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SoilStandardAnalyteGuidelineId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int StandardId { get; set; }

    [Required]
    public int ChemId { get; set; }

    [Required, StringLength(50)]
    public string MethodCodeNormalized { get; set; } = ""; // "" means all methods

    public int? UnitId { get; set; }

    [Precision(18, 4)]
    public decimal? MinValue { get; set; }

    [Precision(18, 4)]
    public decimal? OptValue { get; set; }

    [Precision(18, 4)]
    public decimal? MaxValue { get; set; }

    public bool Active { get; set; } = true;

    public required SoilGuidelineStandard Standard { get; set; }
    public required Chemical Chem { get; set; }
    public Unit? Unit { get; set; }
}