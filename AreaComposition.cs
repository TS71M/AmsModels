namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(AreaId))]
[Index(nameof(AreaId), nameof(ValidFromUtc))]
public class AreaComposition
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AreaCompositionId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int AreaId { get; set; }

    [Required]
    public DateTime ValidFromUtc { get; set; } = DateTime.UtcNow;

    public DateTime? ValidToUtc { get; set; }

    public Area? Area { get; set; }

    public ICollection<AreaGrassSpecies> GrassSpecies { get; set; } = [];
    public ICollection<AreaSoilType> SoilTypes { get; set; } = [];
}