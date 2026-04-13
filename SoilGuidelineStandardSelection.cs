using Lib.Enums;

namespace AmsModels;

[Index(nameof(OwnerType), nameof(OwnerPubId), nameof(MethodCodeNormalized), IsUnique = true)]
public sealed partial class SoilGuidelineStandardSelection
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SoilGuidelineStandardSelectionId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public SoilGuidelineOwnerType OwnerType { get; set; } = SoilGuidelineOwnerType.Global;

    [Required]
    public Guid OwnerPubId { get; set; } = Guid.Empty; // Global = Guid.Empty

    [Required]
    public int StandardId { get; set; }

    [Required, StringLength(50)]
    public string MethodCodeNormalized { get; set; } = ""; // "" = all methods

    public bool Active { get; set; } = true;

    public required SoilGuidelineStandard Standard { get; set; }
}