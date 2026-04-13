namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(AreaCompositionId))]
[Index(nameof(SoilTypeId))]
[Index(nameof(AreaCompositionId), nameof(SoilTypeId), IsUnique = true)]
public class AreaSoilType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AreaSoilTypeId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int AreaCompositionId { get; set; }

    [Required]
    public int SoilTypeId { get; set; }

    [Precision(3, 0)]
    public decimal Percent { get; set; }

    public AreaComposition? AreaComposition { get; set; }
    public SoilType? SoilType { get; set; }
}