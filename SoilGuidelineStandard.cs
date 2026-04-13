using Lib.Enums;

namespace AmsModels;

[Index(nameof(OwnerType), nameof(OwnerPubId), nameof(Code), IsUnique = true)]
public sealed class SoilGuidelineStandard
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SoilGuidelineStandardId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required, StringLength(30)]
    public string Code { get; set; } = ""; // "MLSN", "STERF", "KSU"

    [Required]
    public SoilGuidelineOwnerType OwnerType { get; set; } = SoilGuidelineOwnerType.Global;

    [Required]
    public Guid OwnerPubId { get; set; } = Guid.Empty; // Global = Guid.Empty

    [Required, StringLength(200)]
    public string Name { get; set; } = "";

    [StringLength(50)]
    public string? Version { get; set; } // "2024", "v1.2"

    [StringLength(500)]
    public string? SourceUrl { get; set; }

    public bool Active { get; set; } = true;

    public ICollection<SoilStandardAnalyteGuideline> Guidelines { get; set; } = [];
}
