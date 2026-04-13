using Lib.Enums;

namespace AmsModels;

[Index(nameof(OwnerType), nameof(OwnerPubId), nameof(ChemId), nameof(MethodCodeNormalized), IsUnique = true)]
public sealed partial class SoilAnalyteGuideline
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SoilAnalyteGuidelineId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int ChemId { get; set; }

    [Required]
    public SoilGuidelineOwnerType OwnerType { get; set; } = SoilGuidelineOwnerType.Global;

    [Required]
    public Guid OwnerPubId { get; set; } = Guid.Empty;

    // store canonical method code if applicable; enforce uniqueness via normalized non-null string
    [Required, StringLength(50)]
    public string MethodCodeNormalized { get; set; } = ""; // "" means "all methods"

    // Optional: unit for the guideline (Unit has no PubId, so int FK is fine)
    public int? UnitId { get; set; }

    [Precision(18, 4)]
    public decimal? MinValue { get; set; }

    [Precision(18, 4)]
    public decimal? OptValue { get; set; }

    [Precision(18, 4)]
    public decimal? MaxValue { get; set; }

    public bool Active { get; set; } = true;

    public required Chemical Chem { get; set; }
    public Unit? Unit { get; set; }
}