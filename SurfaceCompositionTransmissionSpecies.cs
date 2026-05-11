namespace AmsModels;

[Index(nameof(PubId), IsUnique = true)]
[Index(nameof(SurfaceCompositionTransmissionId))]
[Index(nameof(GrassSpeciesId))]
public class SurfaceCompositionTransmissionSpecies
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SurfaceCompositionTransmissionSpeciesId { get; set; }

    [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PubId { get; set; }

    [Required]
    public int SurfaceCompositionTransmissionId { get; set; }

    public int? GrassSpeciesId { get; set; }

    [Required, MaxLength(250)]
    public string Name { get; set; } = "";

    [Precision(5, 1)]
    public decimal Percent { get; set; }

    [Precision(5, 4)]
    public decimal Confidence { get; set; }

    [MaxLength(1000)]
    public string? Notes { get; set; }

    [ForeignKey(nameof(SurfaceCompositionTransmissionId))]
    public SurfaceCompositionTransmission Transmission { get; set; } = default!;

    [ForeignKey(nameof(GrassSpeciesId))]
    public GrassSpecies? GrassSpecies { get; set; }
}
