namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(AreaCompositionId))]
[Index(nameof(GrassSpeciesId))]
[Index(nameof(AreaCompositionId), nameof(GrassSpeciesId), IsUnique = true)]
public class AreaGrassSpecies
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AreaGrassSpeciesId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int AreaCompositionId { get; set; }

    [Required]
    public int GrassSpeciesId { get; set; }

    [Precision(3, 0)]
    public decimal Percent { get; set; }

    public AreaComposition? AreaComposition { get; set; }
    public GrassSpecies? GrassSpecies { get; set; }
}